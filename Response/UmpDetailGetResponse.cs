using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpDetailGetResponse.
    /// </summary>
    public class UmpDetailGetResponse : TopResponse
    {
        /// <summary>
        /// 活动详情信息，可以通过ump sdk中的MarketingTool来进行处理
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
