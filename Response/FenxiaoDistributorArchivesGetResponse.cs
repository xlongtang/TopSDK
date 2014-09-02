using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoDistributorArchivesGetResponse.
    /// </summary>
    public class FenxiaoDistributorArchivesGetResponse : TopResponse
    {
        /// <summary>
        /// 分销商档案
        /// </summary>
        [XmlElement("distributor_archive")]
        public DistributorArchive DistributorArchive { get; set; }

        /// <summary>
        /// 接口执行结果，true表示执行成功；false表示执行失败。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
