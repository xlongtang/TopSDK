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
    public class MultiComplexField : Field
    {
        public MultiComplexField()
        {
            base.type = FieldTypeEnum.MULTICOMPLEX;
        }

        protected List<ComplexValue> values = new List<ComplexValue>();
        protected List<Field> fields = new List<Field>();

        public Field AddField(FieldTypeEnum fieldEnum)
        {
            Field field = SchemaFactory.CreateField(fieldEnum);
            this.Add(field);
            return field;
        }
        public void Add(Field field)
        {
            this.fields.Add(field);
        }

        public void SetComplexValues(List<ComplexValue> values)
        {
            this.values = values;
        }

        public ComplexValue AddComplexValue()
        {
            ComplexValue complexValue = new ComplexValue();
            this.values.Add(complexValue);
            return complexValue;
        }

        public ComplexValue AddDefaultComplexValue()
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            ComplexValue complexValue = new ComplexValue();
            this.GetDefaultComplexValues().Add(complexValue);
            return complexValue;
        }

        public List<ComplexValue> GetComplexValues()
        {
            return values;
        }

        public List<ComplexValue> GetDefaultComplexValues()
        {
            if (base.defaultValueField == null)
            {
                return null;
            }
            MultiComplexField multiComplexField = (MultiComplexField)base.defaultValueField;
            return multiComplexField.GetComplexValues();
        }

        public void AddComplexValue(ComplexValue value)
        {
            this.values.Add(value);
        }

        public void addDefaultComplexValue(ComplexValue value)
        {
            if (base.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            this.GetDefaultComplexValues().Add(value);
        }

        public List<Field> GetFieldList()
        {
            return this.fields;
        }

        public IDictionary<String, Field> getFieldMap()
        {
            IDictionary<String, Field> map = new Dictionary<string, Field>();
            foreach (Field field in fields)
            {
                map[field.Id] = field;
            }
            return map;
        }

        public override XmlElement ToElement()
        {
            XmlElement fieldNode = base.ToElement();
		    XmlElement fieldsNode = XmlUtils.AppendElement(fieldNode, "fields");
            if (this.fields != null && this.fields.Count > 0)
            {
                foreach (Field field in fields)
                {
                    XmlElement fNode = field.ToElement();
                    XmlUtils.AppendElement(fieldsNode, fNode);
                }
            }
            return fieldNode;
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
            foreach (ComplexValue complexValue in values)
            {
                XmlElement complexValuesNode = XmlUtils.AppendElement(fieldNode, "complex-values");
                ComplexValue cValue = complexValue;
                foreach (string keyFieldId in cValue.GetFieldKeySet())
                {
                    Field field = cValue.GetValueField(keyFieldId);
                    XmlElement valueNode = field.ToParamElement();
                    XmlUtils.AppendElement(complexValuesNode, valueNode);
                }
            }
            return fieldNode;
        }

        public override XmlElement ToDefaultValueElement()
        {
            if (this.defaultValueField == null)
            {
                return null;
            }
            XmlElement fieldNode = XmlUtils.CreateRootElement("default-values");
            MultiComplexField multiComplexField = (MultiComplexField) this.defaultValueField;
            foreach (ComplexValue complexValue in multiComplexField.GetComplexValues())
            {
                XmlElement complexValuesNode = XmlUtils.AppendElement(fieldNode, "default-complex-values");
                ComplexValue cValue = complexValue;
                foreach (string keyFieldId in cValue.GetFieldKeySet())
                {
                    Field field = cValue.GetValueField(keyFieldId);
                    XmlElement valueNode = field.ToParamElement();
                    XmlUtils.AppendElement(complexValuesNode, valueNode);
                }
            }
            return fieldNode;
        }

        public override void InitDefaultField()
        {
            base.defaultValueField = SchemaFactory.CreateField(FieldTypeEnum.MULTICOMPLEX);
        }
    }
}
