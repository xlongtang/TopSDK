using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// InventoryQueryResponse.
    /// </summary>
    public class InventoryQueryResponse : TopResponse
    {
        /// <summary>
        /// 商品总体库存信息
        /// </summary>
        [XmlArray("item_inventorys")]
        [XmlArrayItem("inventory_sum")]
        public List<InventorySum> ItemInventorys { get; set; }

        /// <summary>
        /// 提示信息，提示不存在的后端商品
        /// </summary>
        [XmlArray("tip_infos")]
        [XmlArrayItem("tip_info")]
        public List<TipInfo> TipInfos { get; set; }
    }
}
