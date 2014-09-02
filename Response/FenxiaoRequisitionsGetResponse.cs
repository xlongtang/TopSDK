using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoRequisitionsGetResponse.
    /// </summary>
    public class FenxiaoRequisitionsGetResponse : TopResponse
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 合作申请
        /// </summary>
        [XmlArray("requisitions")]
        [XmlArrayItem("requisition")]
        public List<Requisition> Requisitions { get; set; }

        /// <summary>
        /// 结果记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
