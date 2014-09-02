using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// AlipayUserAccountreportGetResponse.
    /// </summary>
    public class AlipayUserAccountreportGetResponse : TopResponse
    {
        /// <summary>
        /// 对账记录列表
        /// </summary>
        [XmlArray("alipay_records")]
        [XmlArrayItem("alipay_record")]
        public List<AlipayRecord> AlipayRecords { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
