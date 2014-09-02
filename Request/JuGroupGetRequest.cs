using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ju.group.get
    /// </summary>
    public class JuGroupGetRequest : ITopRequest<JuGroupGetResponse>
    {
        /// <summary>
        /// 代表需要返回的商品对象字段。可选值：ItemData商品结构体中所有字段均可返回；多个字段用“,”分隔。如果fields为空，或者不传该参数，就默认获得所有的字段
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 聚划算组的编号<br /> 支持最小值为：1<br /> 支持的最大列表长度为：22
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ju.group.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("group_id", this.GroupId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("group_id", this.GroupId);
            RequestValidator.ValidateMinValue("group_id", this.GroupId, 1);
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
