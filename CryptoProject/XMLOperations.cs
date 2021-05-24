using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CryptoProject
{
    class XMLOperations
    {
        public XmlDocument RSAXMLKeys(String xml) 
        {
            Console.WriteLine(xml);
            XmlDocument doc = new XmlDocument();
            String tempString = xml;
            tempString = xml;
            Console.WriteLine(tempString);
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlNode root = doc.CreateElement("RSA");
            XmlNode key = doc.CreateElement("clave");
            key.InnerText = tempString;
            XmlNode keyPrivate = doc.CreateElement("clavePrivada");
            keyPrivate.InnerText = tempString;
            root.AppendChild(key);
            root.AppendChild(keyPrivate);
            doc.AppendChild(root);
            /*doc.LoadXml(xml);
            String path = "RSAKeyValue";
            XmlNodeList nodes = doc.SelectNodes(path);
            XmlNode nodePublic = doc.SelectSingleNode("RSAKeyValue/Modulus");
            XmlNode nodePrivate = doc.SelectSingleNode("RSAKeyValue/D");
            Console.WriteLine(nodes.Count);
            Console.WriteLine(nodePublic.InnerText);
            Console.WriteLine(nodePrivate.InnerText);
            //Console.WriteLine(nodes.Item(7).InnerText);*/
            return doc;
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

        public XmlDocument ImportXML(String path) {
            Console.WriteLine(path);

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            Console.WriteLine(doc.ToString());
            return doc;
        }

        public String GetTDESKey(XmlDocument doc) 
        {
            return doc.InnerText;
        }

        public String[] GetRSAValues(XmlDocument doc) 
        {
            Console.WriteLine(doc.DocumentElement.OuterXml);
            String path = "RSA/clave";
            XmlNode nodes = doc.SelectSingleNode(path);
            Console.WriteLine(nodes.OuterXml);
            XmlNode nodePublic = doc.SelectSingleNode("clave/RSAKeyValue/Modulus");
            //Console.WriteLine(nodePublic.Value);
            XmlNode nodePrivate = doc.SelectSingleNode("clave/RSAKeyValue/D");
            //Console.Write(nodePrivate.Value);
            String[] data = {"","",""};
            return data;
        }

        public void ExportEncriptedText(String text, String path) 
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(path);
                //Write a line of text
                sw.WriteLine(text);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        
    }
}
