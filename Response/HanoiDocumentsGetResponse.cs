using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiDocumentsGetResponse.
    /// </summary>
    public class HanoiDocumentsGetResponse : TopResponse
    {
        /// <summary>
        /// 分页信息
        /// </summary>
        [XmlElement("page_result")]
        public PageResult PageResult { get; set; }

        /// <summary>
        /// 档案列表
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("document_v_o")]
        public List<DocumentVO> Values { get; set; }
    }
}
