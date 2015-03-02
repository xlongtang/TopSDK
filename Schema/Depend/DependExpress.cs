using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;
using Top.Schema.Fields;
using Top.Schema.Values;

namespace Top.Schema.Depend
{
    public class DependExpress
    {
        public const string SYMBOL_IS_NULL = "is null";
        public const string SYMBOL_EQUALS = "==";
        public const string SYMBOL_NOT_EQUALS = "!=";
        public const string SYMBOL_GREATER = ">";
        public const string SYMBOL_LESS = "<";
        public const string SYMBOL_GREATER_AND_EQUALS = ">=";
        public const string SYMBOL_LESS_AND_EQUALS = "<=";
        public const string SYMBOL_CONTAINS = "contains";
        public const string SYMBOL_NOT_CONTAINS = "not contains";
        public const string SYMBOL_IN_FIELDOPTIONS = "this field's value in fieldOptions";
        public const string SYMBOL_NOT_IN_FIELDOPTIONS = "this field's value not in fieldOptions";

        protected string fieldId;

        public string FieldId
        {
            get { return this.fieldId; }
            set { this.fieldId = value; }
        }

        protected string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        protected string symbol = "==";

        public string Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        public bool ExcuteExpress(IDictionary<string, Field> fieldMap)
        {
            Field field = fieldMap[this.FieldId];
		    if(field == null)
            {
			    return false;
		    }
		    List<String> values = this.GetFieldValues(field);
		    if(values == null || values.Count == 0)
            {
			    if(SYMBOL_IS_NULL.Equals(this.symbol))
                {
				    return true;
			    }else
                {
				    return false;
			    }
		    }

		    if(SYMBOL_EQUALS.Equals(this.symbol))
            {
			    foreach(string fieldValue in values)
                {
				    if(!fieldValue.Equals(this.Value))
                    {
					    return false;
				    }
			    }
		    }
            else if(SYMBOL_NOT_EQUALS.Equals(this.symbol))
            {
			    foreach(string fieldValue in values)
                {
				    if(fieldValue.Equals(this.Value))
                    {
					    return false;
				    }
			    }
		    }
            else if(SYMBOL_GREATER.Equals(this.symbol))
            {
			    try
                {
				    double comValueDouble = Convert.ToDouble(this.Value);
				    foreach(string fieldValue in values)
                    {
					    double fieldValueDouble = Convert.ToDouble(fieldValue);
					    if(fieldValueDouble <= comValueDouble)
                        {
						    return false;
					    }
				    }
			    }
                catch(Exception e)
                {
				    return false;
			    }   
		    }
            else if(SYMBOL_LESS.Equals(this.symbol))
            {
			    try
                {
				    double comValueDouble = Convert.ToDouble(this.Value);
				    foreach(String fieldValue in values)
                    {
					    double fieldValueDouble = Convert.ToDouble(fieldValue);
					    if(fieldValueDouble >= comValueDouble)
                        {
						    return false;
					    }
				    }
			    }
                catch(Exception e)
                {
				    return false;
			    }
		    }
            else if(SYMBOL_GREATER_AND_EQUALS.Equals(this.symbol))
            {
			    try
                {
				    double comValueDouble = Convert.ToDouble(this.Value);
				    foreach(string fieldValue in values)
                    {
					    double fieldValueDouble = Convert.ToDouble(fieldValue);
					    if(fieldValueDouble < comValueDouble)
                        {
						    return false;
					    }
				    }
			    }
                catch(Exception e)
                {
				    return false;
			    }
		    }
            else if(SYMBOL_LESS_AND_EQUALS.Equals(this.symbol))
            {
			    try
                {
				    double comValueDouble = Convert.ToDouble(this.Value);
				    foreach(string fieldValue in values)
                    {
					    double fieldValueDouble = Convert.ToDouble(fieldValue);
					    if(fieldValueDouble > comValueDouble)
                        {
						    return false;
					    }
				    }
			    }
                catch(Exception e)
                {
				    return false;
			    }
		    }
            else if(SYMBOL_CONTAINS.Equals(this.symbol))
            {
			    bool contains = false;
			    foreach(string fieldValue in values)
                {
				    if(fieldValue.Equals(this.Value))
                    {
					    contains = true;
					    break;
				    }
			    }
			    return contains;
		    }
            else if(SYMBOL_NOT_CONTAINS.Equals(this.symbol))
            {
			    bool contains = true;
			    foreach(string fieldValue in values)
                {
				    if(fieldValue.Equals(this.Value))
                    {
					    contains = false;
					    break;
				    }
			    }
			    return contains;
		    }
		    return true;
        }

        protected List<String> GetFieldValues(Field field)
        {
            List<String> values = new List<String>();
            switch (field.Type)
            {
                case FieldTypeEnum.INPUT:
                    InputField inputField = (InputField) field;
                    values.Add(inputField.Value);
                    break;
                case FieldTypeEnum.SINGLECHECK:
                    SingleCheckField singleCheckField = (SingleCheckField) field;
                    values.Add(singleCheckField.GetValue().PropertyValue);
                    break;
                case FieldTypeEnum.MULTICHECK:
                    MultiCheckField multiCheckField = (MultiCheckField) field;
                    List<Value> vList = multiCheckField.GetValues();
                    foreach (Value v in vList)
                    {
                        values.Add(v.PropertyValue);
                    }
                    break;
                case FieldTypeEnum.MULTIINPUT:
                    MultiInputField multiInputField = (MultiInputField) field;
                    List<Value> viList = multiInputField.GetValues();
                    foreach (Value v in viList)
                    {
                        values.Add(v.PropertyValue);
                    }
                    break;
            }
            return values;
        }
    }
}
