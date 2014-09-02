using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoDistributorItemsGetResponse.
    /// </summary>
    public class FenxiaoDistributorItemsGetResponse : TopResponse
    {
        /// <summary>
        /// 下载记录对象
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("fenxiao_item_record")]
        public List<FenxiaoItemRecord> Records { get; set; }

        /// <summary>
        /// 查询结果记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
