using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class MaxDecimalDigitsRule : Rule, IntervalRuleInterface
    {
        public MaxDecimalDigitsRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_DECIMAL_DIGITS_RULE), value, "include")
        {
        }
        public MaxDecimalDigitsRule()
            : base()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_DECIMAL_DIGITS_RULE);
            base.exProperty = "include";
        }
        public MaxDecimalDigitsRule(String value, bool isInclude)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_DECIMAL_DIGITS_RULE), value)
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
