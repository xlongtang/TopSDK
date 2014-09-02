using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.favorite.search
    /// </summary>
    public class FavoriteSearchRequest : ITopRequest<FavoriteSearchResponse>
    {
        /// <summary>
        /// ITEM表示宝贝，SHOP表示商铺，collect_type只能为这两者之一<br /> 支持最大长度为：4<br /> 支持的最大列表长度为：4
        /// </summary>
        public string CollectType { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数; 默认值:1。一页20条记录。<br /> 支持最大值为：100<br /> 支持最小值为：1<br /> 支持的最大列表长度为：20
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.favorite.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("collect_type", this.CollectType);
            parameters.Add("page_no", this.PageNo);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("collect_type", this.CollectType);
            RequestValidator.ValidateMaxLength("collect_type", this.CollectType, 4);
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateMaxValue("page_no", this.PageNo, 100);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
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
