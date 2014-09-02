using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptCusteffectGetResponse.
    /// </summary>
    public class SimbaRptCusteffectGetResponse : TopResponse
    {
        /// <summary>
        /// 账户效果数据返回结果
        /// </summary>
        [XmlElement("rpt_cust_effect_list")]
        public string RptCustEffectList { get; set; }
    }
}
