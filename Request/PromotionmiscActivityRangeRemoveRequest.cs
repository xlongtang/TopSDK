using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotionmisc.activity.range.remove
    /// </summary>
    public class PromotionmiscActivityRangeRemoveRequest : ITopRequest<PromotionmiscActivityRangeRemoveResponse>
    {
        /// <summary>
        /// 活动id。<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> ActivityId { get; set; }

        /// <summary>
        /// 商品id,多个id用逗号隔开。
        /// </summary>
        public string Ids { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotionmisc.activity.range.remove";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("activity_id", this.ActivityId);
            parameters.Add("ids", this.Ids);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("activity_id", this.ActivityId);
            RequestValidator.ValidateMinValue("activity_id", this.ActivityId, 0);
            RequestValidator.ValidateRequired("ids", this.Ids);
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
