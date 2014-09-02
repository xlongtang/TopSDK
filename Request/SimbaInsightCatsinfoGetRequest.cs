using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.catsinfo.get
    /// </summary>
    public class SimbaInsightCatsinfoGetRequest : ITopRequest<SimbaInsightCatsinfoGetResponse>
    {
        /// <summary>
        /// 需要查询的类目id
        /// </summary>
        public string CategoryIdList { get; set; }

        /// <summary>
        /// 表示请求的类型：0表示请求所有顶级类目的信息，这时可以忽略第二个参数，1表示获取给定的类目id的详细信息，2表示获取给定类目id的所有子类目的详细信息
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.catsinfo.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_id_list", this.CategoryIdList);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("category_id_list", this.CategoryIdList, 20);
            RequestValidator.ValidateRequired("type", this.Type);
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
