using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemPriceUpdateResponse.
    /// </summary>
    public class TmallItemPriceUpdateResponse : TopResponse
    {
        /// <summary>
        /// 价格更新结果
        /// </summary>
        [XmlElement("price_update_result")]
        public string PriceUpdateResult { get; set; }
    }
}
