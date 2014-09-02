using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbItemCombinationGetResponse.
    /// </summary>
    public class WlbItemCombinationGetResponse : TopResponse
    {
        /// <summary>
        /// 组合子商品id列表
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("number")]
        public List<long> ItemIdList { get; set; }
    }
}
