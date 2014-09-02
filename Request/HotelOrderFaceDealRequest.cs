using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.order.face.deal
    /// </summary>
    public class HotelOrderFaceDealRequest : ITopRequest<HotelOrderFaceDealResponse>
    {
        /// <summary>
        /// 酒店订单oid
        /// </summary>
        public Nullable<long> Oid { get; set; }

        /// <summary>
        /// 操作类型，1：确认预订，2：取消订单<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string OperType { get; set; }

        /// <summary>
        /// 取消订单时的取消原因备注信息<br /> 支持最大长度为：500<br /> 支持的最大列表长度为：500
        /// </summary>
        public string ReasonText { get; set; }

        /// <summary>
        /// 取消订单时的取消原因，可选值：1,2,3,4；  1：无房，2：价格变动，3：买家原因，4：其它原因<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string ReasonType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.order.face.deal";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("oid", this.Oid);
            parameters.Add("oper_type", this.OperType);
            parameters.Add("reason_text", this.ReasonText);
            parameters.Add("reason_type", this.ReasonType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("oid", this.Oid);
            RequestValidator.ValidateRequired("oper_type", this.OperType);
            RequestValidator.ValidateMaxLength("oper_type", this.OperType, 1);
            RequestValidator.ValidateMaxLength("reason_text", this.ReasonText, 500);
            RequestValidator.ValidateMaxLength("reason_type", this.ReasonType, 1);
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
