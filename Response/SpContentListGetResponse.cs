using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentListGetResponse.
    /// </summary>
    public class SpContentListGetResponse : TopResponse
    {
        /// <summary>
        /// 内容列表
        /// </summary>
        [XmlArray("contents")]
        [XmlArrayItem("sp_content_d_o_for_list")]
        public List<SpContentDOForList> Contents { get; set; }

        /// <summary>
        /// 符合条件的总记录数
        /// </summary>
        [XmlElement("total_result")]
        public long TotalResult { get; set; }
    }
}
