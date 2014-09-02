using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.promotag.tag.apply
    /// </summary>
    public class TmallPromotagTagApplyRequest : ITopRequest<TmallPromotagTagApplyResponse>
    {
        /// <summary>
        /// 标签结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 标签开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 标签用途描述
        /// </summary>
        public string TagDesc { get; set; }

        /// <summary>
        /// 标签名称。 注意在UMP中使用新人群标签top变成大写的“NEW_” 如：老标签是top1234，新标签是NEW_1234 。
        /// </summary>
        public string TagName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.promotag.tag.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("tag_desc", this.TagDesc);
            parameters.Add("tag_name", this.TagName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
            RequestValidator.ValidateRequired("tag_desc", this.TagDesc);
            RequestValidator.ValidateRequired("tag_name", this.TagName);
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
