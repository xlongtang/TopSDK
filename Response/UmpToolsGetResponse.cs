using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpToolsGetResponse.
    /// </summary>
    public class UmpToolsGetResponse : TopResponse
    {
        /// <summary>
        /// 工具列表，单个内容为json格式，需要通过ump的sdk提供的MarketingBuilder来进行处理
        /// </summary>
        [XmlArray("tools")]
        [XmlArrayItem("string")]
        public List<string> Tools { get; set; }
    }
}
