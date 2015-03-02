using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.fixbooking
    /// </summary>
    public class HotelFixbookingRequest : ITopRequest<HotelFixbookingResponse>
    {
        /// <summary>
        /// booking酒店ID
        /// </summary>
        public string BookingId { get; set; }

        /// <summary>
        /// 国家代码
        /// </summary>
        public string CouCode { get; set; }

        /// <summary>
        /// 酒店名称
        /// </summary>
        public string HnCode { get; set; }

        /// <summary>
        /// 评价数
        /// </summary>
        public Nullable<long> RevCount { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.fixbooking";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("booking_id", this.BookingId);
            parameters.Add("cou_code", this.CouCode);
            parameters.Add("hn_code", this.HnCode);
            parameters.Add("rev_count", this.RevCount);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("booking_id", this.BookingId);
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
