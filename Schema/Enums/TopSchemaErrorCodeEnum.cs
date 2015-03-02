using System;
using System.Collections.Generic;
using System.Text;

namespace Top.Schema.Enums
{
    public enum TopSchemaErrorCodeEnum
    {
        // 10000-system error
	    // 20000-rule check error
	    // 30000-schema field format error
	    // 30000-schema rule format error
	    // 40000-util error
	    // 00010-MaxLengthRule
	    ERROR_CODE_10001,
	    ERROR_CODE_10002,
	
	    ERROR_CODE_20010,
	    ERROR_CODE_20020,
	    ERROR_CODE_20030,
	    ERROR_CODE_20031,
	    ERROR_CODE_20032,
	    ERROR_CODE_20033,
	    ERROR_CODE_20034,
	    ERROR_CODE_20040,
	    ERROR_CODE_20050,
	    ERROR_CODE_20051,
	    ERROR_CODE_20060,
	    ERROR_CODE_20061,
	    ERROR_CODE_20070,
	    ERROR_CODE_20080,
	    ERROR_CODE_20090,
	    ERROR_CODE_20100,
	
	    ERROR_CODE_30001,
	    ERROR_CODE_30002,
	    ERROR_CODE_30003,
	    ERROR_CODE_31001,
	    ERROR_CODE_31002,
	    ERROR_CODE_31003,
	    ERROR_CODE_32001,
	    ERROR_CODE_32002,
	    ERROR_CODE_33001,
	    ERROR_CODE_33002,
	
	    ERROR_CODE_30010,
	    ERROR_CODE_30020,
	    ERROR_CODE_30030,
	    ERROR_CODE_30050,
	    ERROR_CODE_30060,
	    ERROR_CODE_30070,
	    ERROR_CODE_30080,
	
	    ERROR_CODE_40000
    }

    public class TopSchemaErrorCodeEnumHelper
    {
        public static string ToErrorCode(TopSchemaErrorCodeEnum topSchemaErrorCodeEnum)
        {
            switch (topSchemaErrorCodeEnum)
            {
                case TopSchemaErrorCodeEnum.ERROR_CODE_10001:
                    return "10001";
                case TopSchemaErrorCodeEnum.ERROR_CODE_10002:
                    return "10002";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20010:
                    return "20010";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20020:
                    return "20020";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20030:
                    return "20030";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20031:
                    return "20031";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20032:
                    return "20032";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20033:
                    return "20033";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20034:
                    return "20034";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20040:
                    return "20040";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20050:
                    return "20050";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20051:
                    return "20051";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20060:
                    return "20060";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20061:
                    return "20061";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20070:
                    return "20070";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20080:
                    return "20080";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20090:
                    return "20090";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20100:
                    return "20100";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30001:
                    return "30001";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30002:
                    return "30002";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30003:
                    return "30003";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30010:
                    return "30010";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30020:
                    return "30020";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30030:
                    return "30030";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30050:
                    return "30050";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30060:
                    return "30060";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30070:
                    return "30070";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30080:
                    return "30080";
                case TopSchemaErrorCodeEnum.ERROR_CODE_31001:
                    return "31001";
                case TopSchemaErrorCodeEnum.ERROR_CODE_31002:
                    return "31002";
                case TopSchemaErrorCodeEnum.ERROR_CODE_31003:
                    return "31003";
                case TopSchemaErrorCodeEnum.ERROR_CODE_32001:
                    return "32001";
                case TopSchemaErrorCodeEnum.ERROR_CODE_32002:
                    return "32002";
                case TopSchemaErrorCodeEnum.ERROR_CODE_33001:
                    return "33001";
                case TopSchemaErrorCodeEnum.ERROR_CODE_33002:
                    return "33002";
                case TopSchemaErrorCodeEnum.ERROR_CODE_40000:
                    return "40000";
                default:
                    return "Unknown errorCode error!";
            }
        }

        public static string ToMessage(TopSchemaErrorCodeEnum topSchemaErrorCodeEnum)
        {
            switch (topSchemaErrorCodeEnum)
            {
                case TopSchemaErrorCodeEnum.ERROR_CODE_10001:
                    return "Cannot find File!Please check your file path!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_10002:
                    return "Create Document Exception!ParserConfigurationException!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20010:
                    return "Illegal Value,MaxLengthRule check failed!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20020:
                    return "Illegal Value,MinLengthRule check failed!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20030:
                    return "Illegal Value,ValueTypeRule check failed!Field's value is not a decimal!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20031:
                    return "Illegal Value,ValueTypeRule check failed!Field's value is not a integer!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20032:
                    return "Illegal Value,ValueTypeRule check failed!Field's value is not a date!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20033:
                    return "Illegal Value,ValueTypeRule check failed!Field's value is not a time!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20034:
                    return "Illegal Value,ValueTypeRule check failed!Field's value is not a url!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20040:
                    return "RequiredRule check failed!Field's value should not be null!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20050:
                    return "MaxValueRule check failed!Field's value is not a Number!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20051:
                    return "MaxValueRule check failed!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20060:
                    return "MinValueRule check failed!Field's value is not a Number!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20061:
                    return "MinValueRule check failed!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20070:
                    return "MaxCheckNumRule check failed!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20080:
                    return "MinCheckNumRule check failed!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20090:
                    return "InputRule check failed!FieldValue is not from fieldOptions!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_20100:
                    return "RegexRule check failed!FieldValue not matches regex!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30001:
                    return "Field format error!Field's id should not be null!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30002:
                    return "Field format error!Field's type should not be null!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30003:
                    return "Field format error!Field's type is illegal!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30010:
                    return "MaxLengthRule format error!MaxLengthRule is not an Integer!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30020:
                    return "MinLengthRule format error!MinLengthRule is not an Integer!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30030:
                    return "ValueTypeRule format error!ValueType is illegal!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30050:
                    return "MaxValueRule format error!MaxValueRule is not an Integer!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30060:
                    return "MinValueRule format error!MinValueRule is not an Integer!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30070:
                    return "MaxCheckNumRule format error!MaxCheckNumRule is not an Integer!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_30080:
                    return "MinCheckNumRule format error!MinCheckNumRule is not an Integer!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_31001:
                    return "Rule format error!Rule's name should not be null!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_31002:
                    return "Rule format error!Rule's value should not be null!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_31003:
                    return "Rule format error!Rule's value is illegal!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_32001:
                    return "Depend format error!Depend's fieldId should not be null!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_32002:
                    return "Depend format error!Depend's value should not be null!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_33001:
                    return "Option format error!Option's displayName should not be null!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_33002:
                    return "Option format error!Option's value should not be null!";
                case TopSchemaErrorCodeEnum.ERROR_CODE_40000:
                    return "";
                default:
                    return "Unknown message error!";
            }
        }
    }
}
