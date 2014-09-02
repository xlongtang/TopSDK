using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SubusersGetResponse.
    /// </summary>
    public class SubusersGetResponse : TopResponse
    {
        /// <summary>
        /// 子账号基本信息
        /// </summary>
        [XmlArray("subaccounts")]
        [XmlArrayItem("sub_account_info")]
        public List<SubAccountInfo> Subaccounts { get; set; }
    }
}
