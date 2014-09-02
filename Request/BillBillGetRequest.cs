using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.bill.bill.get
    /// </summary>
    public class BillBillGetRequest : ITopRequest<BillBillGetResponse>
    {
        /// <summary>
        /// 账单编号
        /// </summary>
        public Nullable<long> Bid { get; set; }

        /// <summary>
        /// 传入需要返回的字段
        /// </summary>
        public string Fields { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.bill.bill.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bid", this.Bid);
            parameters.Add("fields", this.Fields);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bid", this.Bid);
            RequestValidator.ValidateRequired("fields", this.Fields);
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
