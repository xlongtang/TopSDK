using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CarriageDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CarriageDetail : TopObject
    {
        /// <summary>
        /// 续费（单位：元）
        /// </summary>
        [XmlElement("add_fee")]
        public long AddFee { get; set; }

        /// <summary>
        /// 续重（单位：千克）
        /// </summary>
        [XmlElement("add_weight")]
        public long AddWeight { get; set; }

        /// <summary>
        /// 破损赔付
        /// </summary>
        [XmlElement("damage_payment")]
        public string DamagePayment { get; set; }

        /// <summary>
        /// 物流公司揽收时间段
        /// </summary>
        [XmlElement("got_time")]
        public string GotTime { get; set; }

        /// <summary>
        /// 首费（单位：元）
        /// </summary>
        [XmlElement("initial_fee")]
        public long InitialFee { get; set; }

        /// <summary>
        /// 首重（单位：千克）
        /// </summary>
        [XmlElement("initial_weight")]
        public long InitialWeight { get; set; }

        /// <summary>
        /// 丢单赔付
        /// </summary>
        [XmlElement("lost_payment")]
        public string LostPayment { get; set; }

        /// <summary>
        /// 快件送达所需的时间(单位：天)
        /// </summary>
        [XmlElement("way_day")]
        public string WayDay { get; set; }
    }
}
