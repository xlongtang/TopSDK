using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;
using Top.Schema.Fields;
using Top.Schema.Rules;

namespace Top.Schema.Factory
{
    public class SchemaFactory
    {
        public static List<Field> CreateEmptyFieldList()
        {
            return new List<Field>();
        }

        public static Field CreateField(FieldTypeEnum fieldEnum)
        {
            return FieldTypeEnumHelper.CreateField(fieldEnum);
        }

        public static Rule CreateRule(RuleTypeEnum ruleType)
        {
            return RuleTypeEnumHelper.CreateRule(ruleType);
        }

        public static Rule CreateCustomRule(string ruleName, string ruleValue)
        {
            return new DefaultRule(ruleName, ruleValue);
        }

        public static Rule CreateCustomRule(string ruleName, string ruleValue, string exProperty)
        {
            return new DefaultRule(ruleName, ruleValue, exProperty);
        }
    }
}
