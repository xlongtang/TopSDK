using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.out.inventory.change.notify
    /// </summary>
    public class WlbOutInventoryChangeNotifyRequest : ITopRequest<WlbOutInventoryChangeNotifyResponse>
    {
        /// <summary>
        /// 库存变化数量
        /// </summary>
        public Nullable<long> ChangeCount { get; set; }

        /// <summary>
        /// 物流宝商品id或前台宝贝id（由type类型决定）
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// OUT--出库  IN--入库
        /// </summary>
        public string OpType { get; set; }

        /// <summary>
        /// 订单号，如果source为TAOBAO_TRADE,order_source_code必须为淘宝交易号
        /// </summary>
        public string OrderSourceCode { get; set; }

        /// <summary>
        /// 库存变化唯一标识，用于去重，一个外部唯一编码唯一标识一次库存变化。
        /// </summary>
        public string OutBizCode { get; set; }

        /// <summary>
        /// 本次库存变化后库存余额
        /// </summary>
        public Nullable<long> ResultCount { get; set; }

        /// <summary>
        /// （1）OTHER： 其他   （2）TAOBAO_TRADE： 淘宝交易   （3）OTHER_TRADE：其他交易   （4）ALLCOATE： 调拨   （5）CHECK:盘点  （6）PURCHASE:采购
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 目前非必须，系统会选择默认值
        /// </summary>
        public string StoreCode { get; set; }

        /// <summary>
        /// WLB_ITEM--物流宝商品  IC_ITEM--淘宝商品  IC_SKU--淘宝sku
        /// </summary>
        public string Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.out.inventory.change.notify";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("change_count", this.ChangeCount);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("op_type", this.OpType);
            parameters.Add("order_source_code", this.OrderSourceCode);
            parameters.Add("out_biz_code", this.OutBizCode);
            parameters.Add("result_count", this.ResultCount);
            parameters.Add("source", this.Source);
            parameters.Add("store_code", this.StoreCode);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("change_count", this.ChangeCount);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateRequired("op_type", this.OpType);
            RequestValidator.ValidateRequired("out_biz_code", this.OutBizCode);
            RequestValidator.ValidateRequired("result_count", this.ResultCount);
            RequestValidator.ValidateRequired("source", this.Source);
            RequestValidator.ValidateRequired("type", this.Type);
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
