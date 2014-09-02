using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiItemUpdateResponse.
    /// </summary>
    public class WaimaiItemUpdateResponse : TopResponse
    {
        /// <summary>
        /// 返回新增成功的宝贝id
        /// </summary>
        [XmlElement("result")]
        public CreateResult Result { get; set; }
    }
}
