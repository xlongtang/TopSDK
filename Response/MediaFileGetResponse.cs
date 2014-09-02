using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// MediaFileGetResponse.
    /// </summary>
    public class MediaFileGetResponse : TopResponse
    {
        /// <summary>
        /// 查询分页数据对象
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("file")]
        public List<File> Result { get; set; }

        /// <summary>
        /// 文件总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
