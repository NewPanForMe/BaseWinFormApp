using System;
using System.Configuration;
using System.Text;
using Public.Alert;

namespace SqlT.Tools;

public static class SqlTools
{
    private static readonly Pdm Pdm = PdmReaders.Pdm;

    private const string SqlServerCreateTable =
        "\r\ncreate table {表名} \r\n(\r\n {字段}  \r\n  constraint PK_{表名大写} primary key nonclustered ({主键}) \r\n);";

    private const string PgSqlCreateTable =
        "\r\ncreate table {表名}\r\n(\r\n {字段}   \r\n    constraint PK_{表名大写} primary key ({主键})     \r\n);";

    private const string MySqlCreateTable =
        "\r\ncreate table {表名}\r\n(\r\n   {字段} \r\n    primary key ({主键})    \r\n);";

    /// <summary>
    /// 插入SQL
    /// </summary>
    private const string InsertSqlTemplate = @"INSERT INTO {表名} ({字段})  VALUES  ({插入字段});";

    /// <summary>
    /// 生成Mysql
    /// </summary>
    /// <param name="pdm"></param>
    public static string GenerateMySql()
    {
        InitPdm();
        var sql = new StringBuilder();
        Pdm.TableRoot.C_Tables.O_Table.ForEach(table =>
        {
            var tableName = table.A_Name;
            var tableCode = table.A_Code;
            var tableComment = table.A_Comment;
            var tableId = table.Id;
            var columnSql = string.Empty;
            //主键
            var pkId = table.C_Keys.O_Key.C_Key_Columns.O_Column.Ref;
            var tableSql = MySqlCreateTable.Replace("{表名}", tableCode);
            tableSql = tableSql.Replace("{表名大写}", tableCode.ToUpper());
            tableSql = tableSql.Replace("{表注释}", tableComment);
            table.C_Columns.O_Column.ForEach(column =>
            {
                var columnName = column.A_Name;
                var columnCode = column.A_Code;
                var columnComment = column.A_Comment;
                var columnId = column.Id;
                var colUmnDataType = column.A_DataType;
                var columnMandatory = column.A_Column_Mandatory;
                var columnIdentity = column.A_Identity;
                if (colUmnDataType.Contains("timestamp"))
                {
                    colUmnDataType = "datetime";
                }

                columnSql += string.IsNullOrEmpty(columnMandatory)
                    ? $@"   {columnCode}  {colUmnDataType}  null  , " + " \r\n"
                    : $@"   {columnCode}  {colUmnDataType}  not null ," + " \r\n";
                if (columnId == pkId)
                {
                    tableSql = tableSql.Replace("{主键}", columnCode);
                }

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
        InitPdm();
        var sql = new StringBuilder();
        Pdm.TableRoot.C_Tables.O_Table.ForEach(table =>
        {
            var tableName = table.A_Name;
            var tableCode = table.A_Code;
            var tableComment = table.A_Comment;
            var tableId = table.Id;
            var columnSql = string.Empty;
            //主键
            var pkId = table.C_Keys.O_Key.C_Key_Columns.O_Column.@Ref;
            var tableSql = SqlServerCreateTable.Replace("{表名}", tableCode);
            tableSql = tableSql.Replace("{表名大写}", tableCode.ToUpper());
            table.C_Columns.O_Column.ForEach(column =>
            {
                var columnName = column.A_Name;
                var columnCode = column.A_Code;
                var columnComment = column.A_Comment;
                var columnId = column.Id;
                var colUmnDataType = column.A_DataType;
                var columnMandatory = column.A_Column_Mandatory;
                var columnIdentity = column.A_Identity;
                Console.WriteLine(colUmnDataType);
                if (colUmnDataType.Contains("timestamp"))
                {
                    colUmnDataType = "datetime";
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

                if (columnId == pkId)
                {
                    tableSql = tableSql.Replace("{主键}", columnCode);
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
        InitPdm();

        var sql = new StringBuilder();
        Pdm.TableRoot.C_Tables.O_Table.ForEach(table =>
        {
            var tableName = table.A_Name;
            var tableCode = table.A_Code;
            var tableComment = table.A_Comment;
            var tableId = table.Id;
            var columnSql = string.Empty;
            //主键
            var pkId = table.C_Keys.O_Key.C_Key_Columns.O_Column.Ref;
            var tableSql = PgSqlCreateTable.Replace("{表名}", tableCode);
            tableSql = tableSql.Replace("{表名大写}", tableCode.ToUpper());
            table.C_Columns.O_Column.ForEach(column =>
            {
                var columnName = column.A_Name;
                var columnCode = column.A_Code;
                var columnComment = column.A_Comment;
                var columnId = column.Id;
                var colUmnDataType = column.A_DataType;
                var columnMandatory = column.A_Column_Mandatory; //not null
                var columnIdentity = column.A_Identity; //自增
                columnSql += string.IsNullOrEmpty(columnMandatory)
                    ? $@"   {columnCode}  {colUmnDataType}  null  , " + " \r\n"
                    : $@"   {columnCode}  {colUmnDataType}  not null ," + " \r\n";
                if (!string.IsNullOrEmpty(columnIdentity))
                {
                    columnSql = $@"{columnCode}  SERIAL   not null ," + " \r\n";
                }

                if (columnId == pkId)
                {
                    tableSql = tableSql.Replace("{主键}", columnCode);
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
    public static void SavePdmTable()
    {
        InitPdm();
        //插表SQL
        var insertTableSql = string.Empty;
        var insertTableDetailSql = string.Empty;

        Pdm.TableRoot.C_Tables.O_Table.ForEach(table =>
        {
            var tableName = table.A_Name;
            var tableCode = table.A_Code;
            var tableComment = table.A_Comment;
            var tableId = table.Id;
            var columnSql = string.Empty;
            var tablePkName = string.Empty;
            var tablePkCode = string.Empty;
            var pkId = table.C_Keys.O_Key.C_Key_Columns.O_Column.@Ref;
            table.C_Columns.O_Column.ForEach(column =>
            {
                var columnName = column.A_Name;
                var columnCode = column.A_Code;
                var columnComment = column.A_Comment;
                var columnId = column.Id;
                var colUmnDataType = column.A_DataType;
                var columnMandatory = column.A_Column_Mandatory; //not null
                var columnIdentity = column.A_Identity; //自增

                if (columnId == pkId)
                {
                    tablePkName = columnName;
                    tablePkCode = columnCode;
                }

            });
            //主键
            var code = Guid.NewGuid().ToString();
            //主表sql
            var tableSql = InsertSqlTemplate.Replace("{表名}", tableCode);
            tableSql = tableSql.Replace("{字段}", "[Code]\r\n  ,[Name]\r\n,[TbCode]\r\n ,[Comment]\r\n ,[PK]\r\n,[PkCode]\r\n");
            tableSql = tableSql.Replace("{插入字段}", $"'{code}','{tableName}','{tableCode}','{tableComment}','{tablePkCode}','{tablePkName}'");
            insertTableSql += tableSql;
            //子表SQL
            var tableDetailSql = InsertSqlTemplate.Replace("{表名}", "[Pdm_TableDetail]");





        });
    }





    /// <summary>
    /// 验证是否读取到PDM
    /// </summary>
    private static void InitPdm()
    {
        if (Pdm == null)
        {
            MessageAlert.ShowWarning(@"未读取到PDM数据");
            return;
        }
    }
}