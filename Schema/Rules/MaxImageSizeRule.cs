using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class MaxImageSizeRule : Rule, IntervalRuleInterface
    {
        public MaxImageSizeRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_IMAGE_SIZE_RULE), value, "include")
        {
        }
        public MaxImageSizeRule()
            : base()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_IMAGE_SIZE_RULE);
            base.exProperty = "include";
        }
        public MaxImageSizeRule(String value, bool isInclude)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_IMAGE_SIZE_RULE), value)
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
