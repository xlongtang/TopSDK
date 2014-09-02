using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// IncrementCustomersGetResponse.
    /// </summary>
    public class IncrementCustomersGetResponse : TopResponse
    {
        /// <summary>
        /// 查询到的用户开通信息
        /// </summary>
        [XmlArray("app_customers")]
        [XmlArrayItem("app_customer")]
        public List<AppCustomer> AppCustomers { get; set; }

        /// <summary>
        /// 查询到的开通增量服务的用户数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
