using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Distributor Data Structure.
    /// </summary>
    [Serializable]
    public class Distributor : TopObject
    {
        /// <summary>
        /// 分销商的支付宝帐户
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 分销商的淘宝卖家评价
        /// </summary>
        [XmlElement("appraise")]
        public long Appraise { get; set; }

        /// <summary>
        /// 分销商店铺主营类目
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact_person")]
        public string ContactPerson { get; set; }

        /// <summary>
        /// 分销商创建时间 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 分销商Id
        /// </summary>
        [XmlElement("distributor_id")]
        public long DistributorId { get; set; }

        /// <summary>
        /// 分销商姓名
        /// </summary>
        [XmlElement("distributor_name")]
        public string DistributorName { get; set; }

        /// <summary>
        /// 分销商的email
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 分销商的真实姓名，认证姓名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 店铺等级
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 分销商的手机号
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 分销商的电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 分销商的网店链接
        /// </summary>
        [XmlElement("shop_web_link")]
        public string ShopWebLink { get; set; }

        /// <summary>
        /// 分销商卖家的开店时间
        /// </summary>
        [XmlElement("starts")]
        public string Starts { get; set; }

        /// <summary>
        /// 分销商ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
