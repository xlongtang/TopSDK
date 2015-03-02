using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Top.Schema.Enums;
using Top.Schema.Exceptions;
using Top.Schema.Factory;
using Top.Schema.Util;
using Top.Schema.Values;

namespace Top.Schema.Fields
{
    public class SingleCheckField : OptionsField
    {
        protected Value value = new Value();

        public SingleCheckField()
        {
            base.type = FieldTypeEnum.SINGLECHECK;
        }

        public Value GetValue()
        {
            return this.value;
        }

        public void SetValue(string value)
        {
            if (value == null)
            {
                return;
            }
            this.value.PropertyValue = value;
        }

        public void SetValue(Value value)
        {
            if (value == null)
            {
                return;
            }
            this.value = value;
        }

        public String GetDefaultValue()
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            SingleCheckField defaultField = (SingleCheckField)base.defaultValueField;
            if (defaultField.value == null)
            {
                return null;
            }
            else
            {
                return defaultField.GetValue().PropertyValue;
            }
        }

        public void SetDefaultValue(string value)
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            SingleCheckField defaultField = (SingleCheckField)base.defaultValueField;
            defaultField.SetValue(value);
        }

        public Value GetDefaultValueDO()
        {
            if (base.defaultValueField == null)
            {
                //this.InitDefaultField();
                return null;
            }
            SingleCheckField defaultField = (SingleCheckField)base.defaultValueField;
            if (defaultField.value == null)
            {
                return null;
            }
            else
            {
                return defaultField.GetValue();
            }
        }

        public void SetDefaultValueDO(Value value)
        {
            if (value == null)
            {
                return;
            }

            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            SingleCheckField defaultField = (SingleCheckField)base.defaultValueField;
            defaultField.SetValue(value);
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
            valueNode.InnerText = value.PropertyValue;
            return fieldNode;
        }

        public override XmlElement ToDefaultValueElement()
        {
            SingleCheckField defaultField = (SingleCheckField)base.defaultValueField;
            XmlElement valueNode = XmlUtils.CreateRootElement("default-value");
            Value dvalue = defaultField.GetValue();
            if (dvalue == null || StringUtil.IsEmpty(dvalue.PropertyValue))
            {
                return null;
            }
            else
            {
                valueNode.InnerText = dvalue.PropertyValue;
            }
            return valueNode;
        }

        public override void InitDefaultField()
        {
            base.defaultValueField = SchemaFactory.CreateField(FieldTypeEnum.SINGLECHECK);
        }
    }
}
