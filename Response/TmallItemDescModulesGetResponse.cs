using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemDescModulesGetResponse.
    /// </summary>
    public class TmallItemDescModulesGetResponse : TopResponse
    {
        /// <summary>
        /// 返回描述模块信息
        /// </summary>
        [XmlElement("modular_desc_info")]
        public ModularDescInfo ModularDescInfo { get; set; }
    }
}
