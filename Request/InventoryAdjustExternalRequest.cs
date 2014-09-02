using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.adjust.external
    /// </summary>
    public class InventoryAdjustExternalRequest : ITopRequest<InventoryAdjustExternalResponse>
    {
        /// <summary>
        /// 外部订单类型：ALLOCATE:调拨、 RETURN:退货、PURCHACE：采购、BALANCE:盘点、NON_TAOBAO_TRADE：非淘宝交易、OTHERS：其他
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 商家外部定单号
        /// </summary>
        public string BizUniqueCode { get; set; }

        /// <summary>
        /// 商品初始库存信息： [{"scItemId":"商品后端ID，如果有传scItemCode,参数可以为0","scItemCode":"商品商家编码","inventoryType":"库存类型  1：正常,”direction”: 1: 盘盈 -1: 盘亏,参数可选,"quantity":"数量"}]
        /// </summary>
        public string Items { get; set; }

        /// <summary>
        /// 库存占用返回的操作码.operate_type 为OUTBOUND时，如果是确认事先进行过的库存占用，需要传入当时返回的操作码，并且明细必须与申请时保持一致
        /// </summary>
        public string OccupyOperateCode { get; set; }

        /// <summary>
        /// 业务操作时间
        /// </summary>
        public Nullable<DateTime> OperateTime { get; set; }

        /// <summary>
        /// 库存操作类别：INBOUND：入库 OUTBOUND: 出库BALANCE: 盘点
        /// </summary>
        public string OperateType { get; set; }

        /// <summary>
        /// 出库时库存扣减类型，operate_type为OUTBOUND时有效。   AUTO_CALCULATE:自动计算可供扣减，如果库存不够返回失败 ClIENT_FORCE：强制要求最大化扣减，有多少扣多少
        /// </summary>
        public string ReduceType { get; set; }

        /// <summary>
        /// 商家仓库编码
        /// </summary>
        public string StoreCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.inventory.adjust.external";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("biz_unique_code", this.BizUniqueCode);
            parameters.Add("items", this.Items);
            parameters.Add("occupy_operate_code", this.OccupyOperateCode);
            parameters.Add("operate_time", this.OperateTime);
            parameters.Add("operate_type", this.OperateType);
            parameters.Add("reduce_type", this.ReduceType);
            parameters.Add("store_code", this.StoreCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("biz_type", this.BizType);
            RequestValidator.ValidateRequired("biz_unique_code", this.BizUniqueCode);
            RequestValidator.ValidateRequired("items", this.Items);
            RequestValidator.ValidateRequired("operate_time", this.OperateTime);
            RequestValidator.ValidateRequired("operate_type", this.OperateType);
            RequestValidator.ValidateRequired("store_code", this.StoreCode);
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
