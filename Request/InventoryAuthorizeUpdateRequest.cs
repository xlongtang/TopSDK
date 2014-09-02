using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.authorize.update
    /// </summary>
    public class InventoryAuthorizeUpdateRequest : ITopRequest<InventoryAuthorizeUpdateResponse>
    {
        /// <summary>
        /// 库存授权配额编码
        /// </summary>
        public string AuthorizeCode { get; set; }

        /// <summary>
        /// 期望更新后的配额账户库存数(全量覆盖)
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        /// <summary>
        /// 后端商品id
        /// </summary>
        public Nullable<long> ScItemId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.inventory.authorize.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("authorize_code", this.AuthorizeCode);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("sc_item_id", this.ScItemId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("authorize_code", this.AuthorizeCode);
            RequestValidator.ValidateRequired("quantity", this.Quantity);
            RequestValidator.ValidateRequired("sc_item_id", this.ScItemId);
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
