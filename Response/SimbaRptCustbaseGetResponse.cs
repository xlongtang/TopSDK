using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptCustbaseGetResponse.
    /// </summary>
    public class SimbaRptCustbaseGetResponse : TopResponse
    {
        /// <summary>
        /// 用户帐户结果
        /// </summary>
        [XmlElement("rpt_cust_base_list")]
        public string RptCustBaseList { get; set; }
    }
}
