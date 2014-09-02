using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceOnlinetimeGetResponse.
    /// </summary>
    public class WangwangEserviceOnlinetimeGetResponse : TopResponse
    {
        /// <summary>
        /// 客服在线时长（按天统计，排列）
        /// </summary>
        [XmlArray("online_times_list_on_days")]
        [XmlArrayItem("online_times_on_day")]
        public List<OnlineTimesOnDay> OnlineTimesListOnDays { get; set; }
    }
}
