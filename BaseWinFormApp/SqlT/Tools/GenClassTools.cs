using System.IO;
using System.Net.Mime;

namespace SqlT.Tools;

/// <summary>
/// 生成表相关Model类
/// </summary>
public static class GenClassTools
{

    /// <summary>
    /// 生成类文件
    /// </summary>
    /// <param name="pdm"></param>
    /// <param name="nameSpace"></param>
    /// <param name="filePath"></param> 
    /// <returns></returns>
    public static void Generate(Pdm pdm, string nameSpace, string filePath)
    {
        var readAllText = File.ReadAllText("./Class.txt");
        pdm.TableRoot.C_Tables.O_Table.ForEach(table =>
        {
            var tableName = table.A_Name;
            var tableCode = table.A_Code;
            var tableComment = table.A_Comment;
            var tableId = table.Id;
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
                var endStr = string.Empty;
                if (colUmnDataType.Contains("int"))
                {
                    colUmnDataType = "long";
                    endStr = "=0;";
                }
                else if (colUmnDataType.Contains("varchar"))
                {
                    colUmnDataType = "string";
                    endStr = "=string.Empty;";

                }
                else if (colUmnDataType.Contains("datetime"))
                {
                    colUmnDataType = "DateTime";
                    endStr = "=new Datetime(1970,1,1);";
                }
                else if (colUmnDataType.Contains("text"))
                {
                    colUmnDataType = "string";
                    endStr = "=string.Empty;";
                }
                else if (colUmnDataType.Contains("bool"))
                {
                    endStr = "=false;";
                }


                columnSql += "  /// <summary>  \r\n ";
                columnSql += $" /// {columnComment} \r\n ";
                columnSql += "  /// </summary>  \r\n ";
                columnSql += $@"  public  {colUmnDataType} {columnCode} " + "  { get; set; }   "+ $"{endStr}" + "\r\n";
            });
            var content = readAllText.Replace("{命名空间}", nameSpace);
            content = content.Replace("{字段}", columnSql);
            content = content.Replace("{表名}", tableCode);
            content = content.Replace("{表头注释}", tableComment);
            var dir = Path.Combine(filePath, $"{tableCode}.cs");
            File.WriteAllText(dir, content);
        });
    }
}