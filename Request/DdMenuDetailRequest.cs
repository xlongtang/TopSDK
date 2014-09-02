using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.dd.menu.detail
    /// </summary>
    public class DdMenuDetailRequest : ITopRequest<DdMenuDetailResponse>
    {
        /// <summary>
        /// 菜单编号
        /// </summary>
        public Nullable<long> MenuId { get; set; }

        /// <summary>
        /// 外部门店编码
        /// </summary>
        public string OutStoreId { get; set; }

        /// <summary>
        /// 淘宝商户id
        /// </summary>
        public string StoreId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.dd.menu.detail";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("menu_id", this.MenuId);
            parameters.Add("out_store_id", this.OutStoreId);
            parameters.Add("store_id", this.StoreId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("menu_id", this.MenuId);
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
