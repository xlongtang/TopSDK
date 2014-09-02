using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.system.oauth.token
    /// </summary>
    public class AlipaySystemOauthTokenRequest : ITopRequest<AlipaySystemOauthTokenResponse>
    {
        /// <summary>
        /// 授权码，用户对应用授权后得到。<br /> 支持最大长度为：40<br /> 支持的最大列表长度为：40
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 获取访问令牌的类型，authorization_code表示用授权码换，refresh_token表示用刷新令牌来换。<br /> 支持最大长度为：20<br /> 支持的最大列表长度为：20
        /// </summary>
        public string GrantType { get; set; }

        /// <summary>
        /// 刷新令牌，上次换取访问令牌是得到。<br /> 支持最大长度为：40<br /> 支持的最大列表长度为：40
        /// </summary>
        public string RefreshToken { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.system.oauth.token";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("code", this.Code);
            parameters.Add("grant_type", this.GrantType);
            parameters.Add("refresh_token", this.RefreshToken);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("code", this.Code, 40);
            RequestValidator.ValidateRequired("grant_type", this.GrantType);
            RequestValidator.ValidateMaxLength("grant_type", this.GrantType, 20);
            RequestValidator.ValidateMaxLength("refresh_token", this.RefreshToken, 40);
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
