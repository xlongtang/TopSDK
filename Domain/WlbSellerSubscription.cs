using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbSellerSubscription Data Structure.
    /// </summary>
    [Serializable]
    public class WlbSellerSubscription : TopObject
    {
        /// <summary>
        /// 定购有效结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 定购ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 判断该仓库是否是实体仓，还是虚拟仓，null是实体仓，10:代表虚拟仓
        /// </summary>
        [XmlElement("is_own_service")]
        public long IsOwnService { get; set; }

        /// <summary>
        /// 父定购ID  可通过该字段来得之服务上下级关系。  例定购了仓储服务，下又有TMS服务。  该字段保存仓储服务ID。
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }

        /// <summary>
        /// 服务商ID
        /// </summary>
        [XmlElement("provider_user_id")]
        public long ProviderUserId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 自有仓的别名，当当前订购记录为自有仓时才会有值
        /// </summary>
        [XmlElement("service_alias")]
        public string ServiceAlias { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [XmlElement("service_id")]
        public long ServiceId { get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务类型，  STORE 1-仓储、  TMS 2-TMS、  PACKAGE 3-包装服务  SUPPLIER 4-供货  INSTALL 5-安装  COMPLEX_SERVICE 100-综合服务
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 定购有效开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 状态  AUDITING 1-待审核  CANCEL 2-撤销  CHECKED 3-审核通过  FAILED 4-审核未通过  SYNCHRONIZING 5-同步中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 定购用户ID
        /// </summary>
        [XmlElement("subscriber_user_id")]
        public long SubscriberUserId { get; set; }

        /// <summary>
        /// 定购用户NICK
        /// </summary>
        [XmlElement("subscriber_user_nick")]
        public string SubscriberUserNick { get; set; }

        /// <summary>
        /// 联系人地址信息
        /// </summary>
        [XmlElement("wlb_partner_address")]
        public WlbPartnerAddress WlbPartnerAddress { get; set; }

        /// <summary>
        /// 联系人联系详情
        /// </summary>
        [XmlElement("wlb_partner_contact")]
        public WlbPartnerContact WlbPartnerContact { get; set; }
    }
}
