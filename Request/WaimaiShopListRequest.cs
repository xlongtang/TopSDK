using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.waimai.shop.list
    /// </summary>
    public class WaimaiShopListRequest : ITopRequest<WaimaiShopListResponse>
    {
        /// <summary>
        /// 查询关键字
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 页码<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> Page { get; set; }

        /// <summary>
        /// 每页条数<br /> 支持最大值为：20<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 店铺状态，歇业：0，营业：1，所有：-1
        /// </summary>
        public Nullable<long> Status { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.waimai.shop.list";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("keywords", this.Keywords);
            parameters.Add("page", this.Page);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("status", this.Status);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateMinValue("page", this.Page, 1);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 20);
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
