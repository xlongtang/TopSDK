using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiItemlistGetResponse.
    /// </summary>
    public class WaimaiItemlistGetResponse : TopResponse
    {
        /// <summary>
        /// 返回外卖宝贝列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("top_auction")]
        public List<TopAuction> DataList { get; set; }

        /// <summary>
        /// 符合条件的外卖宝贝总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
