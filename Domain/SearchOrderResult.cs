using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// SearchOrderResult Data Structure.
    /// </summary>
    [Serializable]
    public class SearchOrderResult : TopObject
    {
        /// <summary>
        /// 是否还有下一页，即满足搜索条件的订单数是否还有下一个分页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 淘宝机票订单列表
        /// </summary>
        [XmlArray("order_ids")]
        [XmlArrayItem("number")]
        public List<long> OrderIds { get; set; }

        /// <summary>
        /// 当前淘宝系统设定的搜索结果页大小，即支持一次最多返回订单条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
