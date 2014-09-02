using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.data.bill.downloadurl.get
    /// </summary>
    public class AlipayDataBillDownloadurlGetRequest : ITopRequest<AlipayDataBillDownloadurlGetResponse>
    {
        /// <summary>
        /// 支付宝给用户的授权。如果没有top的授权，这个字段是必填项
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// 账单时间：日账单格式为yyyy-MM-dd,月账单格式为yyyy-MM
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 账单类型，目前支持的类型有：air
        /// </summary>
        public string BillType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.data.bill.downloadurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auth_token", this.AuthToken);
            parameters.Add("bill_date", this.BillDate);
            parameters.Add("bill_type", this.BillType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bill_date", this.BillDate);
            RequestValidator.ValidateRequired("bill_type", this.BillType);
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
