using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class SetRule : Rule
    {
        public SetRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.SET_RULE), value)
        {
        }
        public SetRule()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.SET_RULE);
        }
    }
}
