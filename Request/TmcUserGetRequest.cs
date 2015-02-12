using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tmc.user.get
    /// </summary>
    public class TmcUserGetRequest : ITopRequest<TmcUserGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表，多个字段以半角逗号分隔。可选值：TmcUser结构体中的所有字段，一定要返回topic。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Nick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.tmc.user.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("nick", this.Nick);
            RequestValidator.ValidateMaxLength("nick", this.Nick, 100);
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
