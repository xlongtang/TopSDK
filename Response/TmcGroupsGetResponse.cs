using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmcGroupsGetResponse.
    /// </summary>
    public class TmcGroupsGetResponse : TopResponse
    {
        /// <summary>
        /// 分组列表
        /// </summary>
        [XmlArray("groups")]
        [XmlArrayItem("tmc_group")]
        public List<TmcGroup> Groups { get; set; }

        /// <summary>
        /// 分组总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
