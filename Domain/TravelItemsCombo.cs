using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TravelItemsCombo Data Structure.
    /// </summary>
    [Serializable]
    public class TravelItemsCombo : TopObject
    {
        /// <summary>
        /// 销售属性套餐属性值结构。
        /// </summary>
        [XmlElement("combo")]
        public TravelItemsPropValue Combo { get; set; }

        /// <summary>
        /// 套餐下的价格日历集合。
        /// </summary>
        [XmlArray("combo_price_calendars")]
        [XmlArrayItem("travel_items_price_calendar")]
        public List<TravelItemsPriceCalendar> ComboPriceCalendars { get; set; }
    }
}
