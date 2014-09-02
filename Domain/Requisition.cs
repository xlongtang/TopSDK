using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Requisition Data Structure.
    /// </summary>
    [Serializable]
    public class Requisition : TopObject
    {
        /// <summary>
        /// 好评率
        /// </summary>
        [XmlElement("dist_appraise")]
        public long DistAppraise { get; set; }

        /// <summary>
        /// 主营类目
        /// </summary>
        [XmlElement("dist_category")]
        public long DistCategory { get; set; }

        /// <summary>
        /// 主营类目名称
        /// </summary>
        [XmlElement("dist_category_name")]
        public string DistCategoryName { get; set; }

        /// <summary>
        /// 是否消保(0-不是、1-是)
        /// </summary>
        [XmlElement("dist_is_xiaobao")]
        public long DistIsXiaobao { get; set; }

        /// <summary>
        /// 店铺星级
        /// </summary>
        [XmlElement("dist_level")]
        public long DistLevel { get; set; }

        /// <summary>
        /// 分销申请加盟时，给供应商的留言
        /// </summary>
        [XmlElement("dist_message")]
        public string DistMessage { get; set; }

        /// <summary>
        /// 开店时间
        /// </summary>
        [XmlElement("dist_open_date")]
        public string DistOpenDate { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("dist_shop_address")]
        public string DistShopAddress { get; set; }

        /// <summary>
        /// 分销商id
        /// </summary>
        [XmlElement("distributor_id")]
        public long DistributorId { get; set; }

        /// <summary>
        /// 分销商nick
        /// </summary>
        [XmlElement("distributor_nick")]
        public string DistributorNick { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 合作申请ID
        /// </summary>
        [XmlElement("requisition_id")]
        public long RequisitionId { get; set; }

        /// <summary>
        /// 申请状态（1-申请中、2-成功、3-被退回、4-已撤消、5-过期）
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
