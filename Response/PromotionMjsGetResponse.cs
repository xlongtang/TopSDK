using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionMjsGetResponse.
    /// </summary>
    public class PromotionMjsGetResponse : TopResponse
    {
        /// <summary>
        /// 活动结束时间。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动备注。可为空，100汉字以内。
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 满就送活动优惠列表。
        /// </summary>
        [XmlArray("mjs_list")]
        [XmlArrayItem("promotion_mjs")]
        public List<PromotionMjs> MjsList { get; set; }

        /// <summary>
        /// 满就送名称。
        /// </summary>
        [XmlElement("mjs_name")]
        public string MjsName { get; set; }

        /// <summary>
        /// 上不封顶标识！
        /// </summary>
        [XmlElement("no_cap")]
        public bool NoCap { get; set; }

        /// <summary>
        /// 淘宝店铺或外店的名字。
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 活动开始时间。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
