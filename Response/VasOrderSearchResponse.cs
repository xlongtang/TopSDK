using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// VasOrderSearchResponse.
    /// </summary>
    public class VasOrderSearchResponse : TopResponse
    {
        /// <summary>
        /// 商品订单对象
        /// </summary>
        [XmlArray("article_biz_orders")]
        [XmlArrayItem("article_biz_order")]
        public List<ArticleBizOrder> ArticleBizOrders { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
