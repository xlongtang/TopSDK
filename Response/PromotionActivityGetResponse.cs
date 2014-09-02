using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionActivityGetResponse.
    /// </summary>
    public class PromotionActivityGetResponse : TopResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlArray("activitys")]
        [XmlArrayItem("activity")]
        public List<Activity> Activitys { get; set; }
    }
}
