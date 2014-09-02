using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaobaokeItemsGetResponse.
    /// </summary>
    public class TaobaokeItemsGetResponse : TopResponse
    {
        /// <summary>
        /// 淘宝客商品对象列表.不返回taobaoke_cat_click_url和keyword_click_url两个字段。
        /// </summary>
        [XmlArray("taobaoke_items")]
        [XmlArrayItem("taobaoke_item")]
        public List<TaobaokeItem> TaobaokeItems { get; set; }

        /// <summary>
        /// 搜索到符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
