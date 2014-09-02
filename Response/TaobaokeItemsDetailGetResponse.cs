using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaobaokeItemsDetailGetResponse.
    /// </summary>
    public class TaobaokeItemsDetailGetResponse : TopResponse
    {
        /// <summary>
        /// 淘宝客商品对象列表
        /// </summary>
        [XmlArray("taobaoke_item_details")]
        [XmlArrayItem("taobaoke_item_detail")]
        public List<TaobaokeItemDetail> TaobaokeItemDetails { get; set; }

        /// <summary>
        /// 搜索到符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
