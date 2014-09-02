using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaXiamiApiContractSellerlistGetResponse.
    /// </summary>
    public class AlibabaXiamiApiContractSellerlistGetResponse : TopResponse
    {
        /// <summary>
        /// 卖家销售详情和总条数
        /// </summary>
        [XmlElement("data")]
        public XiamiSellerlist Data { get; set; }
    }
}
