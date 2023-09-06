using System.Xml;
using Newtonsoft.Json;

namespace SqlT.Tools;

public class XmlToJson
{
    /// <summary>
    /// xml转json
    /// </summary>
    /// <param name="content">需要转的内容</param>
    /// <param name="content2">需要转的内容</param>
    public static  Pdm ToJson(XmlNode content,XmlNode content2)
    {
        var deserializeXmlNode =JsonConvert.SerializeXmlNode(content);
        var deserializeXmlNode2 =JsonConvert.SerializeXmlNode(content2);
        deserializeXmlNode = Replace(deserializeXmlNode);
        deserializeXmlNode2 = Replace(deserializeXmlNode2);
        var deserializeRoot = JsonConvert.DeserializeObject<Root>(deserializeXmlNode);
        var deserializeReferRoot = JsonConvert.DeserializeObject<ReferRoot>(deserializeXmlNode2);
        return new Pdm()
        {
            ReferJsonString = deserializeXmlNode2,
            TableJsonString = deserializeXmlNode,
            TableRoot = deserializeRoot,
            ReferRoot = deserializeReferRoot
        };
    }

    /// <summary>
    /// 相关字符替换
    /// </summary>
    /// <param name="deserializeXmlNode"></param>
    /// <returns></returns>
    private static string Replace(string deserializeXmlNode)
    {
        deserializeXmlNode = deserializeXmlNode.Replace("a:ObjectID", "A_ObjectID");
        deserializeXmlNode = deserializeXmlNode.Replace("a:Name", "A_Name");
        deserializeXmlNode = deserializeXmlNode.Replace("a:Code", "A_Code");
        deserializeXmlNode = deserializeXmlNode.Replace("a:CreationDate", "A_CreationDate");
        deserializeXmlNode = deserializeXmlNode.Replace("a:Creator", "A_Creator");
        deserializeXmlNode = deserializeXmlNode.Replace("a:ModificationDate", "A_ModificationDate");
        deserializeXmlNode = deserializeXmlNode.Replace("a:Modifier", "A_Modifier");
        deserializeXmlNode = deserializeXmlNode.Replace("a:Comment", "A_Comment");
        deserializeXmlNode = deserializeXmlNode.Replace("a:Column.Mandatory", "A_Column_Mandatory");
        deserializeXmlNode = deserializeXmlNode.Replace("a:TotalSavingCurrency", "A_TotalSavingCurrency");
        deserializeXmlNode = deserializeXmlNode.Replace("a:DataType", "A_DataType");
        deserializeXmlNode = deserializeXmlNode.Replace("a:Length", "A_Length");
        deserializeXmlNode = deserializeXmlNode.Replace("o:Column", "O_Column");
        deserializeXmlNode = deserializeXmlNode.Replace("c:Key.Columns", "C_Key_Columns");
        deserializeXmlNode = deserializeXmlNode.Replace("o:Key", "O_Key");
        deserializeXmlNode = deserializeXmlNode.Replace("c:Keys", "C_Keys");
        deserializeXmlNode = deserializeXmlNode.Replace("c:PrimaryKey", "C_PrimaryKey");
        deserializeXmlNode = deserializeXmlNode.Replace("o:TableItem", "O_TableItem");
        deserializeXmlNode = deserializeXmlNode.Replace("c:Tables", "C_Tables");
        deserializeXmlNode = deserializeXmlNode.Replace("o:ColumnItem", "O_ColumnItem");
        deserializeXmlNode = deserializeXmlNode.Replace("c:Columns", "C_Columns");
        deserializeXmlNode = deserializeXmlNode.Replace("o:Column", "O_Column");
        deserializeXmlNode = deserializeXmlNode.Replace("o:Table", "O_Table");
        deserializeXmlNode = deserializeXmlNode.Replace("o:TableItem", "O_TableItem");
        deserializeXmlNode = deserializeXmlNode.Replace("a:Identity", "A_Identity");




        deserializeXmlNode = deserializeXmlNode.Replace("a:Cardinality", "A_Cardinality");
        deserializeXmlNode = deserializeXmlNode.Replace("a:UpdateConstraint", "A_UpdateConstraint");
        deserializeXmlNode = deserializeXmlNode.Replace("a:DeleteConstraint", "A_DeleteConstraint");
        deserializeXmlNode = deserializeXmlNode.Replace("c:ParentTable", "C_ParentTable");
        deserializeXmlNode = deserializeXmlNode.Replace("c:ChildTable", "C_ChildTable");
        deserializeXmlNode = deserializeXmlNode.Replace("c:ParentKey", "C_ParentKey");
        deserializeXmlNode = deserializeXmlNode.Replace("c:Joins", "C_Joins");
        deserializeXmlNode = deserializeXmlNode.Replace("o:ReferenceJoin", "O_ReferenceJoin");
        deserializeXmlNode = deserializeXmlNode.Replace("c:Object1", "C_Object1");
        deserializeXmlNode = deserializeXmlNode.Replace("c:Object2", "C_Object2");
        deserializeXmlNode = deserializeXmlNode.Replace("c:Joins", "C_Joins");
        deserializeXmlNode = deserializeXmlNode.Replace("c:References", "C_References");
        deserializeXmlNode = deserializeXmlNode.Replace("o:Reference", "O_Reference");



        deserializeXmlNode = deserializeXmlNode.Replace("@", "");
        return deserializeXmlNode;
    }

}