using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.user.delete
    /// </summary>
    public class JushitaJdpUserDeleteRequest : ITopRequest<JushitaJdpUserDeleteResponse>
    {
        /// <summary>
        /// 要删除用户的昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 需要删除的用户编号<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> UserId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jushita.jdp.user.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.Add("user_id", this.UserId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("user_id", this.UserId, 1);
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
