using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SpmeffectGetResponse.
    /// </summary>
    public class SpmeffectGetResponse : TopResponse
    {
        /// <summary>
        /// 某一天该Appkey的站点导购数据
        /// </summary>
        [XmlElement("spm_result")]
        public SpmResult SpmResult { get; set; }
    }
}
