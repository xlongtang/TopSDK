using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.promotag.tag.find
    /// </summary>
    public class TmallPromotagTagFindRequest : ITopRequest<TmallPromotagTagFindResponse>
    {
        /// <summary>
        /// 当前页码<br /> 支持的最大列表长度为：10
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页显示个数<br /> 支持最大值为：100<br /> 支持最小值为：1<br /> 支持的最大列表长度为：100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 标签ID
        /// </summary>
        public Nullable<long> TagId { get; set; }

        /// <summary>
        /// 标签名称，查询时可选项
        /// </summary>
        public string TagName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.promotag.tag.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("tag_id", this.TagId);
            parameters.Add("tag_name", this.TagName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("page_no", this.PageNo);
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
