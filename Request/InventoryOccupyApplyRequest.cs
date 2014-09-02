using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.occupy.apply
    /// </summary>
    public class InventoryOccupyApplyRequest : ITopRequest<InventoryOccupyApplyResponse>
    {
        /// <summary>
        /// 外部订单类型, BALANCE:盘点、NON_TAOBAO_TRADE:非淘宝交易、ALLOCATE:调拨、OTHERS:其他
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 商家外部定单号
        /// </summary>
        public string BizUniqueCode { get; set; }

        /// <summary>
        /// 渠道编号
        /// </summary>
        public string ChannelFlags { get; set; }

        /// <summary>
        /// 商品库存预留信息： [{"scItemId":"商品后端ID，如果有传scItemCode,参数可以为0","scItemCode":"商品商家编码","inventoryType":"库存类型  1：正常,2：损坏,3：冻结,10：质押",11-20:商家自定义,”inventoryTypeName”:”库存类型名称,可选”,"occupyQuantity":"数量"}]
        /// </summary>
        public string Items { get; set; }

        /// <summary>
        /// 天数，默认5天，最大15天
        /// </summary>
        public Nullable<long> OccupyTime { get; set; }

        /// <summary>
        /// 占用类型  参数定义  AUTO_CALCULATE:自动计算可供占用，如果库存不够返回失败 ClIENT_FORCE：强制要求最大化占用，有多少占用多少
        /// </summary>
        public string OccupyType { get; set; }

        /// <summary>
        /// 商家仓库编码
        /// </summary>
        public string StoreCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.inventory.occupy.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("biz_unique_code", this.BizUniqueCode);
            parameters.Add("channel_flags", this.ChannelFlags);
            parameters.Add("items", this.Items);
            parameters.Add("occupy_time", this.OccupyTime);
            parameters.Add("occupy_type", this.OccupyType);
            parameters.Add("store_code", this.StoreCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("biz_type", this.BizType);
            RequestValidator.ValidateRequired("biz_unique_code", this.BizUniqueCode);
            RequestValidator.ValidateRequired("items", this.Items);
            RequestValidator.ValidateRequired("occupy_time", this.OccupyTime);
            RequestValidator.ValidateRequired("occupy_type", this.OccupyType);
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
