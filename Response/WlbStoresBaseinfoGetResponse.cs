using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbStoresBaseinfoGetResponse.
    /// </summary>
    public class WlbStoresBaseinfoGetResponse : TopResponse
    {
        /// <summary>
        /// 仓库列表
        /// </summary>
        [XmlArray("store_info_list")]
        [XmlArrayItem("store_info")]
        public List<StoreInfo> StoreInfoList { get; set; }

        /// <summary>
        /// 返回的总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
