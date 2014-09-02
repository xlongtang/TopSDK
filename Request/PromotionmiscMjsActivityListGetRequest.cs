using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotionmisc.mjs.activity.list.get
    /// </summary>
    public class PromotionmiscMjsActivityListGetRequest : ITopRequest<PromotionmiscMjsActivityListGetResponse>
    {
        /// <summary>
        /// 活动类型： 1表示商品级别的活动；2表示店铺级别的活动。<br /> 支持最大值为：2<br /> 支持最小值为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public Nullable<long> ActivityType { get; set; }

        /// <summary>
        /// 页码。<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页记录数，最大支持50 。<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotionmisc.mjs.activity.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("activity_type", this.ActivityType);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("activity_type", this.ActivityType);
            RequestValidator.ValidateMaxValue("activity_type", this.ActivityType, 2);
            RequestValidator.ValidateMinValue("activity_type", this.ActivityType, 1);
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
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
