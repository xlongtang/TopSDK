using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// FenxiaoItemRecord Data Structure.
    /// </summary>
    [Serializable]
    public class FenxiaoItemRecord : TopObject
    {
        /// <summary>
        /// 下载时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 分销商ID
        /// </summary>
        [XmlElement("distributor_id")]
        public long DistributorId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 更新时间（系统时间，无业务意义）
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 分销方式：AGENT（只做代销，默认值）、DEALER（只做经销）
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
