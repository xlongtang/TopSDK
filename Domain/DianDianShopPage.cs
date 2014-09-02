using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// DianDianShopPage Data Structure.
    /// </summary>
    [Serializable]
    public class DianDianShopPage : TopObject
    {
        /// <summary>
        /// 淘点点店铺数据列表
        /// </summary>
        [XmlArray("dian_dian_shop_list")]
        [XmlArrayItem("dian_dian_shop")]
        public List<DianDianShop> DianDianShopList { get; set; }

        /// <summary>
        /// 下一页页码
        /// </summary>
        [XmlElement("next_page")]
        public long NextPage { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 上一页页码
        /// </summary>
        [XmlElement("prev_page")]
        public long PrevPage { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
