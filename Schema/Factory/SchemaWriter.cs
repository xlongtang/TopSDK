using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Top.Schema.Fields;
using Top.Schema.Util;

namespace Top.Schema.Factory
{
    public class SchemaWriter
    {
        public static String WriteRuleXmlString(List<Field> fields)
        {
            XmlElement root = XmlUtils.CreateRootElement("itemRule");
            foreach (Field field in fields)
            {
                XmlElement fieldNode = field.ToElement();
                XmlUtils.AppendElement(root, fieldNode);
            }
            return XmlUtils.FormatXml(XmlUtils.EscapeXml(root.OwnerDocument.InnerXml));
        }

        public static String WriteParamXmlString(List<Field> fields)
        {
            XmlElement root = XmlUtils.CreateRootElement("itemParam");
            foreach (Field field in fields)
            {
                XmlElement fieldNode = field.ToParamElement();
                XmlUtils.AppendElement(root, fieldNode);
            }
            
            return XmlUtils.FormatXml(XmlUtils.EscapeXml(root.OwnerDocument.InnerXml));
        }
    }
}
