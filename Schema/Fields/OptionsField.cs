using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Top.Schema.Enums;
using Top.Schema.Exceptions;
using Top.Schema.Options;
using Top.Schema.Util;
using Top.Schema.Rules;

namespace Top.Schema.Fields
{
    public abstract class OptionsField : Field
    {
        protected List<Option> options = new List<Option>();

        public void Add(Option option)
        {
            this.options.Add(option);
        }

        public Option AddOption()
        {
            Option option = new Option();
            this.Add(option);
            return option;
        }

        public Option AddOption(String displayName, String value)
        {
            Option option = new Option();
            option.SetDisplayName(displayName);
            option.Value = value;
            this.Add(option);
            return option;
        }

        public List<Option> GetOptions()
        {
            return options;
        }

        public void SetOptions(List<Option> options)
        {
            this.options = options;
        }

        public override XmlElement ToElement()
        {
            XmlElement fieldNode = XmlUtils.CreateRootElement("field");
            if (StringUtil.IsEmpty(this.id))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_30001, null);
            }
            if (StringUtil.IsEmpty(FieldTypeEnumHelper.ToType(this.type)))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_30002, this.id);
            }
            fieldNode.SetAttribute("id", this.id);
            fieldNode.SetAttribute("name", this.name);
            fieldNode.SetAttribute("type", FieldTypeEnumHelper.ToType(this.type));
            if (this.rules != null && this.rules.Count > 0)
            {
                XmlElement rulesNode = XmlUtils.AppendElement(fieldNode, "rules");
                foreach (Rule rule in this.rules)
                {
                    XmlElement ruleNode = rule.ToElement(this.id);
                    XmlUtils.AppendElement(rulesNode, ruleNode);
                }
            }
            if (this.options != null && this.options.Count > 0)
            {
                XmlElement optionsNode = XmlUtils.AppendElement(fieldNode, "options");
                foreach (Option option in this.options)
                {
                    XmlElement optionNode = option.ToElement();
                    XmlUtils.AppendElement(optionsNode, optionNode);
                }
            }
            if (defaultValueField != null)
            {
                XmlElement defaultValueEle = this.ToDefaultValueElement();
                if (defaultValueEle != null)
                {
                    XmlUtils.AppendElement(fieldNode, defaultValueEle);
                }
            }
            if (this.properties != null && this.properties.Count > 0)
            {
                XmlElement propertiesNode = XmlUtils.AppendElement(fieldNode, "properties");
                foreach (Property.Property propertie in this.properties)
                {
                    XmlElement propertyNode = XmlUtils.AppendElement(propertiesNode, "property");
                    propertyNode.SetAttribute("key", propertie.Key);
                    propertyNode.SetAttribute("value", propertie.Value);
                }
            }
            return fieldNode;
        }
    }
}
