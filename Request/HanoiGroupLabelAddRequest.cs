using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.group.label.add
    /// </summary>
    public class HanoiGroupLabelAddRequest : ITopRequest<HanoiGroupLabelAddResponse>
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 分组的id
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        /// <summary>
        /// 标签的id
        /// </summary>
        public Nullable<long> LabelId { get; set; }

        /// <summary>
        /// 标签的优先级。对于互斥分组必须填
        /// </summary>
        public Nullable<long> Level { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.group.label.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("group_id", this.GroupId);
            parameters.Add("label_id", this.LabelId);
            parameters.Add("level", this.Level);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("group_id", this.GroupId);
            RequestValidator.ValidateRequired("label_id", this.LabelId);
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
