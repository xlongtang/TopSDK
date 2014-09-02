using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// LogisticsTraceSearchResponse.
    /// </summary>
    public class LogisticsTraceSearchResponse : TopResponse
    {
        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("out_sid")]
        public string OutSid { get; set; }

        /// <summary>
        /// 订单的物流状态（仅支持线上发货online订单，线下发货offline发出后直接变为已签收） * 等候发送给物流公司 *已提交给物流公司,等待物流公司接单 *已经确认消息接收，等待物流公司接单 *物流公司已接单 *物流公司不接单 *物流公司揽收失败 *物流公司揽收成功 *签收失败 *对方已签收 *对方拒绝签收
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }

        /// <summary>
        /// 流转信息列表
        /// </summary>
        [XmlArray("trace_list")]
        [XmlArrayItem("transit_step_info")]
        public List<TransitStepInfo> TraceList { get; set; }
    }
}
