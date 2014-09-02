using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trip.jipiao.agent.order.special.confirm
    /// </summary>
    public class TripJipiaoAgentOrderSpecialConfirmRequest : ITopRequest<TripJipiaoAgentOrderSpecialConfirmResponse>
    {
        /// <summary>
        /// 能否支付
        /// </summary>
        public Nullable<bool> CanPay { get; set; }

        /// <summary>
        /// can_pay=false,fail_type=0时，必需提供失败原因
        /// </summary>
        public string FailMemo { get; set; }

        /// <summary>
        /// can_pay=false时，必需提供失败原因；失败原因：11,座位已售完;12,座位申请不成功;13,航班价格变动;14,买家要求失败订单;0,其它(必须在备注中说明原因)
        /// </summary>
        public Nullable<long> FailType { get; set; }

        /// <summary>
        /// 国内机票订单id
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// can_pay=true，必需提供最迟支付时间
        /// </summary>
        public Nullable<DateTime> PayLatestTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trip.jipiao.agent.order.special.confirm";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("can_pay", this.CanPay);
            parameters.Add("fail_memo", this.FailMemo);
            parameters.Add("fail_type", this.FailType);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("pay_latest_time", this.PayLatestTime);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("can_pay", this.CanPay);
            RequestValidator.ValidateMaxLength("fail_memo", this.FailMemo, 200);
            RequestValidator.ValidateRequired("order_id", this.OrderId);
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
