using System.IO;

namespace SqlT.Tools;

/// <summary>
/// 生成插表SQL
/// </summary>
public class GenPdmInsertHelper
{
    /// <summary>
    /// 插入SQL
    /// </summary>
    private const string InsertSqlTemplate = @"INSERT INTO {表名} ({字段})  VALUES  ({插入字段})";
    /// <summary>
    /// 修改SQL
    /// </summary>
    private const string UpdateSqlTemplate = @"UPDATE {表名}  SET {修改字段} WHERE 1=1  {查询条件}";
    /// <summary>
    /// 删除SQL
    /// </summary>
    private const string DeleteSqlTemplate = @"DELETE FROM {表名}  WHERE 1=1 {查询条件}";

    /// <summary>
    /// 生成插表SQL
    /// </summary>
    /// <param name="pdm"></param>
    public void GenTableSql(Pdm pdm)
    {
        pdm.TableRoot.C_Tables.O_Table.ForEach(table =>
        {
            var tableName = table.A_Name;
            var tableCode = table.A_Code;
            var tableComment = table.A_Comment;
            var tableId = table.@Id;
            var columnSql = string.Empty;
            //主键
            table.C_Columns.O_Column.ForEach(column =>
            {
                var columnName = column.A_Name;
                var columnCode = column.A_Code;
                var columnComment = column.A_Comment;
                var columnId = column.@Id;
                var colUmnDataType = column.A_DataType.ToLower();
                var columnMandatory = column.A_Column_Mandatory;
           
            });
        });
    }
}