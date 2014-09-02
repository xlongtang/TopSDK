using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiCategoryOperateResponse.
    /// </summary>
    public class WaimaiCategoryOperateResponse : TopResponse
    {
        /// <summary>
        /// 是一个JSON
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
