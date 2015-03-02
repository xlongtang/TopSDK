using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class DisableRule : Rule
    {
        public DisableRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.DISABLE_RULE), value)
        {
        }
        public DisableRule()
            : base()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.DISABLE_RULE);
            base.value = "false";
        }
    }
}
