using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.user.account.freeze.get
    /// </summary>
    public class AlipayUserAccountFreezeGetRequest : ITopRequest<AlipayUserAccountFreezeGetResponse>
    {
        /// <summary>
        /// 冻结类型，多个用,分隔。不传返回所有类型的冻结金额。  DEPOSIT_FREEZE,充值冻结  WITHDRAW_FREEZE,提现冻结  PAYMENT_FREEZE,支付冻结  BAIL_FREEZE,保证金冻结  CHARGE_FREEZE,收费冻结  PRE_DEPOSIT_FREEZE,预存款冻结  LOAN_FREEZE,贷款冻结  OTHER_FREEZE,其它
        /// </summary>
        public string FreezeType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.user.account.freeze.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("freeze_type", this.FreezeType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
