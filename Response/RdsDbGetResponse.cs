using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// RdsDbGetResponse.
    /// </summary>
    public class RdsDbGetResponse : TopResponse
    {
        /// <summary>
        /// 数据库查询返回数据结构
        /// </summary>
        [XmlArray("rds_db_infos")]
        [XmlArrayItem("rds_db_info")]
        public List<RdsDbInfo> RdsDbInfos { get; set; }
    }
}
