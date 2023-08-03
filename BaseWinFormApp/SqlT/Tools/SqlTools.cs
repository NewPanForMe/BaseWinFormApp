using System;
using System.Configuration;
using System.Text;

namespace SqlT.Tools;

public class SqlTools
{

    private static readonly  string SqlServerCreateTable =
        "\r\ncreate table {表名} \r\n(\r\n {字段}  \r\n  constraint PK_{表名大写} primary key nonclustered ({主键}) \r\n)";
    private static readonly string PgSqlCreateTable =
        "\r\ncreate table {表名}\r\n(\r\n {字段}   \r\n    constraint PK_{表名大写} primary key ({主键})     \r\n);";
    private static readonly string MySqlCreateTable =
        "\r\ncreate table {表名}\r\n(\r\n   {字段} \r\n    primary key ({主键})    \r\n);";

    /// <summary>
    /// 生成Mysql
    /// </summary>
    /// <param name="pdm"></param>
    public static string  GenerateMySql(Pdm pdm)
    {
        var sql = new StringBuilder();
        pdm.TableRoot.C_Tables.O_Table.ForEach(table =>
        {
            var tableName = table.A_Name;
            var tableCode = table.A_Code;
            var tableComment = table.A_Comment;
            var tableId = table.@Id;
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
                var columnId = column.@Id;
                var colUmnDataType = column.A_DataType;
                var columnMandatory = column.A_Column_Mandatory;
                Console.WriteLine(colUmnDataType);
                if (colUmnDataType.Contains("timestamp"))
                {
                    colUmnDataType = "datetime";
                }

                columnSql += string.IsNullOrEmpty(columnMandatory)
                    ? $@"   {columnCode}  {colUmnDataType}  null  , " + " \r\n"
                    : $@"   {columnCode}  {colUmnDataType}  not null  ," + " \r\n";
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
    public static  string GenerateSqlServer(Pdm pdm)
    {
        var sql = new StringBuilder();
        pdm.TableRoot.C_Tables.O_Table.ForEach(table =>
        {
            var tableName = table.A_Name;
            var tableCode = table.A_Code;
            var tableComment = table.A_Comment;
            var tableId = table.@Id;
            var columnSql = string.Empty;
            //主键
            var pkId = table.C_Keys.O_Key.C_Key_Columns.O_Column.Ref;
            var tableSql = SqlServerCreateTable.Replace("{表名}", tableCode);
            tableSql = tableSql.Replace("{表名大写}", tableCode.ToUpper());
            table.C_Columns.O_Column.ForEach(column =>
            {
                var columnName = column.A_Name;
                var columnCode = column.A_Code;
                var columnComment = column.A_Comment;
                var columnId = column.@Id;
                var colUmnDataType = column.A_DataType;
                var columnMandatory = column.A_Column_Mandatory;
                Console.WriteLine(colUmnDataType);
                if (colUmnDataType.Contains("timestamp"))
                {
                    colUmnDataType = "datetime";
                }

                columnSql += string.IsNullOrEmpty(columnMandatory)
                    ? $@"   {columnCode}  {colUmnDataType}  null  , " + " \r\n"
                    : $@"   {columnCode}  {colUmnDataType}  not null ," + " \r\n";
                if (columnId == pkId)
                {
                    tableSql= tableSql.Replace("{主键}", columnCode);
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
    public static string GeneratePgSql(Pdm pdm)
    {
        var sql = new StringBuilder();
        pdm.TableRoot.C_Tables.O_Table.ForEach(table =>
        {
            var tableName = table.A_Name;
            var tableCode = table.A_Code;
            var tableComment = table.A_Comment;
            var tableId = table.@Id;
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
                var columnId = column.@Id;
                var colUmnDataType = column.A_DataType;
                var columnMandatory = column.A_Column_Mandatory;//not null
                var columnIdentity = column.A_Identity;//自增
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
}