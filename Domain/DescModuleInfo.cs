using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DescModuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DescModuleInfo : TopObject
    {
        /// <summary>
        /// 代表宝贝描述中规范化打标使用到的模块id列表，以逗号分隔。
        /// </summary>
        [XmlElement("anchor_module_ids")]
        public string AnchorModuleIds { get; set; }

        /// <summary>
        /// 类型代表规范化打标的类型：人工或自动化
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
