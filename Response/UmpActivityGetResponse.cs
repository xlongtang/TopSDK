using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpActivityGetResponse.
    /// </summary>
    public class UmpActivityGetResponse : TopResponse
    {
        /// <summary>
        /// 营销活动的内容，可以通过ump sdk中的marketingTool来完成对该内容的处理
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
