using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Top.Schema.Depend;
using Top.Schema.Enums;
using Top.Schema.Exceptions;
using Top.Schema.Fields;
using Top.Schema.Labels;
using Top.Schema.Options;
using Top.Schema.Util;
using Top.Schema.Rules;
using Top.Schema.Values;

namespace Top.Schema.Factory
{
    public class SchemaReader
    {
        public static List<Field> ReadXmlForList(String xmlStirng)
        {
		    XmlElement rootEle = XmlUtils.GetRootElementFromString(xmlStirng);
		    return ReadXmlForList(rootEle);
	    }

        public static IDictionary<String, Field> ReadXmlForMap(String xmlString)
        {
            XmlElement rootEle = XmlUtils.GetRootElementFromString(xmlString);
            return ReadXmlForMap(rootEle);
        }

        public static List<Field> ReadXmlForList(XmlElement rootEle)
        {
            List<Field> fieldList = SchemaFactory.CreateEmptyFieldList();
            List<XmlElement> fieldElmList = XmlUtils.GetChildElements(rootEle, "field");
            foreach (XmlElement fieldElm in fieldElmList)
            {
                Field field = ElementToField(fieldElm);
                fieldList.Add(field);
            }
            return fieldList;
        }

        public static IDictionary<String, Field> ReadXmlForMap(XmlElement rootEle)
        {
            IDictionary<String, Field> fieldMap = new Dictionary<string, Field>();
            List<XmlElement> fieldElmList = XmlUtils.GetChildElements(rootEle, "field");
            foreach (XmlElement fieldElm in fieldElmList)
            {
                Field field = ElementToField(fieldElm);
                fieldMap.Add(field.Id, field);
            }
            return fieldMap;
        }

        public static Field ElementToField(XmlElement fieldElm)
        {
            if (fieldElm == null)
            {
                return null;
            }
            String fieldId = XmlUtils.GetAttributeValue(fieldElm, "id");
            if (StringUtil.IsEmpty(fieldId))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_30001, null);
            }
            String fieldType = XmlUtils.GetAttributeValue(fieldElm, "type");
            if (StringUtil.IsEmpty(fieldType))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_30002, fieldId);
            }
            String fieldName = XmlUtils.GetAttributeValue(fieldElm, "name");

            FieldTypeEnum fieldEnum = FieldTypeEnumHelper.GetEnum(fieldType);
            if (fieldEnum == FieldTypeEnum.UNKNOWN)
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_30003, fieldId);
            }

            Field field_result = null;
            switch (fieldEnum)
            {
                case FieldTypeEnum.INPUT:
                    field_result = ElementToInputField(fieldElm, fieldId, fieldName);
                    break;
                case FieldTypeEnum.SINGLECHECK:
                    field_result = ElementToSingleCheckField(fieldElm, fieldId, fieldName);
                    break;
                case FieldTypeEnum.COMPLEX:
                    field_result = ElementToComplexField(fieldElm, fieldId, fieldName);
                    break;
                case FieldTypeEnum.MULTICHECK:
                    field_result = ElementToMultiCheckField(fieldElm, fieldId, fieldName);
                    break;
                case FieldTypeEnum.MULTICOMPLEX:
                    field_result = ElementToMultiComplexField(fieldElm, fieldId, fieldName);
                    break;
                case FieldTypeEnum.MULTIINPUT:
                    field_result = ElementToMultiInputField(fieldElm, fieldId, fieldName);
                    break;
                case FieldTypeEnum.LABEL:
                    field_result = ElementToLabelField(fieldElm, fieldId, fieldName);
                    break;
            }
            return field_result;
        }

        private static MultiInputField ElementToMultiInputField(XmlElement fieldElm, string fieldId, string fieldName)
        {
            if (fieldElm == null)
            {
                return null;
            }
            MultiInputField multiInputField = (MultiInputField) SchemaFactory.CreateField(FieldTypeEnum.MULTIINPUT);
            multiInputField.Id = fieldId;
            multiInputField.Name = fieldName;
            //rules
            XmlElement rulesEle = XmlUtils.GetChildElement(fieldElm, "rules");
            if (rulesEle != null)
            {
                List<XmlElement> ruleEleList = XmlUtils.GetChildElements(rulesEle, "rule");
                foreach (XmlElement ruleEle in ruleEleList)
                {
                    Rule rule = ElementToRule(ruleEle, multiInputField.Id);
                    multiInputField.Add(rule);
                }
            }
            //property
            XmlElement propertiesEle = XmlUtils.GetChildElement(fieldElm, "properties");
            if (propertiesEle != null)
            {
                List<XmlElement> propertyEleList = XmlUtils.GetChildElements(propertiesEle, "property");
                foreach (XmlElement propertyEle in propertyEleList)
                {
                    Property.Property property = ElementToProperty(propertyEle, multiInputField.Id);
                    multiInputField.Add(property);
                }
            }
            //defaultValue
            XmlElement defaultValuesEle = XmlUtils.GetChildElement(fieldElm, "default-values");
            if (defaultValuesEle != null)
            {
                List<XmlElement> defaultValueEleList = XmlUtils.GetChildElements(defaultValuesEle, "default-value");
                foreach (XmlElement defaultValueEle in defaultValueEleList)
                {
                    string dvalue = defaultValueEle.InnerText;
                    multiInputField.AddDefaultValue(dvalue);
                }
            }
            //value
            XmlElement valuesEle = XmlUtils.GetChildElement(fieldElm, "values");
            if (valuesEle != null)
            {
                List<XmlElement> valueEleList = XmlUtils.GetChildElements(valuesEle, "value");
                foreach (XmlElement valueEle in valueEleList)
                {
                    Value value = new Value();
                    value.PropertyValue = XmlUtils.GetElementValue(valueEle);
                    multiInputField.AddValue(value);
                }
            }
            return multiInputField;
        }

        private static LabelField ElementToLabelField(XmlElement fieldElm, string fieldId, string fieldName)
        {
            if (fieldElm == null)
            {
                return null;
            }
            LabelField labelField = (LabelField) SchemaFactory.CreateField(FieldTypeEnum.LABEL);
            labelField.Id = fieldId;
            labelField.Name = fieldName;
            //rules
            XmlElement rulesEle = XmlUtils.GetChildElement(fieldElm, "rules");
            if (rulesEle != null)
            {
                List<XmlElement> ruleEleList = XmlUtils.GetChildElements(rulesEle, "rule");
                foreach (XmlElement ruleEle in ruleEleList)
                {
                    Rule rule = ElementToRule(ruleEle, labelField.Id);
                    labelField.Add(rule);
                }
            }
            //property
            XmlElement propertiesEle = XmlUtils.GetChildElement(fieldElm, "properties");
            if (propertiesEle != null)
            {
                List<XmlElement> propertyEleList = XmlUtils.GetChildElements(propertiesEle, "property");
                foreach (XmlElement propertyEle in propertyEleList)
                {
                    Property.Property property = ElementToProperty(propertyEle, labelField.Id);
                    labelField.Add(property);
                }
            }
            //labelGroup
            XmlElement labelGroupEle = XmlUtils.GetChildElement(fieldElm, "label-group");
            if (labelGroupEle != null)
            {
                LabelGroup labelGroup = ElementToLabelGroup(labelGroupEle, fieldId);
                labelField.SetLabelGroup(labelGroup);
            }
            return labelField;
        }

        private static InputField ElementToInputField(XmlElement fieldElm, string fieldId, string fieldName)
        {
            if (fieldElm == null)
            {
                return null;
            }
            InputField inputField = (InputField) SchemaFactory.CreateField(FieldTypeEnum.INPUT);
            inputField.Id = fieldId;
            inputField.Name = fieldName;
            //rules
            XmlElement rulesEle = XmlUtils.GetChildElement(fieldElm, "rules");
            if (rulesEle != null)
            {
                List<XmlElement> ruleEleList = XmlUtils.GetChildElements(rulesEle, "rule");
                foreach (XmlElement ruleEle in ruleEleList)
                {
                    Rule rule = ElementToRule(ruleEle, inputField.Id);
                    inputField.Add(rule);
                }
            }
            //property
            XmlElement propertiesEle = XmlUtils.GetChildElement(fieldElm, "properties");
            if (propertiesEle != null)
            {
                List<XmlElement> propertyEleList = XmlUtils.GetChildElements(propertiesEle, "property");
                foreach (XmlElement propertyEle in propertyEleList)
                {
                    Property.Property property = ElementToProperty(propertyEle, inputField.Id);
                    inputField.Add(property);
                }
            }
            //defaultValue
            XmlElement defaultValueEle = XmlUtils.GetChildElement(fieldElm, "default-value");
            if (defaultValueEle != null)
            {
                String dvalue = defaultValueEle.InnerText;
                inputField.SetDefaultValue(dvalue);
            }
            //value
            XmlElement value = XmlUtils.GetChildElement(fieldElm, "value");
            if (value != null)
            {
                inputField.Value = XmlUtils.GetElementValue(value);
            }
            return inputField;
        }

        private static SingleCheckField ElementToSingleCheckField(XmlElement fieldElm, string fieldId, string fieldName)
        {
            if (fieldElm == null)
            {
                return null;
            }
            SingleCheckField singleCheckField = (SingleCheckField) SchemaFactory.CreateField(FieldTypeEnum.SINGLECHECK);
            singleCheckField.Id = fieldId;
            singleCheckField.Name = fieldName;
            //rules
            XmlElement rulesEle = XmlUtils.GetChildElement(fieldElm, "rules");
            if (rulesEle != null)
            {
                List<XmlElement> ruleEleList = XmlUtils.GetChildElements(rulesEle, "rule");
                foreach (XmlElement ruleEle in ruleEleList)
                {
                    Rule rule = ElementToRule(ruleEle, singleCheckField.Id);
                    singleCheckField.Add(rule);
                }
            }
            //option
            XmlElement optionsEle = XmlUtils.GetChildElement(fieldElm, "options");
            if (optionsEle != null)
            {
                List<XmlElement> optionEleList = XmlUtils.GetChildElements(optionsEle, "option");
                foreach (XmlElement optionEleEle in optionEleList)
                {
                    Option op = ElementToOption(optionEleEle, singleCheckField.Id);
                    singleCheckField.Add(op);
                }
            }
            //property
            XmlElement propertiesEle = XmlUtils.GetChildElement(fieldElm, "properties");
            if (propertiesEle != null)
            {
                List<XmlElement> propertyEleList = XmlUtils.GetChildElements(propertiesEle, "property");
                foreach (XmlElement propertyEle in propertyEleList)
                {
                    Property.Property property = ElementToProperty(propertyEle, singleCheckField.Id);
                    singleCheckField.Add(property);
                }
            }
            //defaultValue
            XmlElement defaultValueEle = XmlUtils.GetChildElement(fieldElm, "default-value");
            if (defaultValueEle != null)
            {
                Value value = new Value();
                String dvalue = defaultValueEle.InnerText;
                value.PropertyValue = dvalue;
                singleCheckField.SetDefaultValueDO(value);
            }
            //value
            XmlElement valueEle = XmlUtils.GetChildElement(fieldElm, "value");
            if (valueEle != null)
            {
                Value value = new Value();
                value.PropertyValue = XmlUtils.GetElementValue(valueEle);
                singleCheckField.SetValue(value);
            }
            return singleCheckField;
        }

        private static MultiCheckField ElementToMultiCheckField(XmlElement fieldElm, string fieldId, string fieldName)
        {
            if (fieldElm == null)
            {
                return null;
            }
            MultiCheckField multiCheckField = (MultiCheckField) SchemaFactory.CreateField(FieldTypeEnum.MULTICHECK);
            multiCheckField.Id = fieldId;
            multiCheckField.Name = fieldName;
            //rules
            XmlElement rulesEle = XmlUtils.GetChildElement(fieldElm, "rules");
            if (rulesEle != null)
            {
                List<XmlElement> ruleEleList = XmlUtils.GetChildElements(rulesEle, "rule");
                foreach (XmlElement ruleEle in ruleEleList)
                {
                    Rule rule = ElementToRule(ruleEle, multiCheckField.Id);
                    multiCheckField.Add(rule);
                }
            }
            //option
            XmlElement optionsEle = XmlUtils.GetChildElement(fieldElm, "options");
            if (optionsEle != null)
            {
                List<XmlElement> optionEleList = XmlUtils.GetChildElements(optionsEle, "option");
                foreach (XmlElement optionEleEle in optionEleList)
                {
                    Option op = ElementToOption(optionEleEle, multiCheckField.Id);
                    multiCheckField.Add(op);
                }
            }
            //property
            XmlElement propertiesEle = XmlUtils.GetChildElement(fieldElm, "properties");
            if (propertiesEle != null)
            {
                List<XmlElement> propertyEleList = XmlUtils.GetChildElements(propertiesEle, "property");
                foreach (XmlElement propertyEle in propertyEleList)
                {
                    Property.Property property = ElementToProperty(propertyEle, multiCheckField.Id);
                    multiCheckField.Add(property);
                }
            }
            //defaultValue
            XmlElement defaultValuesEle = XmlUtils.GetChildElement(fieldElm, "default-values");
            if (defaultValuesEle != null)
            {
                List<XmlElement> defaultValueEleList = XmlUtils.GetChildElements(defaultValuesEle, "default-value");
                foreach (XmlElement defaultValueEle in defaultValueEleList)
                {
                    Value value = new Value();
                    String dvalue = defaultValueEle.InnerText;
                    value.PropertyValue = dvalue;
                    multiCheckField.AddDefaultValueDO(value);
                }
            }
            //value
            XmlElement valuesEle = XmlUtils.GetChildElement(fieldElm, "values");
            if (valuesEle != null)
            {
                List<XmlElement> valueEleList = XmlUtils.GetChildElements(valuesEle, "value");
                foreach (XmlElement valueEle in valueEleList)
                {
                    Value value = new Value();
                    value.PropertyValue = XmlUtils.GetElementValue(valueEle);
                    multiCheckField.AddValue(value);
                }
            }
            return multiCheckField;
        }

        private static MultiComplexField ElementToMultiComplexField(XmlElement fieldElm, string fieldId,
            string fieldName)
        {
            if (fieldElm == null)
            {
                return null;
            }
            MultiComplexField multiComplexField =
                (MultiComplexField) SchemaFactory.CreateField(FieldTypeEnum.MULTICOMPLEX);
            multiComplexField.Id = fieldId;
            multiComplexField.Name = fieldName;
            XmlElement fieldsEle = XmlUtils.GetChildElement(fieldElm, "fields");
            if (fieldsEle != null)
            {
                List<XmlElement> fieldEleList = XmlUtils.GetChildElements(fieldsEle, "field");
                foreach (XmlElement subFieldEle in fieldEleList)
                {
                    Field fieldFromEle = ElementToField(subFieldEle);
                    multiComplexField.Add(fieldFromEle);
                }
            }
            //rules
            XmlElement rulesEle = XmlUtils.GetChildElement(fieldElm, "rules");
            if (rulesEle != null)
            {
                List<XmlElement> ruleEleList = XmlUtils.GetChildElements(rulesEle, "rule");
                foreach (XmlElement ruleEle in ruleEleList)
                {
                    Rule rule = ElementToRule(ruleEle, multiComplexField.Id);
                    multiComplexField.Add(rule);
                }
            }
            //property
            XmlElement propertiesEle = XmlUtils.GetChildElement(fieldElm, "properties");
            if (propertiesEle != null)
            {
                List<XmlElement> propertyEleList = XmlUtils.GetChildElements(propertiesEle, "property");
                foreach (XmlElement propertyEle in propertyEleList)
                {
                    Property.Property property = ElementToProperty(propertyEle, multiComplexField.Id);
                    multiComplexField.Add(property);
                }
            }
            //default-values
            XmlElement defaultValuesEle = XmlUtils.GetChildElement(fieldElm, "default-values");
            if (defaultValuesEle != null)
            {
                List<XmlElement> defaultComplexValueEle = XmlUtils.GetChildElements(defaultValuesEle,
                    "default-complex-values");
                foreach (XmlElement dcValue in defaultComplexValueEle)
                {
                    List<XmlElement> defaultValuesSubFieldList = XmlUtils.GetChildElements(dcValue, "field");
                    ComplexValue defaultCvalue = new ComplexValue();
                    foreach (XmlElement subFiledValueEle in defaultValuesSubFieldList)
                    {
                        Field field = ElementToField(subFiledValueEle);
                        defaultCvalue.Put(field);
                    }
                    multiComplexField.addDefaultComplexValue(defaultCvalue);
                }
            }
            //multicomplex-values
            List<XmlElement> complexValuesEle = XmlUtils.GetChildElements(fieldElm, "complex-values");
            foreach (XmlElement complexValue in complexValuesEle)
            {
                List<XmlElement> defaultValuesSubFieldList = XmlUtils.GetChildElements(complexValue, "field");
                ComplexValue cvalue = new ComplexValue();
                foreach (XmlElement subFiledValueEle in defaultValuesSubFieldList)
                {
                    Field field = ElementToField(subFiledValueEle);
                    cvalue.Put(field);
                }
                multiComplexField.AddComplexValue(cvalue);
            }
            return multiComplexField;
        }

        private static ComplexField ElementToComplexField(XmlElement fieldElm, string fieldId, string fieldName)
        {
            if (fieldElm == null)
            {
                return null;
            }
            ComplexField complexField = (ComplexField) SchemaFactory.CreateField(FieldTypeEnum.COMPLEX);
            complexField.Id = fieldId;
            complexField.Name = fieldName;
            XmlElement fieldsEle = XmlUtils.GetChildElement(fieldElm, "fields");
            if (fieldsEle != null)
            {
                List<XmlElement> fieldEleList = XmlUtils.GetChildElements(fieldsEle, "field");
                foreach (XmlElement subFieldEle in fieldEleList)
                {
                    Field fieldFromEle = ElementToField(subFieldEle);
                    complexField.Add(fieldFromEle);
                }
            }
            //rules
            XmlElement rulesEle = XmlUtils.GetChildElement(fieldElm, "rules");
            if (rulesEle != null)
            {
                List<XmlElement> ruleEleList = XmlUtils.GetChildElements(rulesEle, "rule");
                foreach (XmlElement ruleEle in ruleEleList)
                {
                    Rule rule = ElementToRule(ruleEle, complexField.Id);
                    complexField.Add(rule);
                }
            }
            //property
            XmlElement propertiesEle = XmlUtils.GetChildElement(fieldElm, "properties");
            if (propertiesEle != null)
            {
                List<XmlElement> propertyEleList = XmlUtils.GetChildElements(propertiesEle, "property");
                foreach (XmlElement propertyEle in propertyEleList)
                {
                    Property.Property property = ElementToProperty(propertyEle, complexField.Id);
                    complexField.Add(property);
                }
            }
            //default-complex-value
            XmlElement defaultComplexValueEle = XmlUtils.GetChildElement(fieldElm, "default-complex-values");
            if (defaultComplexValueEle != null)
            {
                List<XmlElement> defaultValuesSubFieldList = XmlUtils.GetChildElements(defaultComplexValueEle, "field");
                ComplexValue defaultCvalue = new ComplexValue();
                foreach (XmlElement subFiledValueEle in defaultValuesSubFieldList)
                {
                    Field field = ElementToField(subFiledValueEle);
                    defaultCvalue.Put(field);
                }
                complexField.SetDefaultValue(defaultCvalue);
            }
            //complex-value
            XmlElement complexValueEle = XmlUtils.GetChildElement(fieldElm, "complex-values");
            if (complexValueEle != null)
            {
                List<XmlElement> valuesSubFieldList = XmlUtils.GetChildElements(complexValueEle, "field");
                ComplexValue cvalue = new ComplexValue();
                foreach (XmlElement subFiledValueEle in valuesSubFieldList)
                {
                    Field field = ElementToField(subFiledValueEle);
                    cvalue.Put(field);
                }
                complexField.SetComplexValue(cvalue);
            }
            return complexField;
        }

        /**
	     * xml Element to Rule
	     * @param ruleEle
	     * @param fieldId
	     * @return
	     * @throws TopSchemaException
	     */
        private static Rule ElementToRule(XmlElement ruleEle, string fieldId)
        {
            if (ruleEle == null)
            {
                return null;
            }
            String ruleName = XmlUtils.GetAttributeValue(ruleEle, "name");
            if (StringUtil.IsEmpty(ruleName))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_31001, fieldId);
            }
            String ruleValue = XmlUtils.GetAttributeValue(ruleEle, "value");
            if (StringUtil.IsEmpty(ruleValue))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_31002, fieldId);
            }

            Rule rule = null;
            RuleTypeEnum ruleEnum = RuleTypeEnumHelper.GetEnum(ruleName);
            if (ruleEnum != RuleTypeEnum.UNKNOWN)
            {
                rule = SchemaFactory.CreateRule(ruleEnum);
            }
            else
            {
                rule = SchemaFactory.CreateCustomRule(ruleName, ruleValue);
            }

            if (ruleName.Equals(RuleTypeEnumHelper.ToType(RuleTypeEnum.TIP_RULE)) && !StringUtil.IsEmpty(ruleValue))
            {
                String url = XmlUtils.GetAttributeValue(ruleEle, "url");
                ((TipRule)rule).Url = url;
            }
            if (ruleName.Equals(RuleTypeEnumHelper.ToType(RuleTypeEnum.DEV_TIP_RULE)) && !StringUtil.IsEmpty(ruleValue))
            {
                String url = XmlUtils.GetAttributeValue(ruleEle, "url");
                ((DevTipRule)rule).Url = url;
            }

            String unit = XmlUtils.GetAttributeValue(ruleEle, "unit");
            if (ruleName.Equals(RuleTypeEnumHelper.ToType(RuleTypeEnum.MAX_TARGET_SIZE_RULE)) &&
                !StringUtil.IsEmpty(ruleValue))
            {
                MaxTargetSizeRule mtsRule = (MaxTargetSizeRule) rule;
                mtsRule.Unit = unit;
            }
            else if (ruleName.Equals(RuleTypeEnumHelper.ToType(RuleTypeEnum.MIN_TARGET_SIZE_RULE)) &&
                     !StringUtil.IsEmpty(ruleValue))
            {
                MinTargetSizeRule misRule = (MinTargetSizeRule) rule;
                misRule.Unit = unit;
            }

            String exProperty = XmlUtils.GetAttributeValue(ruleEle, "exProperty");
            if (!StringUtil.IsEmpty(exProperty))
            {
                rule.ExProperty = exProperty;
            }
            rule.Value = ruleValue;
            XmlElement dependGroupEle = XmlUtils.GetChildElement(ruleEle, "depend-group");
            DependGroup dependGroup = ElementToDependGroup(dependGroupEle, fieldId);
            rule.DependGroup = dependGroup;
            return rule;
        }

        private static Property.Property ElementToProperty(XmlElement propertyEle, string fieldId)
        {
            String key = XmlUtils.GetAttributeValue(propertyEle, "key");
            String value = XmlUtils.GetAttributeValue(propertyEle, "value");
            Property.Property property = new Property.Property(key, value);
            return property;
        }

        /**
	     * xml Element to DependGroup
	     * @param dependGroupEle
	     * @param fieldId
	     * @return
	     * @throws TopSchemaException
	     */

        private static DependGroup ElementToDependGroup(XmlElement dependGroupEle, string fieldId)
        {
            if (dependGroupEle == null)
            {
                return null;
            }
            String dependGroupOperator = XmlUtils.GetAttributeValue(dependGroupEle, "operator");
            if (StringUtil.IsEmpty(dependGroupOperator))
            {
                dependGroupOperator = "and";
            }

            DependGroup dg_result = new DependGroup();
            dg_result.Operators = dependGroupOperator;

            List<XmlElement> deEleList = XmlUtils.GetChildElements(dependGroupEle, "depend-express");
            foreach (XmlElement deEle in deEleList)
            {
                DependExpress de = new DependExpress();
                String deFieldId = XmlUtils.GetAttributeValue(deEle, "fieldId");
                String deValue = XmlUtils.GetAttributeValue(deEle, "value");
                String deSymbol = XmlUtils.GetAttributeValue(deEle, "symbol");
                de.FieldId = deFieldId;
                de.Value = deValue;
                de.Symbol = deSymbol;
                dg_result.Add(de);
            }

            List<XmlElement> dgEleList = XmlUtils.GetChildElements(dependGroupEle, "depend-group");
            foreach (XmlElement dgSubEle in dgEleList)
            {
                DependGroup subGroup = new DependGroup();
                subGroup = ElementToDependGroup(dgSubEle, fieldId);
                dg_result.Add(subGroup);
            }

            return dg_result;
        }

        private static LabelGroup ElementToLabelGroup(XmlElement labelGroupEle, string fieldId)
        {
            if (labelGroupEle == null)
            {
                return null;
            }
            String name = XmlUtils.GetAttributeValue(labelGroupEle, "name");
            LabelGroup lg_result = new LabelGroup();
            lg_result.Name = name;
            List<XmlElement> labelEleList = XmlUtils.GetChildElements(labelGroupEle, "label");
            foreach (XmlElement labelEle in labelEleList)
            {
                Label label = new Label();
                String labelName = XmlUtils.GetAttributeValue(labelEle, "name");
                String labelValue = XmlUtils.GetAttributeValue(labelEle, "value");
                String labelDesc = XmlUtils.GetAttributeValue(labelEle, "desc");
                label.Name = labelName;
                label.Value = labelValue;
                label.Desc = labelDesc;
                lg_result.Add(label);
            }
            List<XmlElement> labelGroupEleList = XmlUtils.GetChildElements(labelGroupEle, "label-group");
            foreach (XmlElement subLabelGroupEle in labelGroupEleList)
            {
                LabelGroup subGroup = new LabelGroup();
                subGroup = ElementToLabelGroup(subLabelGroupEle, fieldId);
                lg_result.Add(subGroup);
            }
            return lg_result;
        }

        private static Option ElementToOption(XmlElement optionEle, string fieldId)
        {
            Option opResult = new Option();
            String displayName = XmlUtils.GetAttributeValue(optionEle, "displayName");
            if (StringUtil.IsEmpty(displayName))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_33001, fieldId);
            }
            String value = XmlUtils.GetAttributeValue(optionEle, "value");
            if (StringUtil.IsEmpty(value))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_33002, fieldId);
            }
            opResult.SetDisplayName(displayName);
            opResult.Value = value;

            XmlElement dependGroupEle = XmlUtils.GetChildElement(optionEle, "depend-group");
            DependGroup dependGroup = ElementToDependGroup(dependGroupEle, fieldId);
            opResult.SetDependGroup(dependGroup);
            return opResult;
        }
    }
}
