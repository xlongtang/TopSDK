using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class MaxTargetSizeRule : Rule, IntervalRuleInterface
    {
        protected String unit;

        public string Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }

        public MaxTargetSizeRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_TARGET_SIZE_RULE), value, "include")
        {
        }
        public MaxTargetSizeRule()
            : base()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_TARGET_SIZE_RULE);
            base.exProperty = "include";
            this.unit = "kb";
        }
        public MaxTargetSizeRule(string value, bool isInclude, string unit)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_TARGET_SIZE_RULE), value)
        {
            if (isInclude)
            {
                base.exProperty = "include";
            }
            else
            {
                base.exProperty = "not include";
            }
            this.unit = unit;
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
