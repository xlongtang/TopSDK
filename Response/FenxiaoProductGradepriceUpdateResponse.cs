using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoProductGradepriceUpdateResponse.
    /// </summary>
    public class FenxiaoProductGradepriceUpdateResponse : TopResponse
    {
        /// <summary>
        /// 返回操作结果：成功或失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
