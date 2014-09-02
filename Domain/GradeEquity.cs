using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// GradeEquity Data Structure.
    /// </summary>
    [Serializable]
    public class GradeEquity : TopObject
    {
        /// <summary>
        /// 买家会员级别  0:店铺客户  1：普通会员 2：高级会员 3：VIP会员 4：至尊VIP
        /// </summary>
        [XmlElement("cur_grade")]
        public string CurGrade { get; set; }

        /// <summary>
        /// 店铺客户、普通会员 、高级会员、VIP会员、至尊VIP
        /// </summary>
        [XmlElement("cur_grade_name")]
        public string CurGradeName { get; set; }

        /// <summary>
        /// 在包邮的前提下的不免邮区域
        /// </summary>
        [XmlElement("exclude_area")]
        public string ExcludeArea { get; set; }

        /// <summary>
        /// 返回几倍tmall积分
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }

        /// <summary>
        /// 是否该等级开启包邮
        /// </summary>
        [XmlElement("postage")]
        public bool Postage { get; set; }
    }
}
