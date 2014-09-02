using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SubuserDutysGetResponse.
    /// </summary>
    public class SubuserDutysGetResponse : TopResponse
    {
        /// <summary>
        /// 职务信息
        /// </summary>
        [XmlArray("dutys")]
        [XmlArrayItem("duty")]
        public List<Duty> Dutys { get; set; }
    }
}
