using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpMbbsGetResponse.
    /// </summary>
    public class UmpMbbsGetResponse : TopResponse
    {
        /// <summary>
        /// 营销积木块内容列表，内容为json格式的，可以通过ump sdk里面的MBB.fromJson来处理
        /// </summary>
        [XmlArray("mbbs")]
        [XmlArrayItem("string")]
        public List<string> Mbbs { get; set; }
    }
}
