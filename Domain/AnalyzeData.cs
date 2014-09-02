using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// AnalyzeData Data Structure.
    /// </summary>
    [Serializable]
    public class AnalyzeData : TopObject
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("string")]
        public List<string> ResultList { get; set; }
    }
}
