using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoCooperationGetResponse.
    /// </summary>
    public class FenxiaoCooperationGetResponse : TopResponse
    {
        /// <summary>
        /// 合作分销关系
        /// </summary>
        [XmlArray("cooperations")]
        [XmlArrayItem("cooperation")]
        public List<Cooperation> Cooperations { get; set; }

        /// <summary>
        /// 结果记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
