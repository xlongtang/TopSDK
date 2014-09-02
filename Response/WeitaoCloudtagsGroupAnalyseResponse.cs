using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoCloudtagsGroupAnalyseResponse.
    /// </summary>
    public class WeitaoCloudtagsGroupAnalyseResponse : TopResponse
    {
        /// <summary>
        /// 透视返回结果
        /// </summary>
        [XmlElement("data_list")]
        public AnalyzeDO DataList { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
