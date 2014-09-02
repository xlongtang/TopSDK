using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// SellerAuthorize Data Structure.
    /// </summary>
    [Serializable]
    public class SellerAuthorize : TopObject
    {
        /// <summary>
        /// 品牌列表
        /// </summary>
        [XmlArray("brands")]
        [XmlArrayItem("brand")]
        public List<Brand> Brands { get; set; }

        /// <summary>
        /// 类目列表
        /// </summary>
        [XmlArray("item_cats")]
        [XmlArrayItem("item_cat")]
        public List<ItemCat> ItemCats { get; set; }

        /// <summary>
        /// 被授权的新品类目列表
        /// </summary>
        [XmlArray("xinpin_item_cats")]
        [XmlArrayItem("item_cat")]
        public List<ItemCat> XinpinItemCats { get; set; }
    }
}
