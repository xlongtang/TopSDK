using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoGradesGetResponse.
    /// </summary>
    public class FenxiaoGradesGetResponse : TopResponse
    {
        /// <summary>
        /// 分销商等级信息
        /// </summary>
        [XmlArray("fenxiao_grades")]
        [XmlArrayItem("fenxiao_grade")]
        public List<FenxiaoGrade> FenxiaoGrades { get; set; }

        /// <summary>
        /// 记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
