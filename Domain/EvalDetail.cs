using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// EvalDetail Data Structure.
    /// </summary>
    [Serializable]
    public class EvalDetail : TopObject
    {
        /// <summary>
        /// 评价详细：  1 非常满意  2 满意  3 一般  4 不满意
        /// </summary>
        [XmlElement("eval_code")]
        public long EvalCode { get; set; }

        /// <summary>
        /// 评价接收者
        /// </summary>
        [XmlElement("eval_recer")]
        public string EvalRecer { get; set; }

        /// <summary>
        /// 评价发送者
        /// </summary>
        [XmlElement("eval_sender")]
        public string EvalSender { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("eval_time")]
        public string EvalTime { get; set; }

        /// <summary>
        /// 评价发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }
    }
}
