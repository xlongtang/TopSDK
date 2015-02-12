using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.item.synchronize
    /// </summary>
    public class WlbItemSynchronizeRequest : ITopRequest<WlbItemSynchronizeResponse>
    {
        /// <summary>
        /// 外部实体ID
        /// </summary>
        public Nullable<long> ExtEntityId { get; set; }

        /// <summary>
        /// 外部实体类型.存如下值  IC_ITEM   --表示IC商品  IC_SKU    --表示IC最小单位商品  若输入其他值，则按IC_ITEM处理
        /// </summary>
        public string ExtEntityType { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 商品所有人淘宝nick
        /// </summary>
        public string UserNick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.item.synchronize";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ext_entity_id", this.ExtEntityId);
            parameters.Add("ext_entity_type", this.ExtEntityType);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("user_nick", this.UserNick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ext_entity_id", this.ExtEntityId);
            RequestValidator.ValidateRequired("ext_entity_type", this.ExtEntityType);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateRequired("user_nick", this.UserNick);
            RequestValidator.ValidateMaxLength("user_nick", this.UserNick, 64);
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
