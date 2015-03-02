using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class ReadOnlyRule : Rule
    {
        public ReadOnlyRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.READ_ONLY_RULE), value)
        {
        }
        public ReadOnlyRule()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.READ_ONLY_RULE);
        }
    }
}
