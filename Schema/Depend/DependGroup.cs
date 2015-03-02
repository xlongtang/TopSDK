using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Top.Schema.Fields;
using Top.Schema.Util;

namespace Top.Schema.Depend
{
    public class DependGroup
    {
        /**
	     <depend-group operator="and"> -- the expression is ' a==1 && (b==2 || c<3) ' 
		     <depend-express path="a" value="1" />
		     <depend-group operator="or">
			     <depend-express fieldId="b" value="2" />
			     <depend-express fieldId="c" value="3" dependExpress="<" />
		     </depend-group>
	     </depend-group>
	    **/

        public const string OPERATOR_AND = "and";
	    public const string OPERATOR_OR = "or";
	
	    protected List<DependExpress> dependExpressList = new List<DependExpress>();
	    protected string operators = OPERATOR_AND;

        public string Operators
        {
            get { return this.operators; }
            set { this.operators = value; }
        }

        protected List<DependGroup> dependGroupList = new List<DependGroup>();

        public XmlElement ToElement() 
        {
            XmlElement dependGroup = XmlUtils.CreateRootElement("depend-group");
            dependGroup.SetAttribute("operator", this.operators);
            foreach (DependExpress dependExpress in dependExpressList)
            {
                XmlElement dependExpressElement = XmlUtils.AppendElement(dependGroup, "depend-express");
                dependExpressElement.SetAttribute("fieldId", dependExpress.FieldId);
                dependExpressElement.SetAttribute("value", dependExpress.Value);
                dependExpressElement.SetAttribute("symbol", dependExpress.Symbol);
            }
            foreach (DependGroup dependGroupNode in dependGroupList)
            {
                XmlElement dependGroupElement = dependGroupNode.ToElement();
                XmlUtils.AppendElement(dependGroup, dependGroupElement);
            }
            return dependGroup;
        }

        public bool IsEmpty()
        {
            if ((this.dependExpressList == null || this.dependExpressList.Count == 0) &&
                (this.dependGroupList == null || this.dependGroupList.Count == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ToExpress()
        {
            string exp = "";
            foreach (DependExpress dependExpress in this.dependExpressList)
            {
                string expLocal = "";
                if (exp.Length > 0)
                {
                    expLocal += this.operators;
                }
                expLocal += " " + dependExpress.FieldId;
                expLocal += dependExpress.Symbol;
                expLocal += dependExpress.Value;
                exp += expLocal;
            }
            foreach (DependGroup dependGroupNode in dependGroupList)
            {
                string expLocal = "";
                if (exp.Length > 0)
                {
                    expLocal += this.operators;
                }
                expLocal += " (" + dependGroupNode.ToExpress() + ") ";
                exp += expLocal;
            }
            return exp;
        }

        public bool ExcuteExpress(IDictionary<String, Field> fieldMap)
        {
            if (OPERATOR_AND.Equals(this.operators))
            {
                foreach (DependExpress dependExpress in dependExpressList)
                {
                    if (!dependExpress.ExcuteExpress(fieldMap))
                    {
                        return false;
                    }
                }
                foreach (DependGroup dependGroup in dependGroupList)
                {
                    if (!dependGroup.ExcuteExpress(fieldMap))
                    {
                        return false;
                    }
                }
                return true;
            }
            else if (OPERATOR_OR.Equals(this.operators))
            {
                foreach (DependExpress dependExpress in dependExpressList)
                {
                    if (dependExpress.ExcuteExpress(fieldMap))
                    {
                        return true;
                    }
                }
                foreach (DependGroup dependGroup in dependGroupList)
                {
                    if (dependGroup.ExcuteExpress(fieldMap))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public DependExpress AddDependExpress()
        {
            DependExpress de = new DependExpress();
            this.Add(de);
            return de;
        }

        public DependExpress AddDependExpress(string fieldId, string value)
        {
            DependExpress de = new DependExpress();
            de.FieldId = fieldId;
            de.Value = value;
            this.Add(de);
            return de;
        }

        public DependGroup AddDependGroup()
        {
            DependGroup dg = new DependGroup();
            this.Add(dg);
            return dg;
        }

        public void Add(DependExpress de)
        {
            dependExpressList.Add(de);
        }

        public void Add(DependGroup de)
        {
            dependGroupList.Add(de);
        }

        public List<DependExpress> GetDependExpressList()
        {
            return dependExpressList;
        }

        public void SetDependExpressList(List<DependExpress> dependExpressList)
        {
            this.dependExpressList = dependExpressList;
        }

        public List<DependGroup> GetDependGroupList()
        {
            return dependGroupList;
        }

        public void SetDependGroupList(List<DependGroup> dependGroupList)
        {
            this.dependGroupList = dependGroupList;
        }
    }
}
