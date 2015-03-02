using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemSizemappingTemplateCreateResponse.
    /// </summary>
    public class TmallItemSizemappingTemplateCreateResponse : TopResponse
    {
        /// <summary>
        /// 尺码表模板
        /// </summary>
        [XmlElement("size_mapping_template")]
        public SizeMappingTemplate SizeMappingTemplate { get; set; }
    }
}
