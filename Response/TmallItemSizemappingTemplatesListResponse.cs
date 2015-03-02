using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemSizemappingTemplatesListResponse.
    /// </summary>
    public class TmallItemSizemappingTemplatesListResponse : TopResponse
    {
        /// <summary>
        /// 尺码表模板列表
        /// </summary>
        [XmlArray("size_mapping_templates")]
        [XmlArrayItem("size_mapping_template")]
        public List<SizeMappingTemplate> SizeMappingTemplates { get; set; }
    }
}
