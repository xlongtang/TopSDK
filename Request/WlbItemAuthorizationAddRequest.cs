using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.item.authorization.add
    /// </summary>
    public class WlbItemAuthorizationAddRequest : ITopRequest<WlbItemAuthorizationAddResponse>
    {
        /// <summary>
        /// 授权类型：1=全量授权，0=部分授权  当部分授权时，需要指定授权数量quantity
        /// </summary>
        public Nullable<long> AuthType { get; set; }

        /// <summary>
        /// 授权结束时间
        /// </summary>
        public Nullable<DateTime> AuthorizeEndTime { get; set; }

        /// <summary>
        /// 授权开始时间
        /// </summary>
        public Nullable<DateTime> AuthorizeStartTime { get; set; }

        /// <summary>
        /// 被授权人用户id
        /// </summary>
        public string ConsignUserNick { get; set; }

        /// <summary>
        /// 商品id列表，以英文逗号,分隔，最多可放入50个商品ID。
        /// </summary>
        public string ItemIdList { get; set; }

        /// <summary>
        /// 规则名称<br /> 支持最大长度为：255<br /> 支持的最大列表长度为：255
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 授权数量
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        /// <summary>
        /// 授权规则：目前只有GRANT_FIX，按照数量授权
        /// </summary>
        public string RuleCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.item.authorization.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auth_type", this.AuthType);
            parameters.Add("authorize_end_time", this.AuthorizeEndTime);
            parameters.Add("authorize_start_time", this.AuthorizeStartTime);
            parameters.Add("consign_user_nick", this.ConsignUserNick);
            parameters.Add("item_id_list", this.ItemIdList);
            parameters.Add("name", this.Name);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("rule_code", this.RuleCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("auth_type", this.AuthType);
            RequestValidator.ValidateRequired("authorize_end_time", this.AuthorizeEndTime);
            RequestValidator.ValidateRequired("authorize_start_time", this.AuthorizeStartTime);
            RequestValidator.ValidateRequired("consign_user_nick", this.ConsignUserNick);
            RequestValidator.ValidateRequired("item_id_list", this.ItemIdList);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 255);
            RequestValidator.ValidateRequired("rule_code", this.RuleCode);
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
