using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jipiao.policystatus.update
    /// </summary>
    public class JipiaoPolicystatusUpdateRequest : ITopRequest<JipiaoPolicystatusUpdateResponse>
    {
        /// <summary>
        /// type为0，表示机票政策id；type为1，表示机票政策out_product_id；最大支持政策数100，注意不要如果不要超出字符串的长度限制，超出的话，请调小批量的个数
        /// </summary>
        public string PolicyId { get; set; }

        /// <summary>
        /// 政策的状态: 0，挂起；1，解挂；2，删除
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 0，表示按政策id进行查询；1，表示按政策外部id进行查询
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jipiao.policystatus.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("policy_id", this.PolicyId);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("policy_id", this.PolicyId);
            RequestValidator.ValidateMaxListSize("policy_id", this.PolicyId, 100);
            RequestValidator.ValidateMaxLength("policy_id", this.PolicyId, 6500);
            RequestValidator.ValidateRequired("status", this.Status);
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
