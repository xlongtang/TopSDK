using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// InventoryStoreManageResponse.
    /// </summary>
    public class InventoryStoreManageResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("store_list")]
        [XmlArrayItem("store")]
        public List<Store> StoreList { get; set; }
    }
}
