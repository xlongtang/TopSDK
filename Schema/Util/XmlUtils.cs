using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Top.Schema.Exceptions;

namespace Top.Schema.Util
{
    public class XmlUtils
    {
        public static XmlElement CreateRootElement(String tagName)
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", ""));
            XmlElement root = doc.CreateElement(tagName);
            doc.AppendChild(root);
            return root;
        }

        public static XmlElement AppendElement(XmlElement parent, string tagName)
        {
            XmlElement child = parent.OwnerDocument.CreateElement(tagName);
            parent.AppendChild(child);
            return child;
        }

        public static void AppendElement(XmlElement parent, XmlElement child)
        {
            XmlNode tmp = parent.OwnerDocument.ImportNode(child, true);
            parent.AppendChild(tmp);
        }

        public static XmlElement GetRootElementFromString(String payload)
        {
            if (string.IsNullOrEmpty(payload))
            {
                throw new TopSchemaException("XML_PAYLOAD_EMPTY");
            }
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(EscapeXml(payload));
            return xmlDocument.DocumentElement;
        }

        public static List<XmlElement> GetChildElements(XmlElement parent, String tagName)
        {
            XmlNodeList nodes = parent.GetElementsByTagName(tagName);
            List<XmlElement> elements = new List<XmlElement>();

            for (int i = 0; i < nodes.Count; i++)
            {
                XmlNode node = nodes[i];
                if (node is XmlElement && node.ParentNode == parent)
                {
                    elements.Add((XmlElement) node);
                }
            }

            return elements;
        }

        public static string GetAttributeValue(XmlElement current, string attrName)
        {
            if (current.HasAttribute(attrName))
            {
                return current.GetAttribute(attrName);
            }
            else
            {
                return null;
            }
        }

        public static XmlElement GetChildElement(XmlElement parent, String tagName)
        {
            List<XmlElement> children = GetChildElements(parent, tagName);

            if (children.Count == 0)
            {
                return null;
            }
            else
            {
                return children[0];
            }
        }

        public static string GetElementValue(XmlElement element)
        {
            if (element != null)
            {
                XmlNodeList nodes = element.ChildNodes;
                if (nodes.Count > 0)
                {
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        XmlNode node = nodes[i];
                        if (node is XmlText)
                        {
                            return ((XmlText) node).Data;
                        }
                    }
                }
            }

            return null;
        }

        //public static String NodeToString(XmlNode node)
        //{
        //    String payload = null;

        //    try
        //    {
        //        XmlTransform tf = TransformerFactory.newInstance().newTransformer();

        //        Properties props = tf.getOutputProperties();
        //        props.setProperty(OutputKeys.ENCODING, DEFAULT_ENCODE);
        //        props.setProperty(OutputKeys.INDENT, LOGIC_YES);
        //        tf.setOutputProperties(props);

        //        StringWriter writer = new StringWriter();
        //        tf.transform(new DOMSource(node), new StreamResult(writer));
        //        payload = escapeXml(writer.toString());
        //    }
        //    catch (TransformerException e)
        //    {
        //        throw new TopSchemaException("XML_TRANSFORM_ERROR", e);
        //    }

        //    return payload;
        //}

        public static string EscapeXml(string payload)
        {
            StringBuilder stringBuilder = new StringBuilder();
            char[] chars = payload.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if ((c == 0x9) || (c == 0xA) || (c == 0xD) || ((c >= 0x20) && (c <= 0xD7FF))
                    || ((c >= 0xE000) && (c <= 0xFFFD)) || ((c >= 0x10000) && (c <= 0x10FFFF)))
                    stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }

        public static string FormatXml(string sUnformattedXml)
        {
            XmlDocument xd = new XmlDocument();
            xd.LoadXml(sUnformattedXml);
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            XmlTextWriter xtw = null;
            try
            {
                xtw = new XmlTextWriter(sw);
                xtw.Formatting = Formatting.Indented;
                xtw.Indentation = 1;
                xtw.IndentChar = '\t';
                xd.WriteTo(xtw);
            }
            finally
            {
                if (xtw != null)
                    xtw.Close();
            }
            return sb.ToString();
        }
    }
}
