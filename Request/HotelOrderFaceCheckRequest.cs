using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.order.face.check
    /// </summary>
    public class HotelOrderFaceCheckRequest : ITopRequest<HotelOrderFaceCheckResponse>
    {
        /// <summary>
        /// 核实已入住或者未入住，true：已入住，false：未入住
        /// </summary>
        public Nullable<bool> Checked { get; set; }

        /// <summary>
        /// 实际入住时间
        /// </summary>
        public Nullable<DateTime> CheckinDate { get; set; }

        /// <summary>
        /// 实际离店时间
        /// </summary>
        public Nullable<DateTime> CheckoutDate { get; set; }

        /// <summary>
        /// 酒店订单id
        /// </summary>
        public Nullable<long> Oid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.order.face.check";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("checked", this.Checked);
            parameters.Add("checkin_date", this.CheckinDate);
            parameters.Add("checkout_date", this.CheckoutDate);
            parameters.Add("oid", this.Oid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("checked", this.Checked);
            RequestValidator.ValidateRequired("oid", this.Oid);
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
