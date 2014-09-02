using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceStreamweigthsGetResponse.
    /// </summary>
    public class WangwangEserviceStreamweigthsGetResponse : TopResponse
    {
        /// <summary>
        /// 0表示返回正确
        /// </summary>
        [XmlElement("result_code")]
        public long ResultCode { get; set; }

        /// <summary>
        /// 返回数据条数
        /// </summary>
        [XmlElement("result_count")]
        public long ResultCount { get; set; }

        /// <summary>
        /// 分流权重数据
        /// </summary>
        [XmlArray("staff_stream_weights")]
        [XmlArrayItem("stream_weight")]
        public List<StreamWeight> StaffStreamWeights { get; set; }

        /// <summary>
        /// 返回数据的总权重，返回数据为空的时候没有这个数字
        /// </summary>
        [XmlElement("total_weight")]
        public long TotalWeight { get; set; }
    }
}
