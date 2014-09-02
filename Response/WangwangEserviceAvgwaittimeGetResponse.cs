using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceAvgwaittimeGetResponse.
    /// </summary>
    public class WangwangEserviceAvgwaittimeGetResponse : TopResponse
    {
        /// <summary>
        /// 平均等待时长
        /// </summary>
        [XmlArray("waiting_time_list_on_days")]
        [XmlArrayItem("waiting_times_on_day")]
        public List<WaitingTimesOnDay> WaitingTimeListOnDays { get; set; }
    }
}
