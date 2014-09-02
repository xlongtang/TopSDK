using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TravelItemsPriceCalendar Data Structure.
    /// </summary>
    [Serializable]
    public class TravelItemsPriceCalendar : TopObject
    {
        /// <summary>
        /// 儿童库存
        /// </summary>
        [XmlElement("child_num")]
        public long ChildNum { get; set; }

        /// <summary>
        /// 儿童价格（以“分”为单位）。
        /// </summary>
        [XmlElement("child_price")]
        public long ChildPrice { get; set; }

        /// <summary>
        /// 日期。
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 单人房差（以“分”为单位）
        /// </summary>
        [XmlElement("diff_price")]
        public long DiffPrice { get; set; }

        /// <summary>
        /// 成人库存
        /// </summary>
        [XmlElement("man_num")]
        public long ManNum { get; set; }

        /// <summary>
        /// 成人价格（以“分”为单位）
        /// </summary>
        [XmlElement("man_price")]
        public long ManPrice { get; set; }
    }
}
