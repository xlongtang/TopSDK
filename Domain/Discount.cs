using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// Discount Data Structure.
    /// </summary>
    [Serializable]
    public class Discount : TopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 折扣详情
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("discount_detail")]
        public List<DiscountDetail> Details { get; set; }

        /// <summary>
        /// 折扣ID
        /// </summary>
        [XmlElement("discount_id")]
        public long DiscountId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 折扣名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
