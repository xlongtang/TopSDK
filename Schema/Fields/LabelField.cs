using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Top.Schema.Enums;
using Top.Schema.Exceptions;
using Top.Schema.Factory;
using Top.Schema.Labels;
using Top.Schema.Util;

namespace Top.Schema.Fields
{
    public class LabelField : Field
    {
        public LabelField()
        {
            base.type = FieldTypeEnum.LABEL;
        }

        private LabelGroup labelGroup = new LabelGroup();

        public Label AddLabel(string name, string value, string desc)
        {
            Label label = new Label();
            label.Name = name;
            label.Value = value;
            label.Desc = desc;
            labelGroup.Add(label);
            return label;
        }

        public LabelGroup AddSubLabelGroup(string name)
        {
            LabelGroup newLabelGroup = new LabelGroup();
            newLabelGroup.Name = name;
            this.labelGroup.Add(newLabelGroup);
            return newLabelGroup;
        }

        public void Add(Label label)
        {
            labelGroup.Add(label);
        }

        public LabelGroup GetLabelGroup()
        {
            return labelGroup;
        }

        public void SetLabelGroup(LabelGroup labelGroup)
        {
            this.labelGroup = labelGroup;
        }

        public override XmlElement ToElement()
        {
            XmlElement fieldEle = base.ToElement();
            XmlElement lgEle = this.labelGroup.ToElement();
            XmlUtils.AppendElement(fieldEle, lgEle);
            return fieldEle;
        }

        public override XmlElement ToParamElement()
        {
            XmlElement fieldNode = XmlUtils.CreateRootElement("field");
            if (StringUtil.IsEmpty(this.id))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_30001, null);
            }
            if (StringUtil.IsEmpty(FieldTypeEnumHelper.ToType(this.type)))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_30002, this.id);
            }
            fieldNode.SetAttribute("id", this.id);
            fieldNode.SetAttribute("name", this.name);
            fieldNode.SetAttribute("type", FieldTypeEnumHelper.ToType(this.type));
            return fieldNode;
        }

        public override XmlElement ToDefaultValueElement()
        {
            /** LabelField has not default value */
            return null;
        }

        public override void InitDefaultField()
        {
            base.defaultValueField = SchemaFactory.CreateField(FieldTypeEnum.LABEL);
        }
    }
}
