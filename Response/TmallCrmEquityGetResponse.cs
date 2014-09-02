using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallCrmEquityGetResponse.
    /// </summary>
    public class TmallCrmEquityGetResponse : TopResponse
    {
        /// <summary>
        /// 天猫卖家设置的等级权益
        /// </summary>
        [XmlArray("grade_equitys")]
        [XmlArrayItem("grade_equity")]
        public List<GradeEquity> GradeEquitys { get; set; }
    }
}
