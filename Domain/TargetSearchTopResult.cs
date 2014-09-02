using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TargetSearchTopResult Data Structure.
    /// </summary>
    [Serializable]
    public class TargetSearchTopResult : TopObject
    {
        /// <summary>
        /// 查询的指标名称
        /// </summary>
        [XmlElement("field")]
        public string Field { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 所查询的指标数据的结果
        /// </summary>
        [XmlElement("result_data")]
        public string ResultData { get; set; }

        /// <summary>
        /// 分页的数据总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
