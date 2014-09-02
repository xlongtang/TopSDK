using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.eai.base.gateway.register
    /// </summary>
    public class TmallEaiBaseGatewayRegisterRequest : ITopRequest<TmallEaiBaseGatewayRegisterResponse>
    {
        /// <summary>
        /// 用户应用的回调URL,若是普通OPEN-API用户(user_type=0)这个字段可以不填。但是若是JIP用户注册，也就是(user_type=1)时,则此字段必填。否则调用不会成功。
        /// </summary>
        public string CallBackUrl { get; set; }

        /// <summary>
        /// 字符集编码GBK,UTF-8默认,GB2312
        /// </summary>
        public string CharSet { get; set; }

        /// <summary>
        /// 用户所在的城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 数据格式:XML,JSON。  默认:JSON
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// 接入方式描述，为了更好的方便我们为您服务请务必详细描述下您的APP情况。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 用户所在区域
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// 用户的联系邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 暂时还没有支持
        /// </summary>
        public Nullable<long> MaxFlow { get; set; }

        /// <summary>
        /// 用户手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 用户通知接收方式,邮件,电话或者其他。  email:邮件;  message:短信;  aliwangwang:阿里旺旺弹出消息。
        /// </summary>
        public string NotifyType { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string Principal { get; set; }

        /// <summary>
        /// 用户联系电话-座机
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// 接口/api名称:  天猫退款消息可选值为:  tmall.eai.order.refund.refundBill.push  tmall.eai.order.refund.refundStatus.push
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Topic组.暂时还不能支持.
        /// </summary>
        public string TopicGroup { get; set; }

        /// <summary>
        /// url协议  HTTP默认
        /// </summary>
        public string UrlProtocal { get; set; }

        /// <summary>
        /// 0:普通TOP-OPEN-API用户;  1:JIP用户。
        /// </summary>
        public Nullable<long> UserType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.eai.base.gateway.register";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("call_back_url", this.CallBackUrl);
            parameters.Add("char_set", this.CharSet);
            parameters.Add("city", this.City);
            parameters.Add("content_type", this.ContentType);
            parameters.Add("description", this.Description);
            parameters.Add("district", this.District);
            parameters.Add("email", this.Email);
            parameters.Add("max_flow", this.MaxFlow);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("notify_type", this.NotifyType);
            parameters.Add("principal", this.Principal);
            parameters.Add("telephone", this.Telephone);
            parameters.Add("topic", this.Topic);
            parameters.Add("topic_group", this.TopicGroup);
            parameters.Add("url_protocal", this.UrlProtocal);
            parameters.Add("user_type", this.UserType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("call_back_url", this.CallBackUrl);
            RequestValidator.ValidateRequired("city", this.City);
            RequestValidator.ValidateRequired("description", this.Description);
            RequestValidator.ValidateRequired("email", this.Email);
            RequestValidator.ValidateRequired("mobile", this.Mobile);
            RequestValidator.ValidateRequired("principal", this.Principal);
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
