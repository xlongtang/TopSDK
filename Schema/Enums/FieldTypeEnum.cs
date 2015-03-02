using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Fields;

namespace Top.Schema.Enums
{
    public enum FieldTypeEnum
    {
        INPUT,
        MULTIINPUT,
        MULTICHECK,
        SINGLECHECK,
        COMPLEX,
        MULTICOMPLEX,
        LABEL,
        UNKNOWN
    }

    public class FieldTypeEnumHelper
    {
        public static string ToType(FieldTypeEnum fieldTypeEnum)
        {
            switch (fieldTypeEnum)
            {
                case FieldTypeEnum.INPUT:
                    return "input";
                case FieldTypeEnum.MULTIINPUT:
                    return "multiInput";
                case FieldTypeEnum.MULTICHECK:
                    return "multiCheck";
                case FieldTypeEnum.SINGLECHECK:
                    return "singleCheck";
                case FieldTypeEnum.COMPLEX:
                    return "complex";
                case FieldTypeEnum.MULTICOMPLEX:
                    return "multiComplex";
                case FieldTypeEnum.LABEL:
                    return "label";
                default:
                    return "";
            }
        }

        public static Field CreateField(FieldTypeEnum fieldEnum)
        {
            Field field = null;
            switch (fieldEnum)
            {
                case FieldTypeEnum.INPUT:
                    field = new InputField();
                    break;
                case FieldTypeEnum.MULTIINPUT:
                    field = new MultiInputField();
                    break;
                case FieldTypeEnum.SINGLECHECK:
                    field = new SingleCheckField();
                    break;
                case FieldTypeEnum.MULTICHECK:
                    field = new MultiCheckField();
                    break;
                case FieldTypeEnum.COMPLEX:
                    field = new ComplexField();
                    break;
                case FieldTypeEnum.MULTICOMPLEX:
                    field = new MultiComplexField();
                    break;
                case FieldTypeEnum.LABEL:
                    field = new LabelField();
                    break;
            }
            return field;
        }

        public static FieldTypeEnum GetEnum(string name)
        {
            string[] types = Enum.GetNames(typeof (FieldTypeEnum));
            foreach (var type in types)
            {
                FieldTypeEnum fieldTypeEnum = (FieldTypeEnum)Enum.Parse(typeof (FieldTypeEnum), type);
                if (name.Equals(ToType(fieldTypeEnum)))
                {
                    return fieldTypeEnum;
                }
            }
            return FieldTypeEnum.UNKNOWN;
        }
    }
}
