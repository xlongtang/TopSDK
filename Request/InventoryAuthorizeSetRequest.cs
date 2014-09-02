using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.authorize.set
    /// </summary>
    public class InventoryAuthorizeSetRequest : ITopRequest<InventoryAuthorizeSetResponse>
    {
        /// <summary>
        /// 配额授权方式   PUBLIC: 全共享  PRIVATE:独享
        /// </summary>
        public string AuthorizeType { get; set; }

        /// <summary>
        /// 授权明细  [{“index”:0,“scItemId”:232323,”scItemCode”:”A232”,”storeCode”:”Kj11”,”inventoryType”:1,”channelFlag”:0,”quotaQuantity”:1000,”nickNameList”:”s108,TY000”，“nickName":"ca11"}]  每次请求的列表数据量是1条，如果authorize_type是PUBLIC,使用nickNameList，否则请用nickName
        /// </summary>
        public string Items { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.inventory.authorize.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("authorize_type", this.AuthorizeType);
            parameters.Add("items", this.Items);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("authorize_type", this.AuthorizeType);
            RequestValidator.ValidateRequired("items", this.Items);
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
