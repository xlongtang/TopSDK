using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class ValueTypeRule : Rule
    {
        public ValueTypeRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.VALUE_TYPE_RULE), value)
        {
        }
        public ValueTypeRule()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.VALUE_TYPE_RULE);
        }
    }
}
