using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trip.jipiao.agent.order.fail
    /// </summary>
    public class TripJipiaoAgentOrderFailRequest : ITopRequest<TripJipiaoAgentOrderFailResponse>
    {
        /// <summary>
        /// 失败类型为0，说明备注原因
        /// </summary>
        public string FailMemo { get; set; }

        /// <summary>
        /// 失败原因：1．客户要求失败订单；2．此舱位已售完（经济舱或特舱）；3．剩余座位少于用户购买数量；4．特价管理里录入的特价票已经售完；5．假舱（请及时通过旺旺或者电话反馈给淘宝工作人员）；0．其它（请在备注中说明原因）
        /// </summary>
        public Nullable<long> FailType { get; set; }

        /// <summary>
        /// 国内机票订单id
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trip.jipiao.agent.order.fail";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fail_memo", this.FailMemo);
            parameters.Add("fail_type", this.FailType);
            parameters.Add("order_id", this.OrderId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("fail_memo", this.FailMemo, 200);
            RequestValidator.ValidateRequired("fail_type", this.FailType);
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
