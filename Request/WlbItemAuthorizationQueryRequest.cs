using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.item.authorization.query
    /// </summary>
    public class WlbItemAuthorizationQueryRequest : ITopRequest<WlbItemAuthorizationQueryResponse>
    {
        /// <summary>
        /// 授权商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 授权名称<br /> 支持最大长度为：255<br /> 支持的最大列表长度为：255
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 分页记录个数，如果用户输入的记录数大于50，则一页显示50条记录
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 授权编码
        /// </summary>
        public string RuleCode { get; set; }

        /// <summary>
        /// 状态： 只能输入如下值,范围外的默认按VALID处理;不选则查询所有;   VALID -- 1 有效； INVALIDATION -- 2 失效
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 类型：可由不同角色来查询，默认值OWNER,  OWNER -- 授权人,  ON_COMMISSION -- 被授权人
        /// </summary>
        public string Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.item.authorization.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("name", this.Name);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("rule_code", this.RuleCode);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("name", this.Name, 255);
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
