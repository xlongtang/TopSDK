using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// CategoryResult Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryResult : TopObject
    {
        /// <summary>
        /// 类目列表集合
        /// </summary>
        [XmlArray("categorylist")]
        [XmlArrayItem("root_category")]
        public List<RootCategory> Categorylist { get; set; }
    }
}
