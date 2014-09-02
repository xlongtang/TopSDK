using System;
using System.Xml.Serialization;
using Top.Api;
using System.Collections.Generic;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// VRouter Data Structure.
    /// </summary>
    [Serializable]
    public class VRouter : TopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("CreationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 虚拟路由描述
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// regionId
        /// </summary>
        [XmlElement("RegionId")]
        public string RegionId { get; set; }

        /// <summary>
        /// 路由表ID集合
        /// </summary>
        [XmlArray("RouteTableIds")]
        [XmlArrayItem("String")]
        public List<string> RouteTableIds { get; set; }

        /// <summary>
        /// 虚拟路由ID
        /// </summary>
        [XmlElement("VRouterId")]
        public string VRouterId { get; set; }

        /// <summary>
        /// 虚拟路由名称
        /// </summary>
        [XmlElement("VRouterName")]
        public string VRouterName { get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [XmlElement("VpcId")]
        public string VpcId { get; set; }
    }
}
