using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trip.jipiao.agent.itinerary.send
    /// </summary>
    public class TripJipiaoAgentItinerarySendRequest : ITopRequest<TripJipiaoAgentItinerarySendResponse>
    {
        /// <summary>
        /// 物流公司代码CODE，如不清楚，请找运营提供<br /> 支持最大长度为：20<br /> 支持的最大列表长度为：20
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 邮寄单号，长度不能超过32字节<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string ExpressCode { get; set; }

        /// <summary>
        /// 淘宝系统行程单唯一键
        /// </summary>
        public Nullable<long> ItineraryId { get; set; }

        /// <summary>
        /// 行程单号<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string ItineraryNo { get; set; }

        /// <summary>
        /// 邮寄日期，格式yyyy-mm-dd
        /// </summary>
        public string SendDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trip.jipiao.agent.itinerary.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("company_code", this.CompanyCode);
            parameters.Add("express_code", this.ExpressCode);
            parameters.Add("itinerary_id", this.ItineraryId);
            parameters.Add("itinerary_no", this.ItineraryNo);
            parameters.Add("send_date", this.SendDate);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("company_code", this.CompanyCode);
            RequestValidator.ValidateMaxLength("company_code", this.CompanyCode, 20);
            RequestValidator.ValidateRequired("express_code", this.ExpressCode);
            RequestValidator.ValidateMaxLength("express_code", this.ExpressCode, 32);
            RequestValidator.ValidateRequired("itinerary_id", this.ItineraryId);
            RequestValidator.ValidateRequired("itinerary_no", this.ItineraryNo);
            RequestValidator.ValidateMaxLength("itinerary_no", this.ItineraryNo, 32);
            RequestValidator.ValidateRequired("send_date", this.SendDate);
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
