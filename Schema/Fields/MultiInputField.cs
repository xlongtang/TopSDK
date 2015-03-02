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
    public class MultiInputField : Field
    {
        protected List<Value> values = new List<Value>();

        public MultiInputField()
        {
            base.type = FieldTypeEnum.MULTIINPUT;
        }

        public void AddValue(Value value)
        {
            this.values.Add(value);
        }

        public void AddValue(string value)
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

        public void SetValues(List<String> values)
        {
            if (values == null)
            {
                return;
            }
            this.values.Clear();
            foreach (string value in values)
            {
                Value v = new Value();
                v.PropertyValue = value;
                this.values.Add(v);
            }
        }

        public List<String> GetStringValues()
        {
            List<String> list = new List<String>();
            foreach (Value v in this.values)
            {
                list.Add(v.PropertyValue);
            }
            return list;
        }

        public void AddDefaultValue(String value)
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            MultiInputField defaultField = (MultiInputField)base.defaultValueField;
            defaultField.AddValue(value);
        }

        public void SetDefaultValues(List<String> values)
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            MultiInputField defaultField = (MultiInputField) base.defaultValueField;
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
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            List<String> result = new List<String>();
            MultiInputField defaultField = (MultiInputField) base.defaultValueField;
            List<Value> vList = defaultField.GetValues();
            foreach (Value v in vList)
            {
                result.Add(v.PropertyValue);
            }
            return result;
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
            MultiInputField defaultField = (MultiInputField) base.defaultValueField;
            List<Value> defaultValues = defaultField.GetValues();
            if (defaultValues == null || defaultValues.Count == 0)
            {
                return null;
            }
            XmlElement valuesNode = XmlUtils.CreateRootElement("default-values");
            foreach (Value value in defaultValues)
            {
                XmlElement valueNode = XmlUtils.AppendElement(valuesNode, "default-value");
                valueNode.InnerText = value.PropertyValue;
            }
            return valuesNode;
        }

        public override void InitDefaultField()
        {
            base.defaultValueField = SchemaFactory.CreateField(FieldTypeEnum.MULTIINPUT);
        }
    }
}
