using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.match.feedback
    /// </summary>
    public class HotelMatchFeedbackRequest : ITopRequest<HotelMatchFeedbackResponse>
    {
        /// <summary>
        /// 需进行匹配的酒店id
        /// </summary>
        public Nullable<long> Haid { get; set; }

        /// <summary>
        /// 匹配命中的酒店id
        /// </summary>
        public Nullable<long> Hid { get; set; }

        /// <summary>
        /// 匹配结果 0:未匹配，1:匹配
        /// </summary>
        public Nullable<long> MatchResult { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.match.feedback";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("haid", this.Haid);
            parameters.Add("hid", this.Hid);
            parameters.Add("match_result", this.MatchResult);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("haid", this.Haid);
            RequestValidator.ValidateMinValue("haid", this.Haid, 1);
            RequestValidator.ValidateMinValue("hid", this.Hid, 0);
            RequestValidator.ValidateRequired("match_result", this.MatchResult);
            RequestValidator.ValidateMaxValue("match_result", this.MatchResult, 1);
            RequestValidator.ValidateMinValue("match_result", this.MatchResult, 0);
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
