using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.athena.item.solution.get
    /// </summary>
    public class AthenaItemSolutionGetRequest : ITopRequest<AthenaItemSolutionGetResponse>
    {
        /// <summary>
        /// 自定义问题的ID
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 宝贝商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 类型key
        /// </summary>
        public string TypeKey { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.athena.item.solution.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("type_key", this.TypeKey);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
