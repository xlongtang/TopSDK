using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SubuserFullinfoGetResponse.
    /// </summary>
    public class SubuserFullinfoGetResponse : TopResponse
    {
        /// <summary>
        /// 子账号详细信息，其中包括账号基本信息、员工信息和部门职务信息
        /// </summary>
        [XmlElement("sub_fullinfo")]
        public SubUserFullInfo SubFullinfo { get; set; }
    }
}
