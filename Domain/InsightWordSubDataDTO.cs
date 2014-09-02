using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// InsightWordSubDataDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsightWordSubDataDTO : TopObject
    {
        /// <summary>
        /// 关键词
        /// </summary>
        [XmlElement("bidword")]
        public string Bidword { get; set; }

        /// <summary>
        /// 点击量
        /// </summary>
        [XmlElement("click")]
        public long Click { get; set; }

        /// <summary>
        /// 竞争度
        /// </summary>
        [XmlElement("competition")]
        public long Competition { get; set; }

        /// <summary>
        /// 花费，单位（分）
        /// </summary>
        [XmlElement("cost")]
        public long Cost { get; set; }

        /// <summary>
        /// 点击转化率
        /// </summary>
        [XmlElement("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// 平均点击花费
        /// </summary>
        [XmlElement("cpc")]
        public string Cpc { get; set; }

        /// <summary>
        /// 点击率
        /// </summary>
        [XmlElement("ctr")]
        public string Ctr { get; set; }

        /// <summary>
        /// 直接成交金额
        /// </summary>
        [XmlElement("directtransaction")]
        public long Directtransaction { get; set; }

        /// <summary>
        /// 直接成交笔数
        /// </summary>
        [XmlElement("directtransactionshipping")]
        public long Directtransactionshipping { get; set; }

        /// <summary>
        /// 宝贝搜藏数
        /// </summary>
        [XmlElement("favitemtotal")]
        public long Favitemtotal { get; set; }

        /// <summary>
        /// 店铺搜藏数
        /// </summary>
        [XmlElement("favshoptotal")]
        public long Favshoptotal { get; set; }

        /// <summary>
        /// 总的收藏数，包括宝贝收藏和店铺收藏
        /// </summary>
        [XmlElement("favtotal")]
        public long Favtotal { get; set; }

        /// <summary>
        /// 展现量
        /// </summary>
        [XmlElement("impression")]
        public long Impression { get; set; }

        /// <summary>
        /// 间接成交金额
        /// </summary>
        [XmlElement("indirecttransaction")]
        public long Indirecttransaction { get; set; }

        /// <summary>
        /// 间接成交笔数
        /// </summary>
        [XmlElement("indirecttransactionshipping")]
        public long Indirecttransactionshipping { get; set; }

        /// <summary>
        /// 投放机制:0:关键词推广 2：定向推广 3：通用定向
        /// </summary>
        [XmlElement("mechanism")]
        public long Mechanism { get; set; }

        /// <summary>
        /// 流量来源：1:PC站内，2：PC站外,4:无线站内 5：无线站外
        /// </summary>
        [XmlElement("network")]
        public long Network { get; set; }

        /// <summary>
        /// 投入产出比
        /// </summary>
        [XmlElement("roi")]
        public string Roi { get; set; }

        /// <summary>
        /// 总的成交笔数
        /// </summary>
        [XmlElement("transactionshippingtotal")]
        public long Transactionshippingtotal { get; set; }

        /// <summary>
        /// 成交总金额
        /// </summary>
        [XmlElement("transactiontotal")]
        public long Transactiontotal { get; set; }
    }
}
