using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.rebate.report.get
    /// </summary>
    public class TaobaokeRebateReportGetRequest : ITopRequest<TaobaokeRebateReportGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表.可选值:TaobaokePayment淘宝客订单构体中的所有字段;字段之间用","分隔.
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页返回结果数，最小每页40条，默认每页40条，最大每页100条
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询报表的时间跨度，单位秒。  以用户输入的start_time时间为起始时间，start_time+span为结束时间，查询该时间段内的订单。span最小值为60秒，最大值为600秒，默认值为60秒
        /// </summary>
        public Nullable<long> Span { get; set; }

        /// <summary>
        /// 需要查询报表的开始日期，有效的日期为从当前日期开始起90天以内的订单
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.rebate.report.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("span", this.Span);
            parameters.Add("start_time", this.StartTime);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxValue("page_no", this.PageNo, 100);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateRequired("span", this.Span);
            RequestValidator.ValidateMaxValue("span", this.Span, 600);
            RequestValidator.ValidateMinValue("span", this.Span, 60);
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
