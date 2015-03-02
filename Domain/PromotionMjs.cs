using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PromotionMjs Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionMjs : TopObject
    {
        /// <summary>
        /// 不免邮省份的area_id列表。用';'间隔。最多10个。[110000:"北京";  120000:"天津";  130000:"河北";  140000:"山西";  150000:"内蒙古";  210000:"辽宁";  220000:"吉林";  230000:"黑龙江";  310000:"上海";  320000:"江苏";  330000:"浙江";  340000:"安徽";  350000:"福建";  360000:"江西";  370000:"山东";  410000:"河南";  420000:"湖北";  430000:"湖南";  440000:"广东";  450000:"广西";  460000:"海南";  500000:"重庆";  510000:"四川";  520000:"贵州";  530000:"云南";  540000:"西藏";  610000:"陕西";  620000:"甘肃";  630000:"青海";  640000:"宁夏";  650000:"新疆";  710000:"台湾";  810000:"香港";  820000:"澳门";  990000:"海外"]
        /// </summary>
        [XmlElement("area_ids")]
        public string AreaIds { get; set; }

        /// <summary>
        /// 送优惠卷。优惠卷的有效期时间。
        /// </summary>
        [XmlElement("coupon_time")]
        public string CouponTime { get; set; }

        /// <summary>
        /// 送优惠卷面额。分为[3,5,10,20,50,100]面值。
        /// </summary>
        [XmlElement("coupon_value")]
        public long CouponValue { get; set; }

        /// <summary>
        /// 是否免邮！
        /// </summary>
        [XmlElement("free_post")]
        public bool FreePost { get; set; }

        /// <summary>
        /// 满就送的满多少钱。正整数。
        /// </summary>
        [XmlElement("full_money")]
        public long FullMoney { get; set; }

        /// <summary>
        /// 最长15个汉字。
        /// </summary>
        [XmlElement("gift_name")]
        public string GiftName { get; set; }

        /// <summary>
        /// 礼品的url地址。礼品链接必须是以http://或https://开头的淘宝站内链接。正则表达式:"^http[s]{0,1}://([a-z0-9\\-_]+\\.)*(mall\\.)?(taobao|taobaocdn)\\.(com|net|cn|com\\.cn)(/.*)*$"
        /// </summary>
        [XmlElement("gift_url")]
        public string GiftUrl { get; set; }

        /// <summary>
        /// 满就送积分。
        /// </summary>
        [XmlElement("points")]
        public long Points { get; set; }

        /// <summary>
        /// true时，减后满full_money才免邮费。false时，减前满full_money就免邮。
        /// </summary>
        [XmlElement("reduce_after")]
        public bool ReduceAfter { get; set; }

        /// <summary>
        /// 满就送减掉的钱数。当满足full_money时，就减掉的钱数。这个钱数是小于full_money的正整数。
        /// </summary>
        [XmlElement("reduce_money")]
        public long ReduceMoney { get; set; }
    }
}
