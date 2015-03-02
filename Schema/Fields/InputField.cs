using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Top.Schema.Enums;
using Top.Schema.Exceptions;
using Top.Schema.Factory;
using Top.Schema.Util;

namespace Top.Schema.Fields
{
    public class InputField : Field
    {
        protected string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public InputField()
        {
             base.type = FieldTypeEnum.INPUT;
        }

        public String GetDefaultValue()
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            InputField defaultField = (InputField)base.defaultValueField;
            return defaultField.Value;
        }

        public void SetDefaultValue(string value)
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            InputField defaultField = (InputField)base.defaultValueField;
            defaultField.Value = value;
        }

        public override XmlElement ToParamElement()
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
            XmlElement valueNode = XmlUtils.AppendElement(fieldNode, "value");
            valueNode.InnerText = value;
            return fieldNode;
        }

        public override XmlElement ToDefaultValueElement()
        {
            InputField defaultField = (InputField)base.defaultValueField;
            XmlElement valueNode = XmlUtils.CreateRootElement("default-value");
            string dvalue = defaultField.value;
            if (StringUtil.IsEmpty(dvalue))
            {
                return null;
            }
            else
            {
                valueNode.InnerText = dvalue;
            }
            return valueNode;
        }

        public override void InitDefaultField()
        {
            base.defaultValueField = SchemaFactory.CreateField(FieldTypeEnum.INPUT);
        }
    }
}
