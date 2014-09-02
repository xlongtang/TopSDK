using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.user.get
    /// </summary>
    public class UserGetRequest : ITopRequest<UserGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表。可选值：User结构体中的所有字段；以半角逗号(,)分隔。需要用户授权才能获取用户对应的uid和user_id。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 用户昵称，如果昵称为中文，请使用UTF-8字符集对昵称进行URL编码。 <br><font color="red">注：在传入session的情况下,可以不传nick，表示取当前用户信息；否则nick必须传.<br> 自用型应用不需要传入nick </font>
        /// </summary>
        public string Nick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.user.get";
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
