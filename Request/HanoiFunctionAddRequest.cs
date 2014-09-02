using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.function.add
    /// </summary>
    public class HanoiFunctionAddRequest : ITopRequest<HanoiFunctionAddResponse>
    {
        /// <summary>
        /// 分配给调用方的名称信息，内部统计使用
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 函数配置名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 函数规则类型 0：JSON 1：条件表达式
        /// </summary>
        public Nullable<long> ParseType { get; set; }

        /// <summary>
        /// 函数规则定义。支持JSON格式，条件表达式等等。groupId：要匹配人群的标签Id。actionId：需要执行动作的动作Id。filterType：匹配类型。0代表动态标签 1代表标签组 doAction:true代表执行动作 getData:true 或者false true代表要匹配结果
        /// </summary>
        public string Rule { get; set; }

        /// <summary>
        /// 规则开放策略 0：user_id私有 1：所有user_id可以使用 2：同一创建者下的user_id拥有
        /// </summary>
        public Nullable<long> Strategy { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.function.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("name", this.Name);
            parameters.Add("parse_type", this.ParseType);
            parameters.Add("rule", this.Rule);
            parameters.Add("strategy", this.Strategy);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("parse_type", this.ParseType);
            RequestValidator.ValidateRequired("rule", this.Rule);
            RequestValidator.ValidateMaxLength("rule", this.Rule, 1000);
            RequestValidator.ValidateRequired("strategy", this.Strategy);
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
