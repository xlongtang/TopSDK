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
    public class ComplexField : Field
    {
        public ComplexField()
        {
            base.type = FieldTypeEnum.COMPLEX;
        }

        protected ComplexValue complexValue = new ComplexValue();
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

        public ComplexValue GetComplexValue()
        {
            return this.complexValue;
        }

        public ComplexValue GetDefaultComplexValue()
        {
            if (this.defaultValueField == null)
            {
                this.InitDefaultField();
            }		
            ComplexField complexField = (ComplexField)this.defaultValueField;
            if (complexField == null)
            {
                return null;
            }
            return complexField.GetComplexValue();
        }

        public void SetComplexValue(ComplexValue complexValue)
        {
            this.complexValue = complexValue;
        }

        public void SetDefaultValue(ComplexValue complexValue)
        {
            if (this.defaultValueField == null)
            {
                this.InitDefaultField();
            }
            ComplexField complexField = (ComplexField)this.defaultValueField;
            complexField.SetComplexValue(complexValue);
        }

        public List<Field> GetFieldList()
        {
            return this.fields;
        }

        public IDictionary<String, Field> GetFieldMap()
        {
            IDictionary<String, Field> map = new Dictionary<String, Field>();
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
		    //sub-value
		    XmlElement complexValuesNode = XmlUtils.AppendElement(fieldNode, "complex-values");
		    ComplexValue cValue = this.complexValue;
		    foreach (string keyFieldId in cValue.GetFieldKeySet())
            {
                Field field = cValue.GetValueField(keyFieldId);
                XmlElement valueNode = field.ToParamElement();
                XmlUtils.AppendElement(complexValuesNode, valueNode);
            }
            return fieldNode;
        }

        public override XmlElement ToDefaultValueElement()
        {
            if (this.defaultValueField == null)
            {
                return null;
            }
            ComplexField complexField = (ComplexField) this.defaultValueField;
		    XmlElement defaultComplexValuesNode = XmlUtils.CreateRootElement("default-complex-values");
		    ComplexValue cValue = complexField.GetComplexValue();
            foreach (String keyFieldId in cValue.GetFieldKeySet())
            {
                Field field = cValue.GetValueField(keyFieldId);
                XmlElement valueNode = field.ToParamElement();
                XmlUtils.AppendElement(defaultComplexValuesNode, valueNode);
            }
            return defaultComplexValuesNode;
        }

        public override void InitDefaultField()
        {
            base.defaultValueField = SchemaFactory.CreateField(FieldTypeEnum.COMPLEX);
        }
    }
}
