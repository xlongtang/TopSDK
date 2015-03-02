using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Top.Schema.Depend;
using Top.Schema.Enums;
using Top.Schema.Exceptions;
using Top.Schema.Util;

namespace Top.Schema.Options
{
    public class Option
    {
        protected string displayName;

        protected string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        protected DependGroup dependGroup;

        public DependGroup DependGroup
        {
            get { return this.dependGroup; }
            set { this.dependGroup = dependGroup; }
        }

        public XmlElement ToElement()
        {
            XmlElement option = XmlUtils.CreateRootElement("option");
            if (StringUtil.IsEmpty(this.displayName))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_33001, null);
            }
            if (StringUtil.IsEmpty(this.value))
            {
                throw new TopSchemaException(TopSchemaErrorCodeEnum.ERROR_CODE_33002, null);
            }
            option.SetAttribute("displayName", this.displayName);
            option.SetAttribute("value", this.value);
            //depend element
            if (dependGroup != null && !dependGroup.IsEmpty())
            {
                XmlElement depend = dependGroup.ToElement();
                XmlUtils.AppendElement(option, depend);
            }
            return option;
        }


        public DependGroup AddDependGroup(string fieldId, string value)
        {
            DependGroup dependGroup = new DependGroup();
            DependExpress dependExpress = dependGroup.AddDependExpress();
            dependExpress.FieldId = fieldId;
            dependExpress.Value = value;
            this.SetDependGroup(dependGroup);
            return dependGroup;
        }

        /**
         * if isInvert is true then express is 'fieldValue != value'
         * @param fieldId
         * @param value
         * @param isInvert
         * @return
         */
        public DependGroup AddDependGroup(string fieldId, string value, string symbol)
        {
            DependGroup dependGroup = new DependGroup();
            DependExpress dependExpress = dependGroup.AddDependExpress();
            dependExpress.FieldId = fieldId;
            dependExpress.Value = value;
            dependExpress.Symbol = symbol;
            this.SetDependGroup(dependGroup);
            return dependGroup;
        }

        public String GetDisplayName()
        {
            return this.displayName;
        }

        public void SetDisplayName(string displayName)
        {
            this.displayName = displayName;
        }

        public String DisplayName()
        {
            return value;
        }

        public DependGroup GetDependGroup()
        {
            return dependGroup;
        }

        public void SetDependGroup(DependGroup dependGroup)
        {
            this.dependGroup = dependGroup;
        }
    }
}
