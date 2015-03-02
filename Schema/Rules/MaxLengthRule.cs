using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Rules
{
    public class MaxLengthRule : Rule, IntervalRuleInterface
    {
        protected string unit;//while it is chinese word.the length is byte-2 character-1.

        public string Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }

        public static string UNIT_BYTE = "byte";
        public static string UNIT_CHARACTER = "character";

        public MaxLengthRule(string value)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_LENGTH_RULE), value, "include")
        {
            this.unit = UNIT_BYTE;
        }
        public MaxLengthRule()
            : base()
        {
            base.name = RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_LENGTH_RULE);
            base.exProperty = "include";
        }
        public MaxLengthRule(String value, bool isInclude, String unit)
            : base(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_LENGTH_RULE), value)
        {
            if (isInclude)
            {
                base.exProperty = "include";
            }
            else
            {
                base.exProperty = "not include";
            }
            this.unit = unit;
        }

        public void SetValueIntervalInclude()
        {
            base.exProperty = "include";
        }

        public void SetValueIntervalNotInclude()
        {
            base.exProperty = "not include";
        }

        public void SetUnitByte()
        {
            this.unit = UNIT_BYTE;
        }
        public void SetUnitCharacter()
        {
            this.unit = UNIT_CHARACTER;
        }
    }
}
