using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmcUserGetResponse.
    /// </summary>
    public class TmcUserGetResponse : TopResponse
    {
        /// <summary>
        /// 开通的用户数据
        /// </summary>
        [XmlElement("tmc_user")]
        public TmcUser TmcUser { get; set; }
    }
}
