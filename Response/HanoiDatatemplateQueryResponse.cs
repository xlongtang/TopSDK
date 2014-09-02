using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiDatatemplateQueryResponse.
    /// </summary>
    public class HanoiDatatemplateQueryResponse : TopResponse
    {
        /// <summary>
        /// 如果查询时需要分页，则返回分页的信息
        /// </summary>
        [XmlElement("page_result")]
        public PageResult PageResult { get; set; }

        /// <summary>
        /// 返回数据模板的列表  id:唯一标识  name:名称  opened:开放策略  owner:创建者  status:状态 1正常 0 未审核
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
