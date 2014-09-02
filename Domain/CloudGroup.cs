using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CloudGroup Data Structure.
    /// </summary>
    [Serializable]
    public class CloudGroup : TopObject
    {
        /// <summary>
        /// 分组描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 分组表达式
        /// </summary>
        [XmlElement("expression")]
        public string Expression { get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 分组名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分组状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
