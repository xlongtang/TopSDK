using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ju.cityitems.get
    /// </summary>
    public class JuCityitemsGetRequest : ITopRequest<JuCityitemsGetResponse>
    {
        /// <summary>
        /// 需要获取生活服务商品的城市名称（中文）
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 代表需要返回的商品对象字段。可选值：ItemData商品结构体中所有字段均可返回；多个字段用","分隔。如果fields为空，或者不传该参数，就默认获得所有的字段
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 分页获取商品信息页序号，代表第几页<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每次获取商品列表的数量<br /> 支持最大值为：100<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ju.cityitems.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("city", this.City);
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("city", this.City);
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
