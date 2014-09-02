using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.group.update
    /// </summary>
    public class HanoiGroupUpdateRequest : ITopRequest<HanoiGroupUpdateResponse>
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 分组的描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 分组上次更新时间
        /// </summary>
        public Nullable<DateTime> GmtModified { get; set; }

        /// <summary>
        /// 分组的编码
        /// </summary>
        public string GroupCode { get; set; }

        /// <summary>
        /// 需要更新的分组id
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 分组的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 开放策略（true 开放，默认为false）
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
            return "taobao.hanoi.group.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("description", this.Description);
            parameters.Add("gmt_modified", this.GmtModified);
            parameters.Add("group_code", this.GroupCode);
            parameters.Add("id", this.Id);
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
            RequestValidator.ValidateRequired("gmt_modified", this.GmtModified);
            RequestValidator.ValidateRequired("id", this.Id);
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
