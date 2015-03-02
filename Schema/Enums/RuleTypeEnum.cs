using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Rules;

namespace Top.Schema.Enums
{
    public enum RuleTypeEnum
    {
        MAX_LENGTH_RULE,
        MIN_LENGTH_RULE,
	    MAX_VALUE_RULE,
        MIN_VALUE_RULE,
	    MAX_INPUT_NUM_RULE,
        MIN_INPUT_NUM_RULE,
	    VALUE_TYPE_RULE,
        REQUIRED_RULE,
        DISABLE_RULE,
        MAX_DECIMAL_DIGITS_RULE,
        MIN_DECIMAL_DIGITS_RULE,
	    REGEX_RULE,
        SET_RULE,
        TIP_RULE,
        DEV_TIP_RULE,
	    READ_ONLY_RULE,
        MAX_TARGET_SIZE_RULE,
        MIN_TARGET_SIZE_RULE,
	    MAX_IMAGE_SIZE_RULE,
        MIN_IMAGE_SIZE_RULE,
        UNKNOWN
    }

    public class RuleTypeEnumHelper
    {
        public static string ToType(RuleTypeEnum ruleTypeEnum)
        {
            switch (ruleTypeEnum)
            {
                case RuleTypeEnum.MAX_LENGTH_RULE:
                    return "maxLengthRule";
                case RuleTypeEnum.MIN_LENGTH_RULE:
                    return "minLengthRule";
                case RuleTypeEnum.MAX_VALUE_RULE:
                    return "maxValueRule";
                case RuleTypeEnum.MIN_VALUE_RULE:
                    return "minValueRule";
                case RuleTypeEnum.MAX_INPUT_NUM_RULE:
                    return "maxInputNumRule";
                case RuleTypeEnum.MIN_INPUT_NUM_RULE:
                    return "minInputNumRule";
                case RuleTypeEnum.VALUE_TYPE_RULE:
                    return "valueTypeRule";
                case RuleTypeEnum.REQUIRED_RULE:
                    return "requiredRule";
                case RuleTypeEnum.DISABLE_RULE:
                    return "disableRule";
                case RuleTypeEnum.MAX_DECIMAL_DIGITS_RULE:
                    return "maxDecimalDigitsRule";
                case RuleTypeEnum.MIN_DECIMAL_DIGITS_RULE:
                    return "minDecimalDigitsRule";
                case RuleTypeEnum.REGEX_RULE:
                    return "regexRule";
                case RuleTypeEnum.SET_RULE:
                    return "setRule";
                case RuleTypeEnum.TIP_RULE:
                    return "tipRule";
                case RuleTypeEnum.DEV_TIP_RULE:
                    return "devTipRule";
                case RuleTypeEnum.READ_ONLY_RULE:
                    return "readOnlyRule";
                case RuleTypeEnum.MAX_TARGET_SIZE_RULE:
                    return "maxTargetSizeRule";
                case RuleTypeEnum.MIN_TARGET_SIZE_RULE:
                    return "minTargetSizeRule";
                case RuleTypeEnum.MAX_IMAGE_SIZE_RULE:
                    return "maxImageSizeRule";
                case RuleTypeEnum.MIN_IMAGE_SIZE_RULE:
                    return "minImageSizeRule";
                default:
                    return "";
            }
        }

        public static Rule CreateRule(RuleTypeEnum ruleType)
        {
            Rule rule = null;
            switch (ruleType)
            {
                case RuleTypeEnum.MAX_LENGTH_RULE:
                    rule = new MaxLengthRule();
                    break;
                case RuleTypeEnum.MIN_LENGTH_RULE:
                    rule = new MinLengthRule();
                    break;
                case RuleTypeEnum.MAX_VALUE_RULE:
                    rule = new MaxValueRule();
                    break;
                case RuleTypeEnum.MIN_VALUE_RULE:
                    rule = new MinValueRule();
                    break;
                case RuleTypeEnum.MAX_INPUT_NUM_RULE:
                    rule = new MaxInputNumRule();
                    break;
                case RuleTypeEnum.MIN_INPUT_NUM_RULE:
                    rule = new MinInputNumRule();
                    break;
                case RuleTypeEnum.VALUE_TYPE_RULE:
                    rule = new ValueTypeRule();
                    break;
                case RuleTypeEnum.REQUIRED_RULE:
                    rule = new RequiredRule();
                    break;
                case RuleTypeEnum.DISABLE_RULE:
                    rule = new DisableRule();
                    break;
                case RuleTypeEnum.MAX_DECIMAL_DIGITS_RULE:
                    rule = new MaxDecimalDigitsRule();
                    break;
                case RuleTypeEnum.MIN_DECIMAL_DIGITS_RULE:
                    rule = new MinDecimalDigitsRule();
                    break;
                case RuleTypeEnum.REGEX_RULE:
                    rule = new RegexRule();
                    break;
                case RuleTypeEnum.SET_RULE:
                    rule = new SetRule();
                    break;
                case RuleTypeEnum.TIP_RULE:
                    rule = new TipRule();
                    break;
                case RuleTypeEnum.DEV_TIP_RULE:
                    rule = new DevTipRule();
                    break;
                case RuleTypeEnum.READ_ONLY_RULE:
                    rule = new ReadOnlyRule();
                    break;
                case RuleTypeEnum.MAX_TARGET_SIZE_RULE:
                    rule = new MaxTargetSizeRule();
                    break;
                case RuleTypeEnum.MIN_TARGET_SIZE_RULE:
                    rule = new MinTargetSizeRule();
                    break;
                case RuleTypeEnum.MAX_IMAGE_SIZE_RULE:
                    rule = new MaxImageSizeRule();
                    break;
                case RuleTypeEnum.MIN_IMAGE_SIZE_RULE:
                    rule = new MinImageSizeRule();
                    break;
            }
            return rule;
        }

        public static RuleTypeEnum GetEnum(string name)
        {
            string[] types = Enum.GetNames(typeof(RuleTypeEnum));
            foreach (var type in types)
            {
                RuleTypeEnum ruleTypeEnum = (RuleTypeEnum)Enum.Parse(typeof(RuleTypeEnum), type);
                if (name.Equals(ToType(ruleTypeEnum)))
                {
                    return ruleTypeEnum;
                }
            }
            return RuleTypeEnum.UNKNOWN;
        }
    }
}
