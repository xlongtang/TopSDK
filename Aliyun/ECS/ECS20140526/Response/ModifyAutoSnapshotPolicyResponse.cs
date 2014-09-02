using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// ModifyAutoSnapshotPolicyResponse.
    /// </summary>
    public class ModifyAutoSnapshotPolicyResponse : AliyunResponse
    {
        /// <summary>
        /// 请求Id
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
