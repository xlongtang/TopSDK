using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.distributor.products.get
    /// </summary>
    public class FenxiaoDistributorProductsGetRequest : ITopRequest<FenxiaoDistributorProductsGetResponse>
    {
        /// <summary>
        /// 下载状态，默认未下载。UNDOWNLOAD：未下载，DOWNLOADED：已下载。
        /// </summary>
        public string DownloadStatus { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 指定查询额外的信息，可选值：skus（sku数据）、images（多图），多个可选值用逗号分割。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 根据商品ID列表查询，优先级次于产品ID列表，高于其他分页查询条件。如果商品不是分销商品，自动过滤。最大限制20，用逗号分割，例如：“1001,1002,1003,1004,1005”
        /// </summary>
        public string ItemIds { get; set; }

        /// <summary>
        /// 排序。QUANTITY_DESC：库存降序，CREATE_TIME_DESC，创建时间降序。
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 页码（大于0的整数，默认1）
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页记录数（默认20，最大50）
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 产品ID列表，优先级最高，传了忽略其他查询条件。用逗号分割，例如：“1001,1002,1003,1004,1005”
        /// </summary>
        public string Pids { get; set; }

        /// <summary>
        /// 产品线ID
        /// </summary>
        public Nullable<long> ProductcatId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 供应商nick，分页查询时，必传
        /// </summary>
        public string SupplierNick { get; set; }

        /// <summary>
        /// 查询时间类型，默认更新时间。MODIFIED:更新时间，CREATE:创建时间
        /// </summary>
        public string TimeType { get; set; }

        /// <summary>
        /// 分销方式，分页查询时，必传。AGENT：代销，DEALER：经销
        /// </summary>
        public string TradeType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.distributor.products.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("download_status", this.DownloadStatus);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("item_ids", this.ItemIds);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("pids", this.Pids);
            parameters.Add("productcat_id", this.ProductcatId);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("supplier_nick", this.SupplierNick);
            parameters.Add("time_type", this.TimeType);
            parameters.Add("trade_type", this.TradeType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("item_ids", this.ItemIds, 20);
            RequestValidator.ValidateMaxListSize("pids", this.Pids, 20);
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
