using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ticket.item.get
    /// </summary>
    public class TicketItemGetRequest : ITopRequest<TicketItemGetResponse>
    {
        /// <summary>
        /// 需要返回的门票商品（TicketItem）对象字段，如title,price,skus等。<br>可选值：TicketItem商品结构体中所有字段均可返回；多个字段用“,”分隔。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 新门票类目商品的标识（非日历价格库存商品）
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ticket.item.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("item_id", this.ItemId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
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
