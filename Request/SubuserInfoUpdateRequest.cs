using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.subuser.info.update
    /// </summary>
    public class SubuserInfoUpdateRequest : ITopRequest<SubuserInfoUpdateResponse>
    {
        /// <summary>
        /// 是否停用子账号 true:表示停用该子账号false:表示开启该子账号
        /// </summary>
        public Nullable<bool> IsDisableSubaccount { get; set; }

        /// <summary>
        /// 子账号是否参与分流 true:参与分流 false:不参与分流
        /// </summary>
        public Nullable<bool> IsDispatch { get; set; }

        /// <summary>
        /// 子账号ID
        /// </summary>
        public Nullable<long> SubId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.subuser.info.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_disable_subaccount", this.IsDisableSubaccount);
            parameters.Add("is_dispatch", this.IsDispatch);
            parameters.Add("sub_id", this.SubId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sub_id", this.SubId);
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
