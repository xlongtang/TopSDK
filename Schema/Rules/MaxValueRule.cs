using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class MaxValueRule : Rule, IntervalRuleInterface
    {
        public MaxValueRule(String value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_VALUE_RULE), value, "include")
        {
        }
        public MaxValueRule()
            : base()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_VALUE_RULE);
            base.exProperty = "include";
        }
        public MaxValueRule(String value, bool isInclude)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_VALUE_RULE), value)
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
