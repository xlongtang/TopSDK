using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jae.client.interaction.listeningshake
    /// </summary>
    public class JaeClientInteractionListeningshakeRequest : ITopRequest<JaeClientInteractionListeningshakeResponse>
    {
        /// <summary>
        /// 失败回调函数
        /// </summary>
        public string Failure { get; set; }

        /// <summary>
        /// 用户参数
        /// </summary>
        public string Option { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jae.client.interaction.listeningshake";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("failure", this.Failure);
            parameters.Add("option", this.Option);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("failure", this.Failure);
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
