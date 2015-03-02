using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class RequiredRule : Rule
    {
        public RequiredRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.REQUIRED_RULE), value)
        {
        }
        public RequiredRule()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.REQUIRED_RULE);
        }
    }
}
