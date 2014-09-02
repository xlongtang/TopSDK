using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiActionGetListResponse.
    /// </summary>
    public class HanoiActionGetListResponse : TopResponse
    {
        /// <summary>
        /// 动作的列表
        /// </summary>
        [XmlArray("hanoiactions")]
        [XmlArrayItem("action_info")]
        public List<ActionInfo> Hanoiactions { get; set; }

        /// <summary>
        /// 满足条件的记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
