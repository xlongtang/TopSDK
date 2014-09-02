using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.list.get
    /// </summary>
    public class ItemsListGetRequest : ITopRequest<ItemsListGetResponse>
    {
        /// <summary>
        /// 需要返回的商品对象字段。可选值：Item商品结构体中字段均可返回(除item_weight,item_size)；多个字段用“,”分隔。如果想返回整个子对象，那字段为itemimg，如果是想返回子对象里面的字段，那字段为itemimg.url。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 商品数字id列表，多个num_iid用逗号隔开，一次不超过20个。
        /// </summary>
        public string NumIids { get; set; }

        /// <summary>
        /// 商品数字id列表，多个track_iid用逗号隔开，一次不超过20个。
        /// </summary>
        public string TrackIids { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("num_iids", this.NumIids);
            parameters.Add("track_iids", this.TrackIids);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
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
