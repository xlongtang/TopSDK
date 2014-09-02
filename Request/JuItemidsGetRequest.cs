using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ju.itemids.get
    /// </summary>
    public class JuItemidsGetRequest : ITopRequest<JuItemidsGetResponse>
    {
        /// <summary>
        /// 分页获取商品信息页序号，代表第几页<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每次获取商品列表的数量<br /> 支持最大值为：100<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 平台ID。搜狗:1008,聚划算:1001,商城:1002,无线WAP:1007,支付宝:1003,淘宝天下:1004,嗨淘:1006
        /// </summary>
        public Nullable<long> PlatformId { get; set; }

        /// <summary>
        /// IPHONE,WAP,ANDROID,SINA,163 各种终端类型
        /// </summary>
        public string TerminalType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ju.itemids.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("platform_id", this.PlatformId);
            parameters.Add("terminal_type", this.TerminalType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 0);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
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
