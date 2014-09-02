using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ServiceSubscribe Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceSubscribe : TopObject
    {
        /// <summary>
        /// 订购总数
        /// </summary>
        [XmlElement("all_num")]
        public long AllNum { get; set; }

        /// <summary>
        /// 将要被使用的那条质检订单的价格
        /// </summary>
        [XmlElement("future_price")]
        public string FuturePrice { get; set; }

        /// <summary>
        /// 将要被消耗的质检订单ID
        /// </summary>
        [XmlElement("future_sub_id")]
        public long FutureSubId { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("gmt_expiry")]
        public string GmtExpiry { get; set; }

        /// <summary>
        /// 订购者昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 服务收费项code
        /// </summary>
        [XmlElement("service_item_code")]
        public string ServiceItemCode { get; set; }

        /// <summary>
        /// 该用户该收费项目下面的所有的订购记录详情
        /// </summary>
        [XmlArray("usage_detail_list")]
        [XmlArrayItem("quality_usage_detail")]
        public List<QualityUsageDetail> UsageDetailList { get; set; }

        /// <summary>
        /// 已经使用的数量
        /// </summary>
        [XmlElement("used_num")]
        public long UsedNum { get; set; }
    }
}
