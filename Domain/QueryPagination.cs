using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// QueryPagination Data Structure.
    /// </summary>
    [Serializable]
    public class QueryPagination : TopObject
    {
        /// <summary>
        /// 当前页码数
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页记录个数，如果用户输入的记录数大于50，则一页显示50条记录
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
