using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.user.accountreport.get
    /// </summary>
    public class AlipayUserAccountreportGetRequest : ITopRequest<AlipayUserAccountreportGetResponse>
    {
        /// <summary>
        /// 对账单结束时间，其中end_time - start_time <= 1个自然月，对于对账记录比较多的情况，强烈建议按天查询，否则会出现超时的情况。
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 需要返回的字段列表。create_time:创建时间,type：账务类型,business_type:子业务类型,balance:当时支付宝账户余额,in_amount:收入金额,out_amount:支出金额,alipay_order_no:支付宝订单号,merchant_order_no:商户订单号,self_user_id:自己的支付宝ID,opt_user_id:对方的支付宝ID,memo:账号备注
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 要获取的对账单页码<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每次查询获取对账记录数量<br /> 支持最大值为：200<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 对账单开始时间。最近一个月内的日期。
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 账务类型。多个类型是，用逗号分隔，不传则查询所有类型的。PAYMENT:在线支付，TRANSFER:转账，DEPOSIT:充值，WITHDRAW:提现，CHARGE:收费，PREAUTH:预授权，OTHER：其它。
        /// </summary>
        public string Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.user.accountreport.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 200);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
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
