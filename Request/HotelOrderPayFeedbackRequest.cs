using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.order.pay.feedback
    /// </summary>
    public class HotelOrderPayFeedbackRequest : ITopRequest<HotelOrderPayFeedbackResponse>
    {
        /// <summary>
        /// 失败原因,当result为failed时,此项为必填，最长200个字符
        /// </summary>
        public string FailedReason { get; set; }

        /// <summary>
        /// 指令消息中的messageid,最长128字符
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// 酒店订单id
        /// </summary>
        public Nullable<long> Oid { get; set; }

        /// <summary>
        /// 合作方订单号,最长250个字符
        /// </summary>
        public string OutOid { get; set; }

        /// <summary>
        /// 预订结果   S:成功  F:失败
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 指令消息中的session_id
        /// </summary>
        public Nullable<long> SessionId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.order.pay.feedback";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("failed_reason", this.FailedReason);
            parameters.Add("message_id", this.MessageId);
            parameters.Add("oid", this.Oid);
            parameters.Add("out_oid", this.OutOid);
            parameters.Add("result", this.Result);
            parameters.Add("session_id", this.SessionId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("message_id", this.MessageId);
            RequestValidator.ValidateMinValue("oid", this.Oid, 0);
            RequestValidator.ValidateRequired("out_oid", this.OutOid);
            RequestValidator.ValidateRequired("result", this.Result);
            RequestValidator.ValidateRequired("session_id", this.SessionId);
            RequestValidator.ValidateMinValue("session_id", this.SessionId, 0);
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
