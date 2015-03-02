using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillProductTypeRequest Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillProductTypeRequest : TopObject
    {
        /// <summary>
        /// 物流商编码CODE
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }
    }
}
