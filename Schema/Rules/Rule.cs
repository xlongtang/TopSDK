using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Top.Schema.Depend;
using Top.Schema.Enums;
using Top.Schema.Exceptions;
using Top.Schema.Fields;
using Top.Schema.Options;
using Top.Schema.Util;
using Top.Schema.Values;

namespace Top.Schema.Rules
{
    public class Rule
    {
        protected string name;

        public string Name
        {
            get { return this.name; }
        }

	    protected string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

	    protected string exProperty;

        public string ExProperty
        {
            get { return this.exProperty; }
            set { this.exProperty = value; }
        }
	    protected DependGroup dependGroup;

        public DependGroup DependGroup
        {
            get { return this.dependGroup; }
            set { this.dependGroup = value; }
        }

        protected bool IsTypeInNamespace(FieldTypeEnum[] namespaces, FieldTypeEnum type)
        {
            foreach (FieldTypeEnum typeEnum in namespaces)
            {
                if (typeEnum.Equals(type))
                {
                    return true;
                }
            }
            return false;
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


        protected List<String> GetOptionValues(Field field)
        {
            List<String> values = new List<String>();
            switch (field.Type)
            {
                case FieldTypeEnum.SINGLECHECK:
                    SingleCheckField singleCheckField = (SingleCheckField) field;
                    List<Option> options = singleCheckField.GetOptions();
                    foreach (Option option in options)
                    {
                        values.Add(option.Value);
                    }
                    break;
                case FieldTypeEnum.MULTICHECK:
                    MultiCheckField multiCheckField = (MultiCheckField) field;
                    List<Option> options2 = multiCheckField.GetOptions();
                    foreach (Option option in options2)
                    {
                        values.Add(option.Value);
                    }
                    break;
            }
            return values;
        }

        public Rule(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public Rule(string name, string value, string exProperty)
        {
            this.name = name;
            this.value = value;
            this.exProperty = exProperty;
        }

        public XmlElement ToElement(String fieldId)
        {
            XmlElement rule = XmlUtils.CreateRootElement("rule");
            if (StringUtil.IsEmpty(this.name))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_31001, fieldId);
            }
            if (StringUtil.IsEmpty(this.value))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_31002, fieldId);
            }
            rule.SetAttribute("name", this.name);
            rule.SetAttribute("value", this.value);
            if (!StringUtil.IsEmpty(exProperty))
            {
                rule.SetAttribute("exProperty", this.exProperty);
            }
            //for Special
            if (this.name.Equals(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_TARGET_SIZE_RULE)))
            {
                MaxTargetSizeRule mtsRule = (MaxTargetSizeRule)this;
                if (!StringUtil.IsEmpty(mtsRule.Unit))
                {
                    rule.SetAttribute("unit", mtsRule.Unit);
                }
            }
            if (this.name.Equals(RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_TARGET_SIZE_RULE)))
            {
                MinTargetSizeRule misRule = (MinTargetSizeRule)this;
                if (!StringUtil.IsEmpty(misRule.Unit))
                {
                    rule.SetAttribute("unit", misRule.Unit);
                }
            }
            if (this.name.Equals(RuleTypeEnumHelper.ToType(RuleTypeEnum.TIP_RULE)))
            {
                TipRule tipRule = (TipRule)this;
                if (!StringUtil.IsEmpty(tipRule.Url))
                {
                    rule.SetAttribute("url", tipRule.Url);
                }
            }
            if (this.name.Equals(RuleTypeEnumHelper.ToType(RuleTypeEnum.DEV_TIP_RULE)))
            {
                DevTipRule devTipRule = (DevTipRule)this;
                if (!StringUtil.IsEmpty(devTipRule.Url))
                {
                    rule.SetAttribute("url", devTipRule.Url);
                }
            }
            //depend element
            if (dependGroup != null && !dependGroup.IsEmpty())
            {
                XmlElement depend = dependGroup.ToElement();
                XmlUtils.AppendElement(rule, depend);
            }
            return rule;
        }

        public Rule()
        {
        }
    }
}
