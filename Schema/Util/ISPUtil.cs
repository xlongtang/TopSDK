using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;
using Top.Schema.Exceptions;
using Top.Schema.Fields;
using Top.Schema.Values;

namespace Top.Schema.Util
{
    public class ISPUtil
    {
        public static Value GetFieldValue(Field field)
        {
            Value value = new Value();
            switch (field.Type)
            {
                case FieldTypeEnum.INPUT:
                    InputField inputField = (InputField) field;
                    value.PropertyValue = inputField.Value;
                    break;
                case FieldTypeEnum.MULTIINPUT:
                    value = null;
                    break;
                case FieldTypeEnum.SINGLECHECK:
                    SingleCheckField singleCheckField = (SingleCheckField) field;
                    value = singleCheckField.GetValue();
                    break;
                case FieldTypeEnum.MULTICHECK:
                    value = null;
                    break;
                case FieldTypeEnum.COMPLEX:
                    value = null;
                    break;
                case FieldTypeEnum.MULTICOMPLEX:
                    value = null;
                    break;
                case FieldTypeEnum.LABEL:
                    value = null;
                    break;
                default:
                    value = null;
                    break;
            }
            return value;
        }

        public static string GetFieldStringValue(Field field)
        {
            Value value = GetFieldValue(field);
            if (value == null)
            {
                return null;
            }
            else
            {
                return value.PropertyValue;
            }
        }

        public static List<Value> GetFieldValues(Field field)
        {
            List<Value> values = new List<Value>();
            switch (field.Type)
            {
                case FieldTypeEnum.INPUT:
                    values = null;
                    break;
                case FieldTypeEnum.MULTIINPUT:
                    MultiInputField multiInputField = (MultiInputField) field;
                    values = multiInputField.GetValues();
                    break;
                case FieldTypeEnum.SINGLECHECK:
                    values = null;
                    break;
                case FieldTypeEnum.MULTICHECK:
                    MultiCheckField multiCheckField = (MultiCheckField) field;
                    values = multiCheckField.GetValues();
                    break;
                case FieldTypeEnum.COMPLEX:
                    values = null;
                    break;
                case FieldTypeEnum.MULTICOMPLEX:
                    values = null;
                    break;
                case FieldTypeEnum.LABEL:
                    values = null;
                    break;
                default:
                    values = null;
                    break;
            }
            return values;
        }

        public static List<String> GetFieldStringValues(Field field)
        {
            List<Value> vList = GetFieldValues(field);
            List<String> list = new List<String>();
            foreach (Value v in vList)
            {
                list.Add(v.PropertyValue);
            }
            return list;
        }

        public static DateTime ParseDate(String fieldValue)
        {
            try
            {
                return Convert.ToDateTime(fieldValue);
            }
            catch (Exception e)
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_20032, null);
            }
        }

        public static DateTime ParseTime(String fieldValue)
        {
            try
            {
                return Convert.ToDateTime(fieldValue);
            }
            catch (Exception e)
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_20033, null);
            }
        }
    }
}
