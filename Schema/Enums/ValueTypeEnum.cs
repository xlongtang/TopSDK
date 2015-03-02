using System;
using System.Collections.Generic;
using System.Text;

namespace Top.Schema.Enums
{
    public enum ValueTypeEnum
    {
        TEXT,
        TEXTAREA,
        DECIMAL,
        INTEGER,
        LONG,
        DATE,
        TIME,
        URL,
        HTML
    }

    public class ValueTypeEnumHelper
    {
        public static string ToValue(ValueTypeEnum valueTypeEnum)
        {
            switch (valueTypeEnum)
            {
                case ValueTypeEnum.TEXT:
                    return "text";
                case ValueTypeEnum.TEXTAREA:
                    return "textarea";
                case ValueTypeEnum.DECIMAL:
                    return "decimal";
                case ValueTypeEnum.INTEGER:
                    return "integer";
                case ValueTypeEnum.LONG:
                    return "long";
                case ValueTypeEnum.DATE:
                    return "date";
                case ValueTypeEnum.TIME:
                    return "time";
                case ValueTypeEnum.URL:
                    return "url";
                case ValueTypeEnum.HTML:
                    return "html";
                default:
                    return "Unknown ValueTypeEnum";
            }
        }
    }
}
