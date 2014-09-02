using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topats.itemcats.get
    /// </summary>
    public class TopatsItemcatsGetRequest : ITopRequest<TopatsItemcatsGetResponse>
    {
        /// <summary>
        /// 一级类目ID列表（非一级类目将会被忽略），用半角分号(;)分隔，例如:"16;19562"，一次最多可以获取10个类目的增量数据。<span style="color:red">注：传入0代表获取所有类目的数据,默认获取所有类目数据</span>
        /// </summary>
        public string Cids { get; set; }

        /// <summary>
        /// 类目数据输出格式，可选值为：csv, json（默认csv格式返回）
        /// </summary>
        public string OutputFormat { get; set; }

        /// <summary>
        /// 获取类目的类型：1代表集市、2代表天猫
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.topats.itemcats.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cids", this.Cids);
            parameters.Add("output_format", this.OutputFormat);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
