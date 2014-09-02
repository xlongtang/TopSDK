using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiDatatemplateDetailQueryResponse.
    /// </summary>
    public class HanoiDatatemplateDetailQueryResponse : TopResponse
    {
        /// <summary>
        /// 如果查询时需要分页，则返回分页的信息
        /// </summary>
        [XmlElement("page_result")]
        public PageResult PageResult { get; set; }

        /// <summary>
        /// 返回的是Detail详情列表：<br/>  paramsMap:创建数据模板时，填入PK的值<br/>  attr:AttributeVO的json格式<br/>  dataTemplateId:数据模板的唯一标识<br/>  id:数据模板详情的唯一标识<br/>  name:数据模板详情的名称<br/>
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
