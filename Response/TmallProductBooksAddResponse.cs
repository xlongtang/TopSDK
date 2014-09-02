using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductBooksAddResponse.
    /// </summary>
    public class TmallProductBooksAddResponse : TopResponse
    {
        /// <summary>
        /// 请求相应结构
        /// </summary>
        [XmlElement("product_books")]
        public ProductBooks ProductBooks { get; set; }
    }
}
