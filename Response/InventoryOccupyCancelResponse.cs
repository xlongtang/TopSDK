using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// InventoryOccupyCancelResponse.
    /// </summary>
    public class InventoryOccupyCancelResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
