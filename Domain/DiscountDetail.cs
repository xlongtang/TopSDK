using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DiscountDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountDetail : TopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 折扣详情ID
        /// </summary>
        [XmlElement("detail_id")]
        public long DetailId { get; set; }

        /// <summary>
        /// 优惠方式:PERCENT（按折扣优惠）、PRICE（按减价优惠）
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 优惠比率或者优惠价格 10%或10
        /// </summary>
        [XmlElement("discount_value")]
        public long DiscountValue { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 会员等级的id或者分销商id
        /// </summary>
        [XmlElement("target_id")]
        public long TargetId { get; set; }

        /// <summary>
        /// 等级名称或者分销商名称
        /// </summary>
        [XmlElement("target_name")]
        public string TargetName { get; set; }

        /// <summary>
        /// 折扣类型:GRADE（按会员等级优惠）、DISTRIBUTOR（按分销商优惠）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
