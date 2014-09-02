using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.replenish.statistics
    /// </summary>
    public class WlbReplenishStatisticsRequest : ITopRequest<WlbReplenishStatisticsResponse>
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分页参数，默认第一页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 分页每页页数，默认20，最大50<br /> 支持最大值为：50
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string StoreCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.replenish.statistics";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_code", this.ItemCode);
            parameters.Add("name", this.Name);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("store_code", this.StoreCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 50);
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
