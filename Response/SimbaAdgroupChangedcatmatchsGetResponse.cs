using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupChangedcatmatchsGetResponse.
    /// </summary>
    public class SimbaAdgroupChangedcatmatchsGetResponse : TopResponse
    {
        /// <summary>
        /// 一页类目出价对象
        /// </summary>
        [XmlElement("changed_catmatchs")]
        public ADGroupCatMatchPage ChangedCatmatchs { get; set; }
    }
}
