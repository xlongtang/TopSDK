using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.keywords.recommend.get
    /// </summary>
    public class SimbaKeywordsRecommendGetRequest : ITopRequest<SimbaKeywordsRecommendGetResponse>
    {
        /// <summary>
        /// 推广组ID
        /// </summary>
        public Nullable<long> AdgroupId { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 排序方式:   搜索量 search_volume   市场平均价格 average_price   相关度 relevance   不排序 non   默认为 non
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 返回的第几页数据，默认为1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 返回的每页数据量大小,最大200
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 相关度
        /// </summary>
        public string Pertinence { get; set; }

        /// <summary>
        /// 搜索量,设置此值后返回的就是大于此搜索量的词列表
        /// </summary>
        public Nullable<long> Search { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.keywords.recommend.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adgroup_id", this.AdgroupId);
            parameters.Add("nick", this.Nick);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("pertinence", this.Pertinence);
            parameters.Add("search", this.Search);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("adgroup_id", this.AdgroupId);
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 200);
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
