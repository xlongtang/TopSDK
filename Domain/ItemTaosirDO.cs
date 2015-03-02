using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemTaosirDO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemTaosirDO : TopObject
    {
        /// <summary>
        /// 表达式元素list
        /// </summary>
        [XmlArray("expr_el_list")]
        [XmlArrayItem("item_tao_sir_el_d_o")]
        public List<ItemTaoSirElDO> ExprElList { get; set; }

        /// <summary>
        /// 数值小数点精度
        /// </summary>
        [XmlElement("precision")]
        public long Precision { get; set; }

        /// <summary>
        /// 卖家可选单位List<单位id，单位名>
        /// </summary>
        [XmlArray("std_unit_list")]
        [XmlArrayItem("feature")]
        public List<Feature> StdUnitList { get; set; }

        /// <summary>
        /// 时间类型：0表示非时间，1表示时间点，2表示时间范围
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
