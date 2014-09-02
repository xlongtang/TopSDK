using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jipiao.policy.get
    /// </summary>
    public class JipiaoPolicyGetRequest : ITopRequest<JipiaoPolicyGetResponse>
    {
        /// <summary>
        /// type外0，表示机票政策id；type为1，表示机票政策out_product_id
        /// </summary>
        public string PolicyId { get; set; }

        /// <summary>
        /// 0，表示按政策id进行查询；1，表示按政策外部id进行查询
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jipiao.policy.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("policy_id", this.PolicyId);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("policy_id", this.PolicyId);
            RequestValidator.ValidateMaxLength("policy_id", this.PolicyId, 64);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateMaxValue("type", this.Type, 1);
            RequestValidator.ValidateMinValue("type", this.Type, 0);
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
