using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// InsightCategoryInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsightCategoryInfoDTO : TopObject
    {
        /// <summary>
        /// 类目Id
        /// </summary>
        [XmlElement("cat_id")]
        public long CatId { get; set; }

        /// <summary>
        /// 类目的级别
        /// </summary>
        [XmlElement("cat_level")]
        public long CatLevel { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("cat_name")]
        public string CatName { get; set; }

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
        /// 表示类目信息上次同步的时间
        /// </summary>
        [XmlElement("last_sync_time")]
        public string LastSyncTime { get; set; }

        /// <summary>
        /// 父类目Id
        /// </summary>
        [XmlElement("parent_cat_id")]
        public long ParentCatId { get; set; }
    }
}
