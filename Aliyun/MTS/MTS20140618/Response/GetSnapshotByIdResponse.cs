using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// GetSnapshotByIdResponse.
    /// </summary>
    public class GetSnapshotByIdResponse : AliyunResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 截图的地址
        /// </summary>
        [XmlElement("SnapshotUrl")]
        public string SnapshotUrl { get; set; }
    }
}
