using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// RdsDbCreateResponse.
    /// </summary>
    public class RdsDbCreateResponse : TopResponse
    {
        /// <summary>
        /// rds创建、查询、删除db返回结果的数据结构
        /// </summary>
        [XmlElement("rds_db_info")]
        public RdsDbInfo RdsDbInfo { get; set; }
    }
}
