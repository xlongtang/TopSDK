using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class TipRule : Rule
    {
        public string Url { get; set; }

        public TipRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.TIP_RULE), value)
        {
        }
        public TipRule()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.TIP_RULE);
        }
    }
}
