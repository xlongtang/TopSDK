using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceEvalsGetResponse.
    /// </summary>
    public class WangwangEserviceEvalsGetResponse : TopResponse
    {
        /// <summary>
        /// 0表示成功
        /// </summary>
        [XmlElement("result_code")]
        public long ResultCode { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("result_count")]
        public long ResultCount { get; set; }

        /// <summary>
        /// 评价具体数据
        /// </summary>
        [XmlArray("staff_eval_details")]
        [XmlArrayItem("eval_detail")]
        public List<EvalDetail> StaffEvalDetails { get; set; }
    }
}
