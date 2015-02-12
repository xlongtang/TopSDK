using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillApplySubscriptionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillApplySubscriptionInfo : TopObject
    {
        /// <summary>
        /// CP网点信息及对应的商家的发货信息
        /// </summary>
        [XmlArray("branch_account_cols")]
        [XmlArrayItem("waybill_branch_account")]
        public List<WaybillBranchAccount> BranchAccountCols { get; set; }

        /// <summary>
        /// 物流服务商ID
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }

        /// <summary>
        /// 1是直营，2是加盟
        /// </summary>
        [XmlElement("cp_type")]
        public long CpType { get; set; }

        /// <summary>
        /// 订购关系是否建立
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }
    }
}
