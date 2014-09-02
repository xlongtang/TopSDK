using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Function Data Structure.
    /// </summary>
    [Serializable]
    public class Function : TopObject
    {
        /// <summary>
        /// 规则创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 函数配置id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 函数配置名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 规则解析类型 0：JSON 1：规则表达式
        /// </summary>
        [XmlElement("parse_type")]
        public long ParseType { get; set; }

        /// <summary>
        /// 规则表达式
        /// </summary>
        [XmlElement("rule")]
        public string Rule { get; set; }

        /// <summary>
        /// 0：审核中 1：审核通过，正常，-1：删除
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 规则开放策略 0：user_id私有 1：全部开放 2：同一创建者下的user_id拥有
        /// </summary>
        [XmlElement("strategy")]
        public long Strategy { get; set; }

        /// <summary>
        /// 规则拥有者
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
