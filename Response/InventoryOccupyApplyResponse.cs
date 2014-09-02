using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// InventoryOccupyApplyResponse.
    /// </summary>
    public class InventoryOccupyApplyResponse : TopResponse
    {
        /// <summary>
        /// 操作返回码
        /// </summary>
        [XmlElement("operate_code")]
        public string OperateCode { get; set; }

        /// <summary>
        /// 提示信息,   如果错误为后端商品不存在，存储错误的商品ID   如果错误为库存不足，存储商品的对应库存数   如果为强制最大化占用，存储商品实际占用库存数
        /// </summary>
        [XmlArray("tip_infos")]
        [XmlArrayItem("tip_info")]
        public List<TipInfo> TipInfos { get; set; }
    }
}
