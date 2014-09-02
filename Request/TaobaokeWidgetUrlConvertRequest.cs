using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.widget.url.convert
    /// </summary>
    public class TaobaokeWidgetUrlConvertRequest : ITopRequest<TaobaokeWidgetUrlConvertResponse>
    {
        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 需要转化为淘客链接的url，可以把天猫、聚划算、淘宝旅行、淘宝游戏等平台的活动链接转换为淘宝客推广链接
        /// </summary>
        public string Url { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.widget.url.convert";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("url", this.Url);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("url", this.Url);
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
