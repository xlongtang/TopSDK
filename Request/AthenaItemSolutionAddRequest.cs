using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.athena.item.solution.add
    /// </summary>
    public class AthenaItemSolutionAddRequest : ITopRequest<AthenaItemSolutionAddResponse>
    {
        /// <summary>
        /// 商品ID<br /> 支持的最大列表长度为：64
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 自定义的问题
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// 解决方案<br /> 支持最大长度为：1024<br /> 支持的最大列表长度为：1024
        /// </summary>
        public string Solution { get; set; }

        /// <summary>
        /// 发送状态 1半自动 2全自动
        /// </summary>
        public Nullable<long> SolutionLevel { get; set; }

        /// <summary>
        /// stf 旺旺富文本格式的解决方案<br /> 支持最大长度为：1024<br /> 支持的最大列表长度为：1024
        /// </summary>
        public string SolutionStf { get; set; }

        /// <summary>
        /// 关联 athena_item_knowledge_type 表的 type_key字段<br /> 支持最大长度为：64<br /> 支持的最大列表长度为：64
        /// </summary>
        public string TypeKey { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.athena.item.solution.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("question", this.Question);
            parameters.Add("solution", this.Solution);
            parameters.Add("solution_level", this.SolutionLevel);
            parameters.Add("solution_stf", this.SolutionStf);
            parameters.Add("type_key", this.TypeKey);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateRequired("question", this.Question);
            RequestValidator.ValidateRequired("solution", this.Solution);
            RequestValidator.ValidateMaxLength("solution", this.Solution, 1024);
            RequestValidator.ValidateRequired("solution_level", this.SolutionLevel);
            RequestValidator.ValidateRequired("solution_stf", this.SolutionStf);
            RequestValidator.ValidateMaxLength("solution_stf", this.SolutionStf, 1024);
            RequestValidator.ValidateRequired("type_key", this.TypeKey);
            RequestValidator.ValidateMaxLength("type_key", this.TypeKey, 64);
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
