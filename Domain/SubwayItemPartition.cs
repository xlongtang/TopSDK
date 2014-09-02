using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// SubwayItemPartition Data Structure.
    /// </summary>
    [Serializable]
    public class SubwayItemPartition : TopObject
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("subway_item")]
        public List<SubwayItem> ItemList { get; set; }

        /// <summary>
        /// 排序，  True:升级False:降序
        /// </summary>
        [XmlElement("order_by")]
        public bool OrderBy { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [XmlElement("order_field")]
        public string OrderField { get; set; }

        /// <summary>
        /// 返回第几页的数据从1开始
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数据大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 所查询的数据总数，只有当返回第一页数据时有值，当要求返回的数据非第一页时，此返回值无效
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
