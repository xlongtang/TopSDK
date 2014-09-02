using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpActivitiesListGetResponse.
    /// </summary>
    public class UmpActivitiesListGetResponse : TopResponse
    {
        /// <summary>
        /// 营销活动列表！
        /// </summary>
        [XmlArray("activities")]
        [XmlArrayItem("string")]
        public List<string> Activities { get; set; }
    }
}
