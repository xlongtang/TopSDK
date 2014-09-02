using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// QualityUsageDetail Data Structure.
    /// </summary>
    [Serializable]
    public class QualityUsageDetail : TopObject
    {
        /// <summary>
        /// 该订单已经使用的数量
        /// </summary>
        [XmlElement("application_amount")]
        public long ApplicationAmount { get; set; }

        /// <summary>
        /// 质检服务的收费项目码
        /// </summary>
        [XmlElement("article_item_code")]
        public string ArticleItemCode { get; set; }

        /// <summary>
        /// 该订单中尚未使用的数量
        /// </summary>
        [XmlElement("available_amount")]
        public long AvailableAmount { get; set; }

        /// <summary>
        /// 该订单的到期时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 该订单中每个质检服务的价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 该订单订购的数量
        /// </summary>
        [XmlElement("purchas_amount")]
        public long PurchasAmount { get; set; }

        /// <summary>
        /// 该订单的开通时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 订购ID
        /// </summary>
        [XmlElement("sub_id")]
        public long SubId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
