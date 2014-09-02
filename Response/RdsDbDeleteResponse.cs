using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// RdsDbDeleteResponse.
    /// </summary>
    public class RdsDbDeleteResponse : TopResponse
    {
        /// <summary>
        /// 删除数据库，返回结果对象
        /// </summary>
        [XmlElement("rds_db_info")]
        public RdsDbInfo RdsDbInfo { get; set; }
    }
}
