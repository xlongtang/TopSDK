using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.authorize.get
    /// </summary>
    public class InventoryAuthorizeGetRequest : ITopRequest<InventoryAuthorizeGetResponse>
    {
        /// <summary>
        /// 库存分配授权结果码
        /// </summary>
        public string AuthorizeCode { get; set; }

        /// <summary>
        /// sc_item_id商品后端id
        /// </summary>
        public Nullable<long> ScItemId { get; set; }

        /// <summary>
        /// 分配用户列表，多个用户使用“,“分割开
        /// </summary>
        public string UserNickList { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.inventory.authorize.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("authorize_code", this.AuthorizeCode);
            parameters.Add("sc_item_id", this.ScItemId);
            parameters.Add("user_nick_list", this.UserNickList);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("authorize_code", this.AuthorizeCode);
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
