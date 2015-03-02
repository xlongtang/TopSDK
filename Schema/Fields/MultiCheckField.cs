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
    public class MultiCheckField : OptionsField
    {
        protected List<Value> values = new List<Value>();

        public MultiCheckField()
        {
            base.type = FieldTypeEnum.MULTICHECK;
        }

        public void AddValue(Value value)
        {
            if (value == null)
            {
                return;
            }
            this.values.Add(value);
        }

        public void AddValue(String value)
        {
            if (value == null)
            {
                return;
            }
            Value v = new Value();
            v.PropertyValue = value;
            this.AddValue(v);
        }

        public List<Value> GetValues()
        {
            return this.values;
        }

        public void SetValues(List<Value> values)
        {
            this.values = values;
        }

        public void AddDefaultValue(String value)
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            MultiCheckField defaultField = (MultiCheckField)base.defaultValueField;
            defaultField.AddValue(value);
        }

        public void SetDefaultValue(List<String> values)
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            MultiCheckField defaultField = (MultiCheckField) base.defaultValueField;
            if (defaultField.GetValues() != null && defaultField.GetValues().Count > 0)
            {
                defaultField.GetValues().Clear();
            }
            foreach (String v in values)
            {
                defaultField.AddValue(v);
            }
        }

        public List<String> GetDefaultValues()
        {
            List<String> result = new List<String>();
            MultiCheckField defaultField = (MultiCheckField) base.defaultValueField;
            List<Value> vList = defaultField.GetValues();
            foreach (Value v in vList)
            {
                result.Add(v.PropertyValue);
            }
            return result;
        }

        public List<Value> GetDefaultValuesDO()
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            List<Value> result = new List<Value>();
            MultiCheckField defaultField = (MultiCheckField)base.defaultValueField;
            List<Value> vList = defaultField.GetValues();
            foreach (Value v in vList)
            {
                result.Add(v);
            }
            return result;
        }

        public void SetDefaultValueDO(List<Value> values)
        {
            if (values == null)
            {
                return;
            }

            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            MultiCheckField defaultField = (MultiCheckField)base.defaultValueField;
            if (defaultField.GetValues() != null && defaultField.GetValues().Count > 0)
            {
                defaultField.GetValues().Clear();
            }
            foreach (Value v in values)
            {
                defaultField.AddValue(v);
            }
        }

        public void AddDefaultValueDO(Value value)
        {
            if (value == null)
            {
                return;
            }

            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            MultiCheckField defaultField = (MultiCheckField)base.defaultValueField;
            defaultField.AddValue(value);
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
		    XmlElement valuesNode = XmlUtils.AppendElement(fieldNode, "values");
		    foreach (Value value in values)
            {
                XmlElement valueNode = XmlUtils.AppendElement(valuesNode, "value");
                valueNode.InnerText = value.PropertyValue;
            }
            return fieldNode;
        }

        public override XmlElement ToDefaultValueElement()
        {
            MultiCheckField defaultField = (MultiCheckField) base.defaultValueField;
		    XmlElement valuesNode = XmlUtils.CreateRootElement("default-values");
		    List<Value> defaultValues = defaultField.GetValues();
            if (defaultValues == null || defaultValues.Count == 0)
            {
                return null;
            }
            foreach (Value value in defaultValues)
            {
                XmlElement valueNode = XmlUtils.AppendElement(valuesNode, "default-value");
                valueNode.InnerText = value.PropertyValue;
            }
            return valuesNode;
        }

        public override void InitDefaultField()
        {
            base.defaultValueField = SchemaFactory.CreateField(FieldTypeEnum.MULTICHECK);
        }
    }
}
