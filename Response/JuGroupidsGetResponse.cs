using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JuGroupidsGetResponse.
    /// </summary>
    public class JuGroupidsGetResponse : TopResponse
    {
        /// <summary>
        /// 获得商品组id列表
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("number")]
        public List<long> GroupIds { get; set; }
    }
}
