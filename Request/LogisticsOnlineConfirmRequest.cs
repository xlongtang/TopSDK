using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.online.confirm
    /// </summary>
    public class LogisticsOnlineConfirmRequest : ITopRequest<LogisticsOnlineConfirmResponse>
    {
        /// <summary>
        /// 表明是否是拆单，默认值0，1表示拆单
        /// </summary>
        public Nullable<long> IsSplit { get; set; }

        /// <summary>
        /// 运单号.具体一个物流公司的真实运单号码。淘宝官方物流会校验，请谨慎传入；若company_code中传入的代码非淘宝官方物流合作公司，此处运单号不校验。<br>
        /// </summary>
        public string OutSid { get; set; }

        /// <summary>
        /// 商家的IP地址
        /// </summary>
        public string SellerIp { get; set; }

        /// <summary>
        /// 拆单子订单列表，对应的数据是：子订单号的列表。可以不传，但是如果传了则必须符合传递的规则。子订单必须是操作的物流订单的子订单的真子集！
        /// </summary>
        public string SubTid { get; set; }

        /// <summary>
        /// 淘宝交易ID
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.online.confirm";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_split", this.IsSplit);
            parameters.Add("out_sid", this.OutSid);
            parameters.Add("seller_ip", this.SellerIp);
            parameters.Add("sub_tid", this.SubTid);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("out_sid", this.OutSid);
            RequestValidator.ValidateMaxListSize("sub_tid", this.SubTid, 50);
            RequestValidator.ValidateRequired("tid", this.Tid);
            RequestValidator.ValidateMinValue("tid", this.Tid, 1000);
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
