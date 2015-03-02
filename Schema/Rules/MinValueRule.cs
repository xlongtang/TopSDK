using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class MinValueRule : Rule, IntervalRuleInterface
    {
        public MinValueRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_VALUE_RULE), value, "include")
        {
        }
        public MinValueRule()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_VALUE_RULE);
            base.exProperty = "include";
        }
        public MinValueRule(String value, bool isInclude)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_VALUE_RULE), value)
        {
            if (isInclude)
            {
                base.exProperty = "include";
            }
            else
            {
                base.exProperty = "not include";
            }
        }

        public void SetValueIntervalInclude()
        {
            base.exProperty = "include";
        }

        public void SetValueIntervalNotInclude()
        {
            base.exProperty = "not include";
        }
    }
}
