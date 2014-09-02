using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.store.manage
    /// </summary>
    public class InventoryStoreManageRequest : ITopRequest<InventoryStoreManageResponse>
    {
        /// <summary>
        /// 仓库的物理地址，可更新
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 仓库区域名，可更新
        /// </summary>
        public string AddressAreaName { get; set; }

        /// <summary>
        /// 仓库简称，可更新
        /// </summary>
        public string AliasName { get; set; }

        /// <summary>
        /// 联系人，可更新
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 参数定义，ADD：新建; UPDATE：更新
        /// </summary>
        public string OperateType { get; set; }

        /// <summary>
        /// 联系电话，可更新
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 邮编，可更新
        /// </summary>
        public Nullable<long> Postcode { get; set; }

        /// <summary>
        /// 商家的仓库编码，不允许重复，不允许更新
        /// </summary>
        public string StoreCode { get; set; }

        /// <summary>
        /// 商家的仓库名称，可更新
        /// </summary>
        public string StoreName { get; set; }

        /// <summary>
        /// 仓库类型，可更新。目前只支持自有仓，TYPE_OWN：自有物理仓
        /// </summary>
        public string StoreType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.inventory.store.manage";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("address", this.Address);
            parameters.Add("address_area_name", this.AddressAreaName);
            parameters.Add("alias_name", this.AliasName);
            parameters.Add("contact", this.Contact);
            parameters.Add("operate_type", this.OperateType);
            parameters.Add("phone", this.Phone);
            parameters.Add("postcode", this.Postcode);
            parameters.Add("store_code", this.StoreCode);
            parameters.Add("store_name", this.StoreName);
            parameters.Add("store_type", this.StoreType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("address", this.Address);
            RequestValidator.ValidateRequired("address_area_name", this.AddressAreaName);
            RequestValidator.ValidateRequired("operate_type", this.OperateType);
            RequestValidator.ValidateRequired("store_code", this.StoreCode);
            RequestValidator.ValidateRequired("store_name", this.StoreName);
            RequestValidator.ValidateRequired("store_type", this.StoreType);
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
