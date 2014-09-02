using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// SuiteConfDO Data Structure.
    /// </summary>
    [Serializable]
    public class SuiteConfDO : TopObject
    {
        /// <summary>
        /// 如果有值，套装子规格形如：A*n,B*n,C*n....，n只能是inputs中的
        /// </summary>
        [XmlArray("inputs")]
        [XmlArrayItem("number")]
        public List<long> Inputs { get; set; }

        /// <summary>
        /// 套装，子规格限制数，当前一级类目，最多允许选择多少个产品规格，为空表示无限制。套装子规格形如:A*n,B*n,C*n....,max_size就是C的最大个数
        /// </summary>
        [XmlElement("max_size")]
        public long MaxSize { get; set; }

        /// <summary>
        /// 套装，子规格数量总和限制，当前一级类目，所以子产品规格的数量不能超过这个值，为空表示无限制,套装子规格形如：A*n,B*n,C*n....,max_total_number就是所有n和的最大限制
        /// </summary>
        [XmlElement("max_total_number")]
        public long MaxTotalNumber { get; set; }

        /// <summary>
        /// 一级类目ID，标识在该一级在类目下能布套装
        /// </summary>
        [XmlElement("root_cat_id")]
        public long RootCatId { get; set; }

        /// <summary>
        /// 套装类目ID，当前一级类目，如果发布跨叶子类目的的套装，默认放到那个类目。如果没有值表示root_cat_id类目下发布的套装产品，不支持跨类目
        /// </summary>
        [XmlElement("suite_cat_id")]
        public long SuiteCatId { get; set; }
    }
}
