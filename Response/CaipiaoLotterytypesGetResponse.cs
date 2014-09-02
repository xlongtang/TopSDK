using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CaipiaoLotterytypesGetResponse.
    /// </summary>
    public class CaipiaoLotterytypesGetResponse : TopResponse
    {
        /// <summary>
        /// 彩种的数据结构
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("lottery_type")]
        public List<LotteryType> Results { get; set; }

        /// <summary>
        /// 彩种个数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
