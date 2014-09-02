using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaobaokeMobileShopsGetResponse.
    /// </summary>
    public class TaobaokeMobileShopsGetResponse : TopResponse
    {
        /// <summary>
        /// 搜索结果列表
        /// </summary>
        [XmlArray("taobaoke_shops")]
        [XmlArrayItem("taobaoke_shop")]
        public List<TaobaokeShop> TaobaokeShops { get; set; }

        /// <summary>
        /// 符合条件的店铺总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
