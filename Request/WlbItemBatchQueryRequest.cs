using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.item.batch.query
    /// </summary>
    public class WlbItemBatchQueryRequest : ITopRequest<WlbItemBatchQueryResponse>
    {
        /// <summary>
        /// 需要查询的商品ID列表，以字符串表示，ID间以;隔开
        /// </summary>
        public string ItemIds { get; set; }

        /// <summary>
        /// 分页查询参数，指定查询页数，默认为1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 分页查询参数，每页查询数量，默认20，最大值50,大于50时按照50条查询
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        public string StoreCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.item.batch.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_ids", this.ItemIds);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("store_code", this.StoreCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_ids", this.ItemIds);
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
