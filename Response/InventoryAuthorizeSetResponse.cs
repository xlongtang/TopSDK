using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// InventoryAuthorizeSetResponse.
    /// </summary>
    public class InventoryAuthorizeSetResponse : TopResponse
    {
        /// <summary>
        /// 授权结果
        /// </summary>
        [XmlArray("authorize_results")]
        [XmlArrayItem("inventory_authorize_info")]
        public List<InventoryAuthorizeInfo> AuthorizeResults { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlArray("tip_infos")]
        [XmlArrayItem("tip_info")]
        public List<TipInfo> TipInfos { get; set; }
    }
}
