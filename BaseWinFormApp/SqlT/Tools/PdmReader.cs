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


    
    }


}
