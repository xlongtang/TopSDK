using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wireless.qrcode.get
    /// </summary>
    public class WirelessQrcodeGetRequest : ITopRequest<WirelessQrcodeGetResponse>
    {
        /// <summary>
        /// 二维码高度
        /// </summary>
        public Nullable<long> Height { get; set; }

        /// <summary>
        /// 用户的淘宝nick
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// url参数
        /// </summary>
        public string Urlparam { get; set; }

        /// <summary>
        /// 二维码宽度
        /// </summary>
        public Nullable<long> Width { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wireless.qrcode.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("height", this.Height);
            parameters.Add("nick", this.Nick);
            parameters.Add("urlparam", this.Urlparam);
            parameters.Add("width", this.Width);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("height", this.Height);
            RequestValidator.ValidateRequired("nick", this.Nick);
            RequestValidator.ValidateRequired("width", this.Width);
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
