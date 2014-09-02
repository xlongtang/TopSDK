using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TradePostageUpdateResponse.
    /// </summary>
    public class TradePostageUpdateResponse : TopResponse
    {
        /// <summary>
        /// 返回trade类型，其中包含修改时间modified，修改邮费post_fee，修改后的总费用total_fee和买家实付款payment
        /// </summary>
        [XmlElement("trade")]
        public Trade Trade { get; set; }
    }
}
