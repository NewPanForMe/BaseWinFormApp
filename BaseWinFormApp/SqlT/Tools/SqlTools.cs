using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using Public.Alert;
using SqlT.Models;

namespace SqlT.Tools;

public static class SqlTools
{
    /// <summary>
    /// 表数据
    /// </summary>
    private static readonly List<Pdm_Table> TableList = PdmReaders.TableList;

    /// <summary>
    /// 表具体字段
    /// </summary>
    private static readonly List<Pdm_TableDetail> TableDetailList = PdmReaders.TableDetailList;

    /// <summary>
    /// SQL Server建表语句
    /// </summary>
    private const string SqlServerCreateTable =
        "\r\ncreate table [{表名}] \r\n(\r\n {字段}  \r\n  constraint PK_{表名大写} primary key nonclustered ({主键}) \r\n);";

    /// <summary>
    /// PgSQL建表语句
    /// </summary>
    private const string PgSqlCreateTable =
        "\r\ncreate table [{表名}]\r\n(\r\n {字段}   \r\n    constraint PK_{表名大写} primary key ({主键})     \r\n);";

    /// <summary>
    /// MySQL建表语句
    /// </summary>
    private const string MySqlCreateTable =
        "\r\ncreate table [{表名}]\r\n(\r\n   {字段} \r\n    primary key ({主键})    \r\n);";

    /// <summary>
    /// 插入SQL
    /// </summary>
    private const string InsertSqlTemplate = "INSERT INTO {表名} ({字段})  VALUES  ({插入字段});\r\n";

    /// <summary>
    /// 修改SQL模板
    /// </summary>
    private const string UpdateSqlTemplate = "alter table {表名} alter column {字段名称} {类型} {是否为空};  \r\n ";

    /// <summary>
    /// 新增表字段
    /// </summary>
    private const string AddTableAttrSqlTemplate = "alter table {表名} add  {字段名称} {类型} {是否为空}; \r\n";
    /// <summary>
    /// 删除字段模板
    /// </summary>
    private const string DeleteTableAttrSqlTemplate = "alter table {表名} drop column {字段名称}; \r\n";

    /// <summary>
    /// 修改字段模板
    /// </summary>
    private const string UpdateNameSqlTemplate = "exec sp_rename '{表名}.{列名}','{新列名}'; \r\n";

    /// <summary>
    /// 删除表模板
    /// </summary>
    private const string DropTableSqlTemplate = "drop table {表名}; \r\n ";


    /// <summary>
    /// 上次存储的signcode
    /// </summary>
    private const string PdmTableListSignCodeFile = "./PdmTableSignCode.txt";


    /// <summary>
    /// 验证是否读取到PDM
    /// </summary>
    public static void InitList()
    {
        if (TableDetailList.Count <= 0 || TableList.Count <= 0)
        {
            MessageAlert.ShowWarning(@"未读取到PDM数据");
        }
    }

    /// <summary>
    /// 生成Mysql
    /// </summary>
    /// <param name="pdm"></param>
    public static string GenerateMySql()
    {
        InitList();
        var sql = new StringBuilder();
        TableList.ForEach(table =>
        {
            var tableName = table.Name;
            var tableCode = table.TbCode;
            var tableComment = table.Comment;
            var tablePkCode = table.PkCode;
            var columnSql = string.Empty;
            var tableSql = MySqlCreateTable.Replace("{表名}", tableCode);
            tableSql = tableSql.Replace("{表名大写}", tableCode.ToUpper());
            tableSql = tableSql.Replace("{表注释}", tableComment);
            tableSql = tableSql.Replace("{主键}", tablePkCode);
            var pdmTableDetails = TableDetailList.Where(x => x.Pdm_Table_Code == table.TbCode).ToList();
            pdmTableDetails.ForEach(tableDetail =>
            {
                var columnName = tableDetail.TName;
                var columnCode = tableDetail.TCode;
                var columnComment = tableDetail.TComment;
                var colUmnDataType = tableDetail.TDataType;
                var columnMandatory = tableDetail.TMandatory;
                var columnIdentity = tableDetail.TIdentity;
                if (colUmnDataType.Contains("timestamp"))
                {
                    colUmnDataType = "datetime";
                }
                columnSql += string.IsNullOrEmpty(columnMandatory)
                    ? $@"   {columnCode}  {colUmnDataType}  null  , " + " \r\n"
                    : $@"   {columnCode}  {colUmnDataType}  not null ," + " \r\n";
            });
            tableSql = tableSql.Replace("{字段}", columnSql);
            sql.Append(tableSql);
        });
        return sql.ToString();
    }

    /// <summary>
    /// 生成sqlserver
    /// </summary>
    /// <param name="pdm"></param>
    public static string GenerateSqlServer()
    {
        InitList();
        var sql = new StringBuilder();

        TableList.ForEach(table =>
        {
            var tableName = table.Name;
            var tableCode = table.TbCode;
            var tableComment = table.Comment;
            var tablePkCode = table.PkCode;

            var columnSql = string.Empty;
            var tableSql = SqlServerCreateTable.Replace("{表名}", tableCode);
            tableSql = tableSql.Replace("{表名大写}", tableCode.ToUpper());
            tableSql = tableSql.Replace("{表注释}", tableComment);
            tableSql = tableSql.Replace("{主键}", tablePkCode);
            var pdmTableDetails = TableDetailList.Where(x => x.Pdm_Table_Code == table.TbCode).ToList();
            pdmTableDetails.ForEach(tableDetail =>
            {
                var columnName = tableDetail.TName;
                var columnCode = tableDetail.TCode;
                var columnComment = tableDetail.TComment;
                var colUmnDataType = tableDetail.TDataType;
                var columnMandatory = tableDetail.TMandatory;
                var columnIdentity = tableDetail.TIdentity;
                if (colUmnDataType.Contains("timestamp"))
                {
                    colUmnDataType = "datetime";
                }
                if (colUmnDataType.Contains("bool") )
                {
                    colUmnDataType = "bit";
                }
                if (!string.IsNullOrEmpty(columnIdentity) && columnCode.ToLower() == "id")
                {
                    columnSql += $@"   {columnCode}  {colUmnDataType}  identity(1,1)  , " + " \r\n";
                }
                else
                {
                    columnSql += string.IsNullOrEmpty(columnMandatory)
                        ? $@"   {columnCode}  {colUmnDataType}  null  , " + " \r\n"
                        : $@"   {columnCode}  {colUmnDataType}  not null ," + " \r\n";
                }

            });
            tableSql = tableSql.Replace("{字段}", columnSql);
            sql.Append(tableSql);
        });

        return sql.ToString();
    }

    /// <summary>
    /// 生辰pgsql
    /// </summary>
    /// <param name="pdm"></param>
    public static string GeneratePgSql()
    {
        InitList();
        var sql = new StringBuilder();
        TableList.ForEach(table =>
        {
            var tableName = table.Name;
            var tableCode = table.TbCode;
            var tableComment = table.Comment;
            var tablePkCode = table.PkCode;

            var columnSql = string.Empty;
            var tableSql = SqlServerCreateTable.Replace("{表名}", tableCode);
            tableSql = tableSql.Replace("{表名大写}", tableCode.ToUpper());
            tableSql = tableSql.Replace("{表注释}", tableComment);
            tableSql = tableSql.Replace("{主键}", tablePkCode);
            var pdmTableDetails = TableDetailList.Where(x => x.Pdm_Table_Code == table.TbCode).ToList();
            pdmTableDetails.ForEach(tableDetail =>
            {
                var columnName = tableDetail.TName;
                var columnCode = tableDetail.TCode;
                var columnComment = tableDetail.TComment;
                var colUmnDataType = tableDetail.TDataType;
                var columnMandatory = tableDetail.TMandatory;
                var columnIdentity = tableDetail.TIdentity;
                if (colUmnDataType.Contains("timestamp"))
                {
                    colUmnDataType = "datetime";
                }
                columnSql += string.IsNullOrEmpty(columnMandatory)
                    ? $@"   {columnCode}  {colUmnDataType}  null  , " + " \r\n"
                    : $@"   {columnCode}  {colUmnDataType}  not null ," + " \r\n";
                if (!string.IsNullOrEmpty(columnIdentity))
                {
                    columnSql = $@"{columnCode}  SERIAL   not null ," + " \r\n";
                }

            });
            tableSql = tableSql.Replace("{字段}", columnSql);
            sql.Append(tableSql);
        });
        return sql.ToString();
    }

    /// <summary>
    /// 保存PDM中的表
    /// </summary>
    public static bool SavePdmTable()
    {
        InitList();
        //插表SQL
        var insertTableSql = string.Empty;
        var insertTableDetailSql = string.Empty;
        var signCode = Guid.NewGuid().ToString();
        File.Delete(PdmTableListSignCodeFile);
        File.WriteAllText(PdmTableListSignCodeFile, signCode);
        TableList.ForEach(table =>
        {
            var tableName = table.Name;
            var tableCode = table.TbCode;
            var tableComment = table.Comment;
            var tablePkName = table.PK;
            var tablePkCode = table.PkCode;
            var columnSql = string.Empty;
            //主键
            var code = Guid.NewGuid().ToString();
            var pdmTableDetails = TableDetailList.Where(x => x.Pdm_Table_Code == table.TbCode).ToList();
            pdmTableDetails.ForEach(tableDetail =>
            {
                var columnName = tableDetail.TName;
                var columnCode = tableDetail.TCode;
                var columnComment = tableDetail.TComment;
                var columnDataType = tableDetail.TDataType;
                var columnMandatory = tableDetail.TMandatory;
                var columnIdentity = tableDetail.TIdentity;

                //子表SQL
                var tableDetailSql = InsertSqlTemplate.Replace("{表名}", "[Pdm_TableDetail]");
                tableDetailSql = tableDetailSql.Replace("{字段}", "[Code],[TName],[TCode],[TComment],[TDataType],[TIdentity],[TMandatory], [Pdm_Table_Code],[SignCode]");
                tableDetailSql = tableDetailSql.Replace("{插入字段}", $"'{Guid.NewGuid()}','{columnName}','{columnCode}','{columnComment}','{columnDataType}','{columnIdentity}','{columnMandatory}','{tableCode}','{signCode}'");
                insertTableDetailSql += tableDetailSql;

            });
            //主表sql
            var tableSql = InsertSqlTemplate.Replace("{表名}", "[Pdm_Table]");
            tableSql = tableSql.Replace("{字段}", "[Code]\r\n  ,[Name]\r\n,[TbCode]\r\n ,[Comment]\r\n ,[PK]\r\n,[PkCode],[SignCode]");
            tableSql = tableSql.Replace("{插入字段}", $"'{code}','{tableName}','{tableCode}','{tableComment}','{tablePkName}','{tablePkCode}','{signCode}'");
            insertTableSql += tableSql;

        });
        var execute = SqlDbHelper.Execute(insertTableSql, true);
        var executeDetail = SqlDbHelper.Execute(insertTableDetailSql, true);
        if (execute > 0 && executeDetail > 0)
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// 对比旧的PDM数据，生成修改SQL
    /// </summary>
    public static string CompareTableListSqlServer()
    {
        InitList();
        var signCode = File.ReadAllText(PdmTableListSignCodeFile);
        var pdmTables = SqlDbHelper.Query<Pdm_Table>($"select * from Pdm_Table where SignCode='{signCode}'");
        var pdmTableDetails = SqlDbHelper.Query<Pdm_TableDetail>($"select * from Pdm_TableDetail where SignCode='{signCode}'");
        var sqlBuilder = new StringBuilder();
        pdmTables.ForEach(table =>
        {
            //查找对应的记录
            var firstOrDefault = TableList.Exists(x => x.TbCode == table.TbCode);
            if (!firstOrDefault)
            {
                //如果在新的PDM中没有找到，说明表被删了
                var replace = DropTableSqlTemplate.Replace("{表名}", table.TbCode);
                sqlBuilder.Append(replace);
            }
            else
            {
                //表没删
                //开始对比字段
                //旧字段
                var tableOldDetails = pdmTableDetails.Where(x => x.Pdm_Table_Code == table.TbCode).ToList();
                //本次上传的新字段
                var tableDetails = TableDetailList.Where(x => x.Pdm_Table_Code == table.TbCode).ToList();
                tableDetails.ForEach(tableDetail =>
                {
                    var exists = tableOldDetails.Exists(x => x.TCode == tableDetail.TCode);
                    if (exists)
                    {
                        //字段存在，对比其他
                        var oldTableDetail = tableOldDetails.Single(x => x.TCode == tableDetail.TCode);
                        var c = oldTableDetail.TComment;
                        if (tableDetail.TDataType != oldTableDetail.TDataType)
                        {
                            var updateSqlTemplate = UpdateSqlTemplate.Replace("{表名}", table.TbCode);
                            updateSqlTemplate = updateSqlTemplate.Replace("{字段名称}", tableDetail.TCode);
                            updateSqlTemplate = updateSqlTemplate.Replace("{类型}", tableDetail.TDataType);
                            updateSqlTemplate = string.IsNullOrEmpty(tableDetail.TMandatory)
                                ? updateSqlTemplate.Replace("{是否为空}", " null ")
                                : updateSqlTemplate.Replace("{是否为空}", " not null");
                            sqlBuilder.Append(updateSqlTemplate);
                        }
                    }
                    else
                    {
                        //字段不存在.
                        //新的里面有，旧的里面没有，需要新增字段
                        var addSqlTemplate = AddTableAttrSqlTemplate.Replace("{表名}", table.TbCode);
                        addSqlTemplate = addSqlTemplate.Replace("{字段名称}", tableDetail.TCode);
                        addSqlTemplate = addSqlTemplate.Replace("{类型}", tableDetail.TDataType);
                        addSqlTemplate = string.IsNullOrEmpty(tableDetail.TMandatory)
                            ? addSqlTemplate.Replace("{是否为空}", " null ")
                            : addSqlTemplate.Replace("{是否为空}", " not null");
                        sqlBuilder.Append(addSqlTemplate);
                    }





                });

                tableOldDetails.ForEach(oldTableDetail =>
                {
                    var exists = tableDetails.Exists(x => x.TCode == oldTableDetail.TCode);
                    if (!exists)
                    {
                        //不存在，说明字段呗删除2
                        var addSqlTemplate = DeleteTableAttrSqlTemplate.Replace("{表名}", table.TbCode);
                        addSqlTemplate = addSqlTemplate.Replace("{字段名称}", oldTableDetail.TCode);
                        sqlBuilder.Append(addSqlTemplate);
                    }
                });
            }
        });
        return sqlBuilder.ToString();
    }
}