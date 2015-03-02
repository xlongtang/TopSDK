using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class MinImageSizeRule : Rule, IntervalRuleInterface
    {
        public MinImageSizeRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_IMAGE_SIZE_RULE), value, "include")
        {
        }
        public MinImageSizeRule()
            : base()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_IMAGE_SIZE_RULE);
            base.exProperty = "include";
        }
        public MinImageSizeRule(String value, bool isInclude)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_IMAGE_SIZE_RULE), value)
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
