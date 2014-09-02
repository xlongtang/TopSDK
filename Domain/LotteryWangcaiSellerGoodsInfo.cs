using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LotteryWangcaiSellerGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LotteryWangcaiSellerGoodsInfo : TopObject
    {
        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("act_begin_time")]
        public string ActBeginTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("act_end_time")]
        public string ActEndTime { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("goods_id")]
        public long GoodsId { get; set; }

        /// <summary>
        /// 彩种id
        /// </summary>
        [XmlElement("lottery_type_id")]
        public long LotteryTypeId { get; set; }

        /// <summary>
        /// 赠送类型：0：满就送，1：好评送，2：分享送，3：游戏送，4：收藏送
        /// </summary>
        [XmlElement("present_type")]
        public long PresentType { get; set; }
    }
}
