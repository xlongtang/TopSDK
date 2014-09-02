using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// GroupData Data Structure.
    /// </summary>
    [Serializable]
    public class GroupData : TopObject
    {
        /// <summary>
        /// 团结束时间
        /// </summary>
        [XmlElement("group_end_time")]
        public string GroupEndTime { get; set; }

        /// <summary>
        /// 组id，唯一标识一个聚划算的组
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 组的名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 团开始时间
        /// </summary>
        [XmlElement("group_start_time")]
        public string GroupStartTime { get; set; }

        /// <summary>
        /// 聚划算商品对象列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_data")]
        public List<ItemData> ItemList { get; set; }

        /// <summary>
        /// 该组是否在聚划算平台显示
        /// </summary>
        [XmlElement("ju_view")]
        public bool JuView { get; set; }

        /// <summary>
        /// 商品组所对应的平台id，1001=聚划算
        /// </summary>
        [XmlElement("platform_id")]
        public long PlatformId { get; set; }
    }
}
