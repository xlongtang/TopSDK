using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallSelectedItemsSearchResponse.
    /// </summary>
    public class TmallSelectedItemsSearchResponse : TopResponse
    {
        /// <summary>
        /// 天猫精选商品列表。同一天之内，同一个appkey请求同一个cid得到的商品列表是固定的，所以每天只需请求一次即可
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("selected_item")]
        public List<SelectedItem> ItemList { get; set; }
    }
}
