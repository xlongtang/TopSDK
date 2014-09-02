using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ju.todayitems.get
    /// </summary>
    public class JuTodayitemsGetRequest : ITopRequest<JuTodayitemsGetResponse>
    {
        /// <summary>
        /// 代表需要返回的商品对象字段。可选值：ItemData商品结构体中所有字段均可返回；多个字段用","分隔。如果fields为空，或者不传该参数，就默认获得所有的字段
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// IPHONE,WAP,ANDROID,SINA,163 各种终端类型
        /// </summary>
        public string TerminalType { get; set; }

        /// <summary>
        /// 终端的唯一标识，web可以用cookie，手机使用手机号码等，确保唯一性即可，用于分配商品组
        /// </summary>
        public string Uuid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ju.todayitems.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("terminal_type", this.TerminalType);
            parameters.Add("uuid", this.Uuid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("terminal_type", this.TerminalType);
            RequestValidator.ValidateRequired("uuid", this.Uuid);
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
