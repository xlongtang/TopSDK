using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CheckToolModule Data Structure.
    /// </summary>
    [Serializable]
    public class CheckToolModule : TopObject
    {
        /// <summary>
        /// 工具审核的URL，工具检测通过后，ISV需要把该URL和工具基本信息一起提交UMP工具技术审核。
        /// </summary>
        [XmlElement("check_url")]
        public string CheckUrl { get; set; }

        /// <summary>
        /// 工具检测结果中的错误信息。
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 工具是否检测通过。
        /// </summary>
        [XmlElement("is_pass")]
        public string IsPass { get; set; }

        /// <summary>
        /// 工具中已经使用的元数据。
        /// </summary>
        [XmlElement("meta_def")]
        public string MetaDef { get; set; }
    }
}
