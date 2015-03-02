using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemSizemappingTemplateDeleteResponse.
    /// </summary>
    public class TmallItemSizemappingTemplateDeleteResponse : TopResponse
    {
        /// <summary>
        /// 尺码表模板ID
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }
    }
}
