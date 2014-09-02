using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// InventoryAuthorizeGetallResponse.
    /// </summary>
    public class InventoryAuthorizeGetallResponse : TopResponse
    {
        /// <summary>
        /// 返回的是该商品的授权明细，明细参考  InventoryAuthorizeInfo结构
        /// </summary>
        [XmlArray("authorize_list")]
        [XmlArrayItem("inventory_authorize_info")]
        public List<InventoryAuthorizeInfo> AuthorizeList { get; set; }
    }
}
