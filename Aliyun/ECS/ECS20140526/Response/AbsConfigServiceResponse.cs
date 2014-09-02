using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// AbsConfigServiceResponse.
    /// </summary>
    public class AbsConfigServiceResponse : AliyunResponse
    {
        /// <summary>
        /// List
        /// </summary>
        [XmlArray("List")]
        [XmlArrayItem("String")]
        public List<string> List { get; set; }
    }
}
