using System;
using System.Xml.Serialization;
using Top.Api;
using System.Collections.Generic;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// RouteTable Data Structure.
    /// </summary>
    [Serializable]
    public class RouteTable : TopObject
    {
        /// <summary>
        /// 创建时间。按照ISO8601标准表示，并需要使用UTC时间。格式为：  YYYY-MM-DDThh:mmZ
        /// </summary>
        [XmlElement("CreationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 路由条目
        /// </summary>
        [XmlArray("RouteEntrys")]
        [XmlArrayItem("RouteEntry")]
        public List<RouteEntry> RouteEntrys { get; set; }

        /// <summary>
        /// 路由表的ID
        /// </summary>
        [XmlElement("RouteTableId")]
        public string RouteTableId { get; set; }

        /// <summary>
        /// 路由表类型，System | Custom 二者选其一
        /// </summary>
        [XmlElement("RouteTableType")]
        public string RouteTableType { get; set; }

        /// <summary>
        /// 虚拟路由器的ID
        /// </summary>
        [XmlElement("VRouterId")]
        public string VRouterId { get; set; }
    }
}
