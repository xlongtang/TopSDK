using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.membergrade.set
    /// </summary>
    public class CrmMembergradeSetRequest : ITopRequest<CrmMembergradeSetResponse>
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 买家会员级别有四种1：普通会员。2：高级会员。 3VIP会员。 4：至尊VIP<br /> 支持最大值为：4<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> Grade { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.membergrade.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("grade", this.Grade);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("buyer_nick", this.BuyerNick);
            RequestValidator.ValidateRequired("grade", this.Grade);
            RequestValidator.ValidateMaxValue("grade", this.Grade, 4);
            RequestValidator.ValidateMinValue("grade", this.Grade, 1);
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
