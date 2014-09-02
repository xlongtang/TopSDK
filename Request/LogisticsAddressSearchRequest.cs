using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.address.search
    /// </summary>
    public class LogisticsAddressSearchRequest : ITopRequest<LogisticsAddressSearchResponse>
    {
        /// <summary>
        /// 可选，参数列表如下：<br><font color='red'> no_def:查询非默认地址<br> get_def:查询默认取货地址<br> cancel_def:查询默认退货地址<br> 缺省此参数时，查询所有当前用户的地址库 </font>
        /// </summary>
        public string Rdef { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.address.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("rdef", this.Rdef);
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
