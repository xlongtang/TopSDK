using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotion.limitdiscount.get
    /// </summary>
    public class PromotionLimitdiscountGetRequest : ITopRequest<PromotionLimitdiscountGetResponse>
    {
        /// <summary>
        /// 限时打折结束时间。输入的时间会被截取，年月日有效，时分秒忽略。
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 限时打折ID。这个针对查询唯一限时打折情况。若此字段不为空，则说明操作为单条限时打折记录查询，其他字段忽略。若想分页按条件查询，这个字段置为空。
        /// </summary>
        public Nullable<long> LimitDiscountId { get; set; }

        /// <summary>
        /// 分页页号。默认1。当页数大于最大页数时，结果为最大页数的数据。
        /// </summary>
        public Nullable<long> PageNumber { get; set; }

        /// <summary>
        /// 限时打折开始时间。输入的时间会被截取，年月日有效，时分秒忽略。
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 限时打折活动状态。ALL:全部状态;OVER:已结束;DOING:进行中;PROPARE:未开始(只支持大写)。当limit_discount_id为空时，为空时，默认为全部的状态。
        /// </summary>
        public string Status { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotion.limitdiscount.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("limit_discount_id", this.LimitDiscountId);
            parameters.Add("page_number", this.PageNumber);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("status", this.Status);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
