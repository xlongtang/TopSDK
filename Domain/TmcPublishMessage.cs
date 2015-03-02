using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmcPublishMessage Data Structure.
    /// </summary>
    [Serializable]
    public class TmcPublishMessage : TopObject
    {
        /// <summary>
        /// 消息内容的JSON表述，必须按照topic的定义来填充
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息的扩增属性，用json格式表示
        /// </summary>
        [XmlElement("json_ex_content")]
        public string JsonExContent { get; set; }

        /// <summary>
        /// 直发消息需要传入目标appkey
        /// </summary>
        [XmlElement("target_app_key")]
        public string TargetAppKey { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("topic")]
        public string Topic { get; set; }
    }
}
