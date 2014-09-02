using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemcats.increment.get
    /// </summary>
    public class ItemcatsIncrementGetRequest : ITopRequest<ItemcatsIncrementGetResponse>
    {
        /// <summary>
        /// 一级类目ID列表，用半角逗号(,)分隔，例如:"16,19562"，一次最多可以获取10个类目的增量数据。
        /// </summary>
        public string Cids { get; set; }

        /// <summary>
        /// 要获取最近哪一天的增量类目数据，可选值为：1~7。默认值为1，表示获取昨天发生变更的类目数据。
        /// </summary>
        public Nullable<long> Days { get; set; }

        /// <summary>
        /// 获取类目的类型：1代表集市、2代表天猫
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemcats.increment.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cids", this.Cids);
            parameters.Add("days", this.Days);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cids", this.Cids);
            RequestValidator.ValidateMaxListSize("cids", this.Cids, 1000);
            RequestValidator.ValidateMaxValue("days", this.Days, 7);
            RequestValidator.ValidateMinValue("days", this.Days, 1);
            RequestValidator.ValidateMaxValue("type", this.Type, 2);
            RequestValidator.ValidateMinValue("type", this.Type, 1);
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
