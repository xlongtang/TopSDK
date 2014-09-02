using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// InventoryAdjustTradeResponse.
    /// </summary>
    public class InventoryAdjustTradeResponse : TopResponse
    {
        /// <summary>
        /// 操作返回码
        /// </summary>
        [XmlElement("operate_code")]
        public string OperateCode { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlArray("tip_infos")]
        [XmlArrayItem("tip_info")]
        public List<TipInfo> TipInfos { get; set; }
    }
}
