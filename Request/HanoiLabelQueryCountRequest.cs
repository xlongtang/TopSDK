using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.label.query.count
    /// </summary>
    public class HanoiLabelQueryCountRequest : ITopRequest<HanoiLabelQueryCountResponse>
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 模板业务状态 1 审核 0 创建
        /// </summary>
        public Nullable<long> BizStatus { get; set; }

        /// <summary>
        /// 模板的编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 根据时间查询 创建时间结束点
        /// </summary>
        public Nullable<DateTime> GmtCreateEnd { get; set; }

        /// <summary>
        /// 根据时间查询 创建时间截止点
        /// </summary>
        public Nullable<DateTime> GmtCreateStart { get; set; }

        /// <summary>
        /// 根据时间查询，最近修改时间截止
        /// </summary>
        public Nullable<DateTime> GmtModifiedEnd { get; set; }

        /// <summary>
        /// 根据时间查询，最近修改时间起点
        /// </summary>
        public Nullable<DateTime> GmtModifiedStart { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 开放策略
        /// </summary>
        public Nullable<bool> Open { get; set; }

        /// <summary>
        /// 使用场景
        /// </summary>
        public Nullable<long> Scene { get; set; }

        /// <summary>
        /// 标签的源模板id
        /// </summary>
        public Nullable<long> TemplateId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.label.query.count";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("biz_status", this.BizStatus);
            parameters.Add("code", this.Code);
            parameters.Add("gmt_create_end", this.GmtCreateEnd);
            parameters.Add("gmt_create_start", this.GmtCreateStart);
            parameters.Add("gmt_modified_end", this.GmtModifiedEnd);
            parameters.Add("gmt_modified_start", this.GmtModifiedStart);
            parameters.Add("id", this.Id);
            parameters.Add("name", this.Name);
            parameters.Add("open", this.Open);
            parameters.Add("scene", this.Scene);
            parameters.Add("template_id", this.TemplateId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
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
