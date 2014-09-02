using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.rebate.auth.get
    /// </summary>
    public class TaobaokeRebateAuthGetRequest : ITopRequest<TaobaokeRebateAuthGetResponse>
    {
        /// <summary>
        /// nick或seller_id或num_iid，最大输入40个.格式如:"value1,value2,value3" 用","号分隔
        /// </summary>
        public string Params { get; set; }

        /// <summary>
        /// 类型：1-按nick查询，2-按seller_id查询，3-按num_iid查询
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.rebate.auth.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("params", this.Params);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("params", this.Params);
            RequestValidator.ValidateMaxListSize("params", this.Params, 40);
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
