using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Top.Schema.Exceptions;
using Top.Schema.Util;

namespace Top.Schema.Labels
{
    public class LabelGroup
    {
        public string Name { get; set; }

        private List<LabelGroup> labelGroupList = new List<LabelGroup>();

        private List<Label> labelList = new List<Label>();

        public XmlElement ToElement()
        {
            XmlElement labelGroupEle = XmlUtils.CreateRootElement("label-group");
            labelGroupEle.SetAttribute("name", Name);
            foreach (Label label in labelList)
            {
                XmlElement labelElement = XmlUtils.AppendElement(labelGroupEle, "label");
                labelElement.SetAttribute("name", label.Name);
                labelElement.SetAttribute("value", label.Value);
                labelElement.SetAttribute("desc", label.Desc);
            }
            foreach (LabelGroup labelGroup in labelGroupList)
            {
                XmlElement subLabelGroupElement = labelGroup.ToElement();
                XmlUtils.AppendElement(labelGroupEle, subLabelGroupElement);
            }
            return labelGroupEle;
        }

        public void AddLabel(string name, string value, string desc)
        {
            Label label = new Label();
            label.Name = name;
            label.Value = value;
            label.Desc = desc;
            this.labelList.Add(label);
        }

        public void Add(Label label)
        {
            this.labelList.Add(label);
        }

        public void Add(LabelGroup labelGroup)
        {
            this.labelGroupList.Add(labelGroup);
        }

        public List<LabelGroup> GetLabelGroupList()
        {
            return this.labelGroupList;
        }

        public void SetLabelGroupList(List<LabelGroup> labelGroupList)
        {
            this.labelGroupList = labelGroupList;
        }

        public List<Label> GetLabelList()
        {
            return this.labelList;
        }

        public void SetLabelList(List<Label> labelList)
        {
            this.labelList = labelList;
        }
    }
}
