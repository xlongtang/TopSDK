using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Evaluation Data Structure.
    /// </summary>
    [Serializable]
    public class Evaluation : TopObject
    {
        /// <summary>
        /// 客服评价内容
        /// </summary>
        [XmlElement("evaluation_name")]
        public string EvaluationName { get; set; }

        /// <summary>
        /// 评价数量
        /// </summary>
        [XmlElement("evaluation_num")]
        public string EvaluationNum { get; set; }
    }
}
