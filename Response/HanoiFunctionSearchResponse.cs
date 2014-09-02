using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiFunctionSearchResponse.
    /// </summary>
    public class HanoiFunctionSearchResponse : TopResponse
    {
        /// <summary>
        /// 函数配置
        /// </summary>
        [XmlArray("functions")]
        [XmlArrayItem("function")]
        public List<Function> Functions { get; set; }

        /// <summary>
        /// 返回符合条件的记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
