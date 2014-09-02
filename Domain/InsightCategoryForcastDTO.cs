using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// InsightCategoryForcastDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsightCategoryForcastDTO : TopObject
    {
        /// <summary>
        /// 查询词
        /// </summary>
        [XmlElement("bidword")]
        public string Bidword { get; set; }

        /// <summary>
        /// 表示该类目的所有父级类目，按层级顺序排列，层级越高的在前面，不同的层级之间用空格分隔
        /// </summary>
        [XmlElement("cat_path_id")]
        public string CatPathId { get; set; }

        /// <summary>
        /// 表示类目的所有父级类目的名称，不同层级之间用（ascii码为2的字符）分隔开
        /// </summary>
        [XmlElement("cat_path_name")]
        public string CatPathName { get; set; }

        /// <summary>
        /// 表示词与该类目的相关度，值越大表示越相关
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
