using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.eai.order.register
    /// </summary>
    public class TmallEaiOrderRegisterRequest : ITopRequest<TmallEaiOrderRegisterResponse>
    {
        /// <summary>
        /// 对传入的事件的操作类型 0:取消订阅;1:订阅
        /// </summary>
        public Nullable<long> Action { get; set; }

        /// <summary>
        /// 1:主订单模式;  2:子订单模式;  天猫退款消息订阅默认子订单模式。  不传入即可。<br /> 支持的最大列表长度为：50
        /// </summary>
        public Nullable<long> DataMode { get; set; }

        /// <summary>
        /// 需要订阅或者取消订阅的事件名称。  可选择的值如下所示:  RcRefundClosedEvent;  RcRefundPrepaidEvent;  RcReturnCreatedEvent;  RcRefundSucceedEvent;  RcRefundCreatedEvent;  RcRefundModifiedEvent;  RcReturnModifiedEvent;  RcRefundSellerRefuseEvent;  RcReturnConfirmFailedEvent;  RcRefundTaobaoInvolvedEvent;  RcRefundMessageCreatedEvent;  RcReturnConfirmSucceedEvent;  RcRefundPaymentFinishedEvent;  RcRefundRefundableMarkedEvent;  RcReturnBuyerReturnGoodsEvent;  RcRefundSellerAgreeReturnEvent;  RcRefundRefundableCanceledEvent;<br /> 支持最大长度为：50<br /> 支持的最大列表长度为：50
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// 天猫退款订单可选topic:  tmall.eai.order.refund.refundBill.push;  tmall.eai.order.refund.refundStatus.push
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// 标识出用户类型。  这里“用户”指的是外部开发者。  0:TOP-OPEN-API 用户  1:JIP用户
        /// </summary>
        public Nullable<long> UserType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.eai.order.register";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("action", this.Action);
            parameters.Add("data_mode", this.DataMode);
            parameters.Add("event_name", this.EventName);
            parameters.Add("topic", this.Topic);
            parameters.Add("user_type", this.UserType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("action", this.Action);
            RequestValidator.ValidateRequired("event_name", this.EventName);
            RequestValidator.ValidateMaxLength("event_name", this.EventName, 50);
            RequestValidator.ValidateRequired("topic", this.Topic);
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
