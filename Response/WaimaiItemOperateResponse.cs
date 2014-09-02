using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiItemOperateResponse.
    /// </summary>
    public class WaimaiItemOperateResponse : TopResponse
    {
        /// <summary>
        /// 批量操作结果
        /// </summary>
        [XmlElement("batch_operate_result")]
        public BatchOperateResult BatchOperateResult { get; set; }
    }
}
