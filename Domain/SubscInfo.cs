using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SubscInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubscInfo : TopObject
    {
        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("process_status")]
        public long ProcessStatus { get; set; }

        /// <summary>
        /// 销售提成
        /// </summary>
        [XmlElement("sale_bonus")]
        public long SaleBonus { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 服务开结束时间
        /// </summary>
        [XmlElement("service_end_time")]
        public string ServiceEndTime { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        [XmlElement("service_start_time")]
        public string ServiceStartTime { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [XmlElement("sp_name")]
        public string SpName { get; set; }

        /// <summary>
        /// 子账号名称列表
        /// </summary>
        [XmlElement("sub_account_list")]
        public string SubAccountList { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("subsc_created_time")]
        public string SubscCreatedTime { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("subsc_modified_time")]
        public string SubscModifiedTime { get; set; }
    }
}
