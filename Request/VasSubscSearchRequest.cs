using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.vas.subsc.search
    /// </summary>
    public class VasSubscSearchRequest : ITopRequest<VasSubscSearchResponse>
    {
        /// <summary>
        /// 应用收费代码，从合作伙伴后台（my.open.taobao.com）-收费管理-收费项目列表 能够获得该应用的收费代码
        /// </summary>
        public string ArticleCode { get; set; }

        /// <summary>
        /// 是否自动续费，true=自动续费 false=非自动续费 空=全部
        /// </summary>
        public Nullable<bool> Autosub { get; set; }

        /// <summary>
        /// 到期时间结束值
        /// </summary>
        public Nullable<DateTime> EndDeadline { get; set; }

        /// <summary>
        /// 是否到期提醒，true=到期提醒 false=非到期提醒 空=全部
        /// </summary>
        public Nullable<bool> ExpireNotice { get; set; }

        /// <summary>
        /// 收费项目代码，从合作伙伴后台（my.open.taobao.com）-收费管理-收费项目列表 能够获得收费项目代码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 淘宝会员名
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 一页包含的记录数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 到期时间起始值（当start_deadline和end_deadline都不填写时，默认返回最近90天的数据）
        /// </summary>
        public Nullable<DateTime> StartDeadline { get; set; }

        /// <summary>
        /// 订购记录状态，1=有效 2=过期 空=全部
        /// </summary>
        public Nullable<long> Status { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.vas.subsc.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("article_code", this.ArticleCode);
            parameters.Add("autosub", this.Autosub);
            parameters.Add("end_deadline", this.EndDeadline);
            parameters.Add("expire_notice", this.ExpireNotice);
            parameters.Add("item_code", this.ItemCode);
            parameters.Add("nick", this.Nick);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_deadline", this.StartDeadline);
            parameters.Add("status", this.Status);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("article_code", this.ArticleCode);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 200);
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
