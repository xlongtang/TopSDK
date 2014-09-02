using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topats.trades.sold.get
    /// </summary>
    public class TopatsTradesSoldGetRequest : ITopRequest<TopatsTradesSoldGetResponse>
    {
        /// <summary>
        /// 订单创建结束时间，格式yyyyMMdd，取值范围：前90天内~昨天，其中start_time<=end_time，如20120531相当于取订单创建时间到2012-05-31 23:59:59为止的订单。注：如果start_time和end_time相同，表示取一天的订单数据。<span style="color:red">强烈建议超大卖家（直充类，金冠类）把三个月订单拆分成3次来获取，否则单个任务会消耗很长时间。<span>
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// Trade和Order结构体中的所有字段。<span style="color:red">请尽量按需获取，如果只取tid字段，获取订单数据速度会超快。</span>
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 默认值为false，表示按正常方式查询订单；如果设置为true则查询到的是模糊后的订单列表，可通过模糊订单列表中的buyer_nick/buyer_id字段与流量数据进行关联。如果没有使用流量数据接口请忽略本字段。
        /// </summary>
        public Nullable<bool> IsAcookie { get; set; }

        /// <summary>
        /// 订单创建开始时间，格式yyyyMMdd，取值范围：前90天内~昨天。如：20120501相当于取订单创建时间从2012-05-01 00:00:00开始的订单。
        /// </summary>
        public string StartTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.topats.trades.sold.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("is_acookie", this.IsAcookie);
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
