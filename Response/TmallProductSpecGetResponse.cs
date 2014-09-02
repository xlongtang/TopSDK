using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductSpecGetResponse.
    /// </summary>
    public class TmallProductSpecGetResponse : TopResponse
    {
        /// <summary>
        /// 返回的产品规格信息，注意，这个产品规格信息可能是等待审核的，不一定可用。根据状态判断1：表示审核通过  3：表示等待审核。
        /// </summary>
        [XmlElement("product_spec")]
        public ProductSpec ProductSpec { get; set; }
    }
}
