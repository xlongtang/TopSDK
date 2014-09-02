using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoOrderCreateDealerResponse.
    /// </summary>
    public class FenxiaoOrderCreateDealerResponse : TopResponse
    {
        /// <summary>
        /// 采购单号
        /// </summary>
        [XmlElement("get_module")]
        public long GetModule { get; set; }
    }
}
