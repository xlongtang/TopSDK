using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// AtNSearchItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class AtNSearchItemVO : TopObject
    {
        /// <summary>
        /// 活动优惠金额
        /// </summary>
        [XmlElement("activity_bonus")]
        public string ActivityBonus { get; set; }

        /// <summary>
        /// 代理人编号
        /// </summary>
        [XmlElement("agent_id")]
        public long AgentId { get; set; }

        /// <summary>
        /// JSON串，保存商品扩展信息，相关Key:site(描述是否是极速出票)，I_A_K_P_T_L_U（PC淘客搜索URL），I_A_K_H_T_L_U（H5淘客搜索URL），I_A_K_P_T_D_U（PC淘客下单页URL），I_A_K_H_T_D_U（H5淘客下单页URL）,I_A_K_T_G_Q_01（去程退改签），I_A_K_T_G_Q_10（回程退改签）
        /// </summary>
        [XmlElement("attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// 基准舱位价格，单位分，往返是来回程各段的基准价格之和。
        /// </summary>
        [XmlElement("basic_cabin_price")]
        public string BasicCabinPrice { get; set; }

        /// <summary>
        /// 是否强制保险
        /// </summary>
        [XmlElement("force_insure")]
        public bool ForceInsure { get; set; }

        /// <summary>
        /// 获取保险分润后的价格，不包含活动。不支持分润时返回0
        /// </summary>
        [XmlElement("insure_price")]
        public string InsurePrice { get; set; }

        /// <summary>
        /// 是否是旗舰店商品。
        /// </summary>
        [XmlElement("is_qijian")]
        public bool IsQijian { get; set; }

        /// <summary>
        /// 商品结果类型，0普通单程，1组合往返；2打包往返；3往返直减
        /// </summary>
        [XmlElement("item_type")]
        public long ItemType { get; set; }

        /// <summary>
        /// 销售价格，单位分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品航段数据信息
        /// </summary>
        [XmlArray("segments")]
        [XmlArrayItem("at_n_search_segment_v_o")]
        public List<AtNSearchSegmentVO> Segments { get; set; }

        /// <summary>
        /// 是否支持保险分润
        /// </summary>
        [XmlElement("support_insure_promotion")]
        public bool SupportInsurePromotion { get; set; }

        /// <summary>
        /// 产品票面价，单位分。往返是来回程各段票面价之和
        /// </summary>
        [XmlElement("ticket_price")]
        public string TicketPrice { get; set; }

        /// <summary>
        /// 航程类型，0单程，1往返
        /// </summary>
        [XmlElement("trip_type")]
        public long TripType { get; set; }
    }
}
