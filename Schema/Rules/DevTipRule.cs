using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class DevTipRule : Rule
    {
        public string Url { get; set; }

        public DevTipRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.DEV_TIP_RULE), value)
        {
        }
        public DevTipRule()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.DEV_TIP_RULE);
        }
    }
}
