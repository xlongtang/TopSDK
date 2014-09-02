using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductTemplateGetResponse.
    /// </summary>
    public class TmallProductTemplateGetResponse : TopResponse
    {
        /// <summary>
        /// 见SpuTemplateDO说明
        /// </summary>
        [XmlElement("template")]
        public SpuTemplateDO Template { get; set; }
    }
}
