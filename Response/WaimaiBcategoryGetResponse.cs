using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiBcategoryGetResponse.
    /// </summary>
    public class WaimaiBcategoryGetResponse : TopResponse
    {
        /// <summary>
        /// 类目对象集合
        /// </summary>
        [XmlElement("result")]
        public CategoryResult Result { get; set; }
    }
}
