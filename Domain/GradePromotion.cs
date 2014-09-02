using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// GradePromotion Data Structure.
    /// </summary>
    [Serializable]
    public class GradePromotion : TopObject
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
        /// 会员级别折扣率没有小数，990代表9.9折
        /// </summary>
        [XmlElement("discount")]
        public long Discount { get; set; }

        /// <summary>
        /// 普通会员、高级会员、VIP会员、至尊VIP。空的时候代表后续等级未启用或没有下一等级
        /// </summary>
        [XmlElement("next_grade")]
        public string NextGrade { get; set; }

        /// <summary>
        /// 该等级对应的下一等级1:普通会员  2：高级会员 3：VIP会员 4：至尊VIP 0：后续等级都未启用或没有下一等级
        /// </summary>
        [XmlElement("next_grade_name")]
        public string NextGradeName { get; set; }

        /// <summary>
        /// 升级到下一个级别的需要的交易额，单位：分
        /// </summary>
        [XmlElement("next_upgrade_amount")]
        public long NextUpgradeAmount { get; set; }

        /// <summary>
        /// 升级到下一个级别的需要的交易量
        /// </summary>
        [XmlElement("next_upgrade_count")]
        public long NextUpgradeCount { get; set; }
    }
}
