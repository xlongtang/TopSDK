using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topats.refunds.receive.get
    /// </summary>
    public class TopatsRefundsReceiveGetRequest : ITopRequest<TopatsRefundsReceiveGetResponse>
    {
        /// <summary>
        /// 退款修改结束时间，格式yyyyMMdd，取值范围：前90天内~昨天，其中start_time<=end_time，如20120531相当于取退款修改时间到2012-05-31 23:59:59为止的退款。注：如果start_time和end_time相同，表示取一天的退款数据。<span style="color:red">强烈建议直充类卖家把三个月退款拆分成3次来获取，否则单个任务会消耗很长时间。<span>
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// Refund结构体中的所有字段。<span style="color:red">请尽量按需获取，如果只取refund_id和modified字段，获取退款数据速度会超快。</span>
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 退款修改开始时间，格式yyyyMMdd，取值范围：前90天内~昨天。如：20120501相当于取退款修改时间从2012-05-01 00:00:00开始的退款。
        /// </summary>
        public string StartTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.topats.refunds.receive.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("start_time", this.StartTime);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
    }
}
