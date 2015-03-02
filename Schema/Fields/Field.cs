using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Top.Schema.Enums;
using Top.Schema.Exceptions;
using Top.Schema.Factory;
using Top.Schema.Rules;
using Top.Schema.Property;
using Top.Schema.Util;

namespace Top.Schema.Fields
{
    public abstract class Field
    {
        protected string id;

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        protected string name;

        public string Name

        {
            get { return this.name; }
            set { this.name = value; }
        }

        protected FieldTypeEnum type;

        public FieldTypeEnum Type
        {
            get { return this.type; }
        }

        protected List<Rule> rules = new List<Rule>();
        protected List<Property.Property> properties = new List<Property.Property>();
        protected Field defaultValueField;

        public virtual XmlElement ToElement()
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
            if (this.rules != null && this.rules.Count > 0)
            {
                XmlElement rulesNode = XmlUtils.AppendElement(fieldNode, "rules");
                foreach (Rule rule in this.rules)
                {
                    XmlElement ruleNode = rule.ToElement(this.id);
                    XmlUtils.AppendElement(rulesNode, ruleNode);
                }
            }
            if (defaultValueField != null)
            {
                XmlElement defaultValueEle = this.ToDefaultValueElement();
                if (defaultValueEle != null)
                {
                    XmlUtils.AppendElement(fieldNode, defaultValueEle);
                }
            }
            if (this.properties != null && this.properties.Count > 0)
            {
                XmlElement propertiesNode = XmlUtils.AppendElement(fieldNode, "properties");
                foreach (Property.Property propertie in this.properties)
                {
                    XmlElement propertyNode = XmlUtils.AppendElement(propertiesNode, "property");
                    propertyNode.SetAttribute("key", propertie.Key);
                    propertyNode.SetAttribute("value", propertie.Value);
                }
            }
            return fieldNode;
        }

        public Rule AddValueTypeRule(ValueTypeEnum typeEnum)
        {
            ValueTypeRule rule = new ValueTypeRule(ValueTypeEnumHelper.ToValue(typeEnum));
            this.Add(rule);
            return rule;
        }

        public Rule AddValueTypeRule(string valueType)
        {
            if (string.IsNullOrEmpty(valueType))
            {
                return null;
            }
            ValueTypeRule rule = new ValueTypeRule(valueType);
            this.Add(rule);
            return rule;
        }

        public void SetFieldRequired()
        {
            this.AddRule(RuleTypeEnum.REQUIRED_RULE, "true");
        }


        public abstract XmlElement ToParamElement();
        public abstract XmlElement ToDefaultValueElement();
        public abstract void InitDefaultField();

        public void Add(Rule rule)
        {
            this.rules.Add(rule);
        }

        public void Add(Property.Property property)
        {
            this.properties.Add(property);
        }

        public Rule AddRule(RuleTypeEnum ruleType)
        {
            Rule rule = SchemaFactory.CreateRule(ruleType);
            this.Add(rule);
            return rule;
        }

        public Rule AddRule(RuleTypeEnum ruleType, string value)
        {
            Rule rule = SchemaFactory.CreateRule(ruleType);
            rule.Value = value;
            this.Add(rule);
            return rule;
        }

        public Rule AddRule(RuleTypeEnum ruleType, string value, string exProperty)
        {
            Rule rule = SchemaFactory.CreateRule(ruleType);
            rule.Value = value;
            rule.ExProperty = exProperty;
            this.Add(rule);
            return rule;
        }

        public void AddRules(List<Rule> ruleList)
        {
            if (ruleList != null && ruleList.Count > 0)
            {
                foreach (Rule rule in ruleList)
                {
                    this.rules.Add(rule);
                }
            }
        }

        public Rule AddCustomRule(string ruleType, string ruleValue)
        {
            Rule rule = SchemaFactory.CreateCustomRule(ruleType, ruleValue);
            this.Add(rule);
            return rule;
        }

        public Rule AddCustomRule(string ruleType, string ruleValue, string exProperty)
        {
            Rule rule = SchemaFactory.CreateCustomRule(ruleType, ruleValue, exProperty);
            this.Add(rule);
            return rule;
        }

        public Property.Property AddProperty(string key, string value)
        {
            Property.Property property = new Property.Property(key, value);
            this.Add(property);
            return property;
        }

        public Rule AddIntervalRule(RuleTypeEnum ruleType, string ruleValue, bool isInclude)
        {
            Rule rule = SchemaFactory.CreateRule(ruleType);
            rule.Value = ruleValue;
            if (isInclude)
            {
                rule.ExProperty = "include";
            }
            else
            {
                rule.ExProperty = "not include";
            }
            this.Add(rule);
            return rule;
        }

        public List<Rule> GetRules()
        {
            return rules;
        }

        public Rule GetRuleByName(string ruleName)
        {
            foreach (Rule rule in rules)
            {
                if (rule.Name.Equals(ruleName))
                {
                    return rule;
                }
            }
            return null;
        }

        public void SetRules(List<Rule> rules)
        {
            this.rules = rules;
        }

        public List<Property.Property> getProperties()
        {
            return properties;
        }

        public void SetProperties(List<Property.Property> properties)
        {
            this.properties = properties;
        }
    }
}
