using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// InventoryStoreQueryResponse.
    /// </summary>
    public class InventoryStoreQueryResponse : TopResponse
    {
        /// <summary>
        /// 仓库列表
        /// </summary>
        [XmlArray("store_list")]
        [XmlArrayItem("store")]
        public List<Store> StoreList { get; set; }
    }
}
