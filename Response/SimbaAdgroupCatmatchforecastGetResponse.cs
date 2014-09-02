using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupCatmatchforecastGetResponse.
    /// </summary>
    public class SimbaAdgroupCatmatchforecastGetResponse : TopResponse
    {
        /// <summary>
        /// 类目出价预估结果信息 预测数据皆为估算结果，以实际发生为准
        /// </summary>
        [XmlElement("adgroup_catmatch_forecast")]
        public ADGroupCatMatchForecast AdgroupCatmatchForecast { get; set; }
    }
}
