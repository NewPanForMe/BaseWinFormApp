using System;
using System.Collections.Generic;
using System.Xml;
using SqlT.Models;

namespace SqlT.Tools
{
    public static class PdmReaders
    {
        /// <summary>
        /// PDM数据
        /// </summary>
        public static Pdm Pdm { get; set; }
        /// <summary>
        /// 主表数据
        /// </summary>
        public static List<Pdm_Table>  TableList = new List<Pdm_Table>();
        /// <summary>
        /// 详细数据
        /// </summary>
        public static List<Pdm_TableDetail> TableDetailList = new List<Pdm_TableDetail>();
        public static void Reads(string path)
        {
            var xml = new XmlDocument();
            var xmlNamespaceManager = new XmlNamespaceManager(xml.NameTable);
            xmlNamespaceManager.AddNamespace("a", "attribute");
            xmlNamespaceManager.AddNamespace("c", "collection");
            xmlNamespaceManager.AddNamespace("o", "object");
            xml.Load(path);

            var xmlNode = xml.SelectSingleNode("//c:Tables", xmlNamespaceManager);
            var xmlNodeRefer = xml.SelectSingleNode("//c:References", xmlNamespaceManager);
            Pdm = XmlToJson.ToJson(xmlNode, xmlNodeRefer);
        }

        /// <summary>
        /// 将PDM生成的数据转成list
        /// </summary>
        public static  void PdmToList()
        {
            var signCode = Guid.NewGuid().ToString();
            Pdm.TableRoot.C_Tables.O_Table.ForEach(table =>
            {
                var tableName = table.A_Name;
                var tableCode = table.A_Code;
                var tableComment = table.A_Comment;
                var columnSql = string.Empty;
                //主键
                var pkId = table.C_Keys.O_Key.C_Key_Columns.O_Column.Ref;
                var t = new Pdm_Table()
                {
                    Code = Guid.NewGuid().ToString(),
                    Comment = tableComment,
                    Name = tableName,
                    TbCode = tableCode,
                    SignCode = signCode,
                };
                table.C_Columns.O_Column.ForEach(column =>
                {
                    var columnName = column.A_Name;
                    var columnCode = column.A_Code;
                    var columnComment = column.A_Comment;
                    var columnId = column.Id;
                    var columnDataType = column.A_DataType;
                    var columnMandatory = column.A_Column_Mandatory;
                    var columnIdentity = column.A_Identity;
                    if (columnDataType.Contains("timestamp"))
                    {
                        columnDataType = "datetime";
                    }
                    if (pkId == columnId)
                    {
                        t.PK = columnName;
                        t.PkCode = columnCode;
                    }
                    TableDetailList.Add(new Pdm_TableDetail()
                    {
                        Code = Guid.NewGuid().ToString(),
                        Pdm_Table_Code = tableCode,
                        SignCode = signCode,
                        TCode = columnCode,
                        TComment = columnComment,
                        TDataType = columnDataType,
                        TIdentity = columnIdentity,
                        TMandatory = columnMandatory,
                        TName = columnName
                    });
                });
                TableList.Add(t);
            });
        }
    }
}
