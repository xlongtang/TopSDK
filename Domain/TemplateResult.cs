using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TemplateResult Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateResult : TopObject
    {
        /// <summary>
        /// 操作失败时的错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 分页查询时，记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
