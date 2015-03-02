using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class MinDecimalDigitsRule : Rule, IntervalRuleInterface
    {
        public MinDecimalDigitsRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_DECIMAL_DIGITS_RULE), value, "include")
        {
        }
        public MinDecimalDigitsRule()
            : base()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_DECIMAL_DIGITS_RULE);
            base.exProperty = "include";
        }
        public MinDecimalDigitsRule(string value, bool isInclude)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_DECIMAL_DIGITS_RULE), value)
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
