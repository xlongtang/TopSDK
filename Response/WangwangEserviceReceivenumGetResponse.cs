using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceReceivenumGetResponse.
    /// </summary>
    public class WangwangEserviceReceivenumGetResponse : TopResponse
    {
        /// <summary>
        /// 客服回复列表，按天统计，排列
        /// </summary>
        [XmlArray("reply_stat_list_on_days")]
        [XmlArrayItem("reply_stat_on_day")]
        public List<ReplyStatOnDay> ReplyStatListOnDays { get; set; }
    }
}
