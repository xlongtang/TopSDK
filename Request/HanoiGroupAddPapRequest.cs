using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.group.add.pap
    /// </summary>
    public class HanoiGroupAddPapRequest : ITopRequest<HanoiGroupAddPapResponse>
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 分组的简单描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 分组的编码
        /// </summary>
        public string GroupCode { get; set; }

        /// <summary>
        /// 分组的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 开放策略 true开放，默认为false
        /// </summary>
        public Nullable<bool> Open { get; set; }

        /// <summary>
        /// 使用场景
        /// </summary>
        public Nullable<long> Scene { get; set; }

        /// <summary>
        /// 分组的类型，0 互斥，1 共存，默认为0
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.group.add.pap";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("description", this.Description);
            parameters.Add("group_code", this.GroupCode);
            parameters.Add("name", this.Name);
            parameters.Add("open", this.Open);
            parameters.Add("scene", this.Scene);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("group_code", this.GroupCode);
            RequestValidator.ValidateRequired("name", this.Name);
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
