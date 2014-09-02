using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.ipc.inventorydetail.get
    /// </summary>
    public class InventoryIpcInventorydetailGetRequest : ITopRequest<InventoryIpcInventorydetailGetResponse>
    {
        /// <summary>
        /// 主订单号，可选<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> BizOrderId { get; set; }

        /// <summary>
        /// 子订单号，可选<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> BizSubOrderId { get; set; }

        /// <summary>
        /// 当前页数<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> PageIndex { get; set; }

        /// <summary>
        /// 一页显示多少条
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 仓储商品id
        /// </summary>
        public Nullable<long> ScItemId { get; set; }

        /// <summary>
        /// 1:查询预扣  4：查询占用<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> StatusQuery { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.inventory.ipc.inventorydetail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_order_id", this.BizOrderId);
            parameters.Add("biz_sub_order_id", this.BizSubOrderId);
            parameters.Add("page_index", this.PageIndex);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("sc_item_id", this.ScItemId);
            parameters.Add("status_query", this.StatusQuery);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("biz_order_id", this.BizOrderId, 0);
            RequestValidator.ValidateMinValue("biz_sub_order_id", this.BizSubOrderId, 0);
            RequestValidator.ValidateRequired("page_index", this.PageIndex);
            RequestValidator.ValidateMinValue("page_index", this.PageIndex, 0);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("sc_item_id", this.ScItemId);
            RequestValidator.ValidateRequired("status_query", this.StatusQuery);
            RequestValidator.ValidateMinValue("status_query", this.StatusQuery, 1);
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
