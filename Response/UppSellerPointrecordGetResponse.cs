using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// UppSellerPointrecordGetResponse.
    /// </summary>
    public class UppSellerPointrecordGetResponse : TopResponse
    {
        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 卖家积分明细记录列表
        /// </summary>
        [XmlArray("seller_point_record_list")]
        [XmlArrayItem("seller_point_record_module")]
        public List<SellerPointRecordModule> SellerPointRecordList { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
