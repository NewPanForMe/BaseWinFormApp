using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace SqlT.Tools
{
    public static class PdmReaders
    {
        public static Pdm Pdm { get; set; }


        public static void Reads(string path)
        {
           // var allTableAttributes = new List<TableAttributes>();
            //var allTables = new List<TableData>();
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

        //if (xmlNode != null)
        //{
        //    var xmlNodeList = xmlNode.ChildNodes;
        //    foreach (XmlNode item in xmlNodeList)
        //    {
        //        var readTable = ReadTable(item, out var allTableAttribute);
        //        allTables.Add(readTable);
        //        allTableAttributes.AddRange(allTableAttribute);
        //    }
        //}
        //pdm.ListAttributesList = allTableAttributes;
        //pdm.ListTableData = allTables;
        //Pdm = pdm;



        /// <summary>
        /// 读取表结构
        /// </summary>
        /// <param name="node"></param>
        /// <param name="allTableAttribute"></param>
        /// <returns>TableData</returns>
        private static TableData ReadTable(XmlNode node, out List<TableAttributes> allTableAttribute)
        {
            #region 格式

            //< o:Table Id = "o6" >
            //    < a:ObjectID > 44D59721 - 0303 - 4567 - 858F - F2BA3CF10DAA </ a:ObjectID >
            //    < a:Name > wms_warehouse </ a:Name >
            //    < a:Code > wms_warehouse </ a:Code >
            //    < a:CreationDate > 1678068394 </ a:CreationDate >
            //    < a:Creator > zwk </ a:Creator >
            //    < a:ModificationDate > 1681106153 </ a:ModificationDate >
            //    < a:Modifier > yuans </ a:Modifier >
            //    < a:Comment > 仓库 </ a:Comment >
            //    < a:TotalSavingCurrency />
            //    < c:Columns >
            //    </ c:Columns >
            //    < c:Keys >
            //        < o:Key Id = "o96" >
            //            < a:ObjectID > F8B00728 - BA9C - 4C67 - BEFC - 6B121F34712F </ a:ObjectID >
            //            < a:Name > Key_1 </ a:Name >
            //            < a:Code > Key_1 </ a:Code >
            //            < a:CreationDate > 1678068428 </ a:CreationDate >
            //            < a:Creator > zwk </ a:Creator >
            //            < a:ModificationDate > 1678068532 </ a:ModificationDate >
            //            < a:Modifier > zwk </ a:Modifier >
            //            < c:Key.Columns >
            //                < o:Column Ref = "o87" />
            //            </ c:Key.Columns >
            //        </ o:Key >
            //    </ c:Keys >
            //    < c:PrimaryKey >
            //        < o:Key Ref = "o96" />
            //    </ c:PrimaryKey >
            //</ o:Table >


            #endregion
            allTableAttribute = new List<TableAttributes>();
            var keyValuePairs = new Dictionary<string, string>();//所有列存放
            var tableId = "";
            foreach (XmlNode item in node)
            {

                if (item.Name != "c:PrimaryKey")//设置主键
                {
                    XmlNodeList xmlNodeList = item.ChildNodes;
                    if (item.Name == "a:ObjectID")//获取ObjectID
                    {
                        tableId = item.InnerText;
                    }
                    if (item.Name == "c:Keys")//获取主键
                    {
                        var primaryKey = ReadPrimaryKey(xmlNodeList);
                        keyValuePairs.Add("c:PrimaryKey", primaryKey);
                    }
                    keyValuePairs.Add(item.Name, item.InnerText);
                    if (item.Name == "c:Columns")//读取表格字段
                    {
                        var readTableAttributes = ReadTableAttributes(xmlNodeList, tableId);
                        allTableAttribute.AddRange(readTableAttributes);
                    }
                }

            }
            TableData tableData = new TableData
            {
                TableCode = keyValuePairs.SingleOrDefault(x => x.Key == "a:Code").Value,
                TableComment = keyValuePairs.SingleOrDefault(x => x.Key == "a:Comment").Value,
                TableId = keyValuePairs.SingleOrDefault(x => x.Key == "a:ObjectID").Value,
                TableName = keyValuePairs.SingleOrDefault(x => x.Key == "a:Name").Value,
                TablePrimaryKey = keyValuePairs.SingleOrDefault(x => x.Key == "c:PrimaryKey").Value
            };
            return tableData;
        }

        /// <summary>
        /// 获取表主键
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        private static string ReadPrimaryKey(XmlNodeList keys)
        {
            #region 格式
            //  < c:Keys >
            //    < o:Key Id = "o96" >
            //    < a:ObjectID > F8B00728 - BA9C - 4C67 - BEFC - 6B121F34712F </ a:ObjectID >
            //    < a:Name > Key_1 </ a:Name >
            //    < a:Code > Key_1 </ a:Code >
            //    < a:CreationDate > 1678068428 </ a:CreationDate >
            //    < a:Creator > zwk </ a:Creator >
            //    < a:ModificationDate > 1678068532 </ a:ModificationDate >
            //    < a:Modifier > zwk </ a:Modifier >
            //    < c:Key.Columns >
            //          < o:Column Ref = "o87" />
            //    </ c:Key.Columns >
            //    </ o:Key >
            //  </ c:Keys >
            #endregion
            foreach (XmlNode key in keys)
            {
                foreach (XmlNode item in key.ChildNodes)
                {
                    if (item.Name == "c:Key.Columns")
                    {
                        foreach (XmlNode keyColumnItem in item)
                        {
                            string ids = keyColumnItem.Attributes?["Ref"].Value;
                            return ids;
                        }
                    }
                }
            }
            return "";
        }

        /// <summary>
        /// 读取表结构
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        private static List<TableAttributes> ReadTableAttributes(XmlNodeList columns, string tableId)
        {
            List<TableAttributes> attributes = new List<TableAttributes>();
            foreach (XmlNode column in columns)
            {
                var id = column.Attributes?["Id"].Value;
                var keyValuePairs = new Dictionary<string, string>();
                //将column下所有的节点放入dic
                foreach (XmlNode child in column.ChildNodes)
                {
                    keyValuePairs.Add(child.Name, child.InnerText);
                }
                TableAttributes tableAttribute = new TableAttributes
                {
                    Id = id,
                    ObjectId = keyValuePairs.SingleOrDefault(x => x.Key == "a:ObjectID").Value,
                    AttributeName = keyValuePairs.SingleOrDefault(x => x.Key == "a:Name").Value,
                    AttributeCode = keyValuePairs.SingleOrDefault(x => x.Key == "a:Code").Value,
                    AttributeComment = keyValuePairs.SingleOrDefault(x => x.Key == "a:Comment").Value,
                    AttributeDataType = keyValuePairs.SingleOrDefault(x => x.Key == "a:DataType").Value,
                    AttributeDataLength = keyValuePairs.SingleOrDefault(x => x.Key == "a:DataLength").Value,
                    AttributeMandatory = keyValuePairs.SingleOrDefault(x => x.Key == "a:Column.Mandatory").Value,
                    AttributeIdentity = keyValuePairs.SingleOrDefault(x => x.Key == "a:Identity").Value,
                    TableId = tableId
                };
                attributes.Add(tableAttribute);
            }
            return attributes;
        }
    }


}
