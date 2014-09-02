using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ts.subscribe.get
    /// </summary>
    public class TsSubscribeGetRequest : ITopRequest<TsSubscribeGetResponse>
    {
        /// <summary>
        /// 订购用户昵称<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 服务收费项code<br /> 支持最大长度为：64<br /> 支持的最大列表长度为：64
        /// </summary>
        public string ServcieItemCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ts.subscribe.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.Add("servcie_item_code", this.ServcieItemCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("nick", this.Nick);
            RequestValidator.ValidateMaxLength("nick", this.Nick, 32);
            RequestValidator.ValidateRequired("servcie_item_code", this.ServcieItemCode);
            RequestValidator.ValidateMaxLength("servcie_item_code", this.ServcieItemCode, 64);
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
