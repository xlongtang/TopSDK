using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class MinInputNumRule : Rule, IntervalRuleInterface
    {
        public MinInputNumRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_INPUT_NUM_RULE), value, "include")
        {
        }
        public MinInputNumRule()
            : base()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_INPUT_NUM_RULE);
            base.exProperty = "include";
        }
        public MinInputNumRule(String value, bool isInclude)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_INPUT_NUM_RULE), value)
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
