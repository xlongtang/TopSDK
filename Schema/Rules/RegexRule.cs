using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class RegexRule : Rule
    {
        public RegexRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.REGEX_RULE), value)
        {
        }
        public RegexRule()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.REGEX_RULE);
        }
    }
}
