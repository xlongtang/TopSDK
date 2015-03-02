using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;
using Top.Schema.Fields;
using Top.Schema.Util;

namespace Top.Schema.Values
{
    public class ComplexValue
    {
        protected IDictionary<string, Field> fieldMap = new Dictionary<string, Field>();

        public ICollection<string> GetFieldKeySet()
        {
            return this.fieldMap.Keys;
        }

        public Field GetValueField(string fieldId)
        {
            return this.fieldMap[fieldId];
        }

        public void Put(Field field)
        {
            if (field == null || field.Id == null)
            {
                return;
            }
            this.fieldMap[field.Id] = field;
        }

        public Value GetValue(string fieldId)
        {
            Field field = this.fieldMap[fieldId];
            if (field == null)
            {
                return null;
            }
            return ISPUtil.GetFieldValue(field);
        }

        public String GetStringValue(string fieldId)
        {
            Field field = this.fieldMap[fieldId];
            if (field == null)
            {
                return null;
            }
            return ISPUtil.GetFieldStringValue(field);
        }

        public void SetInputFieldValue(string fieldId, string value)
        {
            InputField field = new InputField();
            field.Id = fieldId;
            field.Value = value;
            this.fieldMap[fieldId] = field;
        }

        public String GetInputFieldValue(string fieldId)
        {
            Field field = this.fieldMap[fieldId];
            if (field == null || !field.Type.Equals(FieldTypeEnum.INPUT))
            {
                return null;
            }
            return ISPUtil.GetFieldStringValue(field);
        }

        public void SetSingleCheckFieldValue(string fieldId, Value value)
        {
            SingleCheckField field = new SingleCheckField();
            field.Id = fieldId;
            field.SetValue(value);
            this.fieldMap[fieldId] = field;
        }

        public Value GetSingleCheckFieldValue(string fieldId)
        {
            Field field = this.fieldMap[fieldId];
            if (field == null || !field.Type.Equals(FieldTypeEnum.SINGLECHECK))
            {
                return null;
            }
            return ISPUtil.GetFieldValue(field);
        }

        public void SetMultiInputFieldValues(string fieldId, List<string> values)
        {
            MultiInputField field = new MultiInputField();
            field.Id = fieldId;
            field.SetValues(values);
            this.fieldMap[fieldId] = field;
        }

        public List<String> GetMultiInputFieldValues(string fieldId)
        {
            Field field = this.fieldMap[fieldId];
            if (field == null || !field.Type.Equals(FieldTypeEnum.MULTIINPUT))
            {
                return null;
            }
            return ISPUtil.GetFieldStringValues(field);
        }

        public void SetMultiCheckFieldValues(string fieldId, List<Value> values)
        {
            MultiCheckField field = new MultiCheckField();
            field.Id = fieldId;
            field.SetValues(values);
            this.fieldMap[fieldId] = field;
        }

        public List<Value> GetMultiCheckValues(string fieldId)
        {
            Field field = this.fieldMap[fieldId];
            if (field == null || !field.Type.Equals(FieldTypeEnum.MULTICHECK))
            {
                return null;
            }
            return ISPUtil.GetFieldValues(field);
        }

        public void SetComplexFieldValue(string fieldId, ComplexValue complexValue)
        {
            ComplexField field = new ComplexField();
            field.Id = fieldId;
            field.SetComplexValue(complexValue);
            this.fieldMap[fieldId] = field;
        }

        public ComplexValue GetComplexFieldValue(string fieldId)
        {
            Field field = this.fieldMap[fieldId];
            if (field == null || !field.Type.Equals(FieldTypeEnum.COMPLEX))
            {
                return null;
            }
            ComplexField cfield = (ComplexField)field;
            return cfield.GetComplexValue();
        }

        public void SetMultiComplexFieldValues(string fieldId, List<ComplexValue> complexValueList)
        {
            MultiComplexField field = new MultiComplexField();
            field.Id = fieldId;
            field.SetComplexValues(complexValueList);
            this.fieldMap[fieldId] = field;
        }

        public List<ComplexValue> GetComplexFieldValues(string fieldId)
        {
            Field field = this.fieldMap[fieldId];
            if (field == null || !field.Type.Equals(FieldTypeEnum.MULTICOMPLEX))
            {
                return null;
            }
            MultiComplexField cfield = (MultiComplexField)field;
            return cfield.GetComplexValues();
        }
    }
}
