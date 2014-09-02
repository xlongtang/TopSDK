using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.inventorylog.query
    /// </summary>
    public class WlbInventorylogQueryRequest : ITopRequest<WlbInventorylogQueryResponse>
    {
        /// <summary>
        /// 结束修改时间,小于等于该时间
        /// </summary>
        public Nullable<DateTime> GmtEnd { get; set; }

        /// <summary>
        /// 起始修改时间,大于等于该时间
        /// </summary>
        public Nullable<DateTime> GmtStart { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 库存操作作类型(可以为空)  CHU_KU 1-出库  RU_KU 2-入库  FREEZE 3-冻结  THAW 4-解冻  CHECK_FREEZE 5-冻结确认  CHANGE_KU 6-库存类型变更  若值不在范围内，则按CHU_KU处理
        /// </summary>
        public string OpType { get; set; }

        /// <summary>
        /// 可指定授权的用户来查询
        /// </summary>
        public Nullable<long> OpUserId { get; set; }

        /// <summary>
        /// 单号
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 分页记录个数
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
            return "taobao.wlb.inventorylog.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("gmt_end", this.GmtEnd);
            parameters.Add("gmt_start", this.GmtStart);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("op_type", this.OpType);
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("order_code", this.OrderCode);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("store_code", this.StoreCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
