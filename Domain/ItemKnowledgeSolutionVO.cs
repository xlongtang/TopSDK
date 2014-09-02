using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemKnowledgeSolutionVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemKnowledgeSolutionVO : TopObject
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 宝贝ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 自定义的问题
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        [XmlElement("solution")]
        public string Solution { get; set; }

        /// <summary>
        /// 发送状态 1半自动 2全自动
        /// </summary>
        [XmlElement("solution_level")]
        public long SolutionLevel { get; set; }

        /// <summary>
        /// stf 旺旺富文本格式的解决方案
        /// </summary>
        [XmlElement("solution_stf")]
        public string SolutionStf { get; set; }

        /// <summary>
        /// 关联 athena_item_knowledge_type 表的 type_key字段
        /// </summary>
        [XmlElement("type_key")]
        public string TypeKey { get; set; }

        /// <summary>
        /// 主账号
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
