using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CryptoProject
{
    class XMLOperations
    {
        public void RSAXMLKeys(String xml) 
        {
            Console.WriteLine(xml);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            String path = "RSAKeyValue";
            XmlNodeList nodes = doc.SelectNodes(path);
            XmlNode nodePublic = doc.SelectSingleNode("RSAKeyValue/Modulus");
            XmlNode nodePrivate = doc.SelectSingleNode("RSAKeyValue/D");
            Console.WriteLine(nodes.Count);
            Console.WriteLine(nodePublic.InnerText);
            Console.WriteLine(nodePrivate.InnerText);
            //Console.WriteLine(nodes.Item(7).InnerText);
        }

        public XmlDocument TDESKey(String keyText) 
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlNode root = doc.CreateElement("TDES");
            XmlNode key = doc.CreateElement("clave");
            key.InnerText = keyText;
            root.AppendChild(key);
            doc.AppendChild(root);
            return doc;
        }

        public void ExportXML(XmlDocument export, String name) 
        {
            String path = name;
            XmlDocument doc = export;
            // Save the document to a file and auto-indent the output.
            using (XmlTextWriter writer = new XmlTextWriter(path, null))
            {
                writer.Formatting = Formatting.Indented;
                doc.Save(writer);
            }
        }
        
    }
}
