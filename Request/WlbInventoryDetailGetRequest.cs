using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.inventory.detail.get
    /// </summary>
    public class WlbInventoryDetailGetRequest : ITopRequest<WlbInventoryDetailGetResponse>
    {
        /// <summary>
        /// 库存类型列表，值包括：  VENDIBLE--可销售库存  FREEZE--冻结库存  ONWAY--在途库存  DEFECT--残次品库存  ENGINE_DAMAGE--机损  BOX_DAMAGE--箱损  EXPIRATION--过保
        /// </summary>
        public string InventoryTypeList { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string StoreCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.inventory.detail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("inventory_type_list", this.InventoryTypeList);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("store_code", this.StoreCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("inventory_type_list", this.InventoryTypeList, 20);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
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
