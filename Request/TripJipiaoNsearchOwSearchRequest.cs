using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trip.jipiao.nsearch.ow.search
    /// </summary>
    public class TripJipiaoNsearchOwSearchRequest : ITopRequest<TripJipiaoNsearchOwSearchResponse>
    {
        /// <summary>
        /// 到达城市三字码<br /> 支持最大长度为：3<br /> 支持的最大列表长度为：3
        /// </summary>
        public string ArrCityCode { get; set; }

        /// <summary>
        /// 舱位等级，0，默认-全部；1，经济舱；2，商务舱；3，头等舱；4，头等和商务舱；5，经济和商务舱；6，经济和头等舱<br /> 支持最大值为：6<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> CabinClass { get; set; }

        /// <summary>
        /// 出发城市三字码<br /> 支持最大长度为：3<br /> 支持的最大列表长度为：3
        /// </summary>
        public string DepCityCode { get; set; }

        /// <summary>
        /// 航班日期：格式要求 "yyyy-MM-dd"<br /> 支持最大长度为：10<br /> 支持的最大列表长度为：10
        /// </summary>
        public string DepDate { get; set; }

        /// <summary>
        /// 指定航班号：获取指定航班低价舱位列表或者获取指定航班高大上舱位折扣使用<br /> 支持最大长度为：7<br /> 支持的最大列表长度为：7
        /// </summary>
        public string FlightNo { get; set; }

        /// <summary>
        /// 1-9分别表示乘机人数为1-9；乘机人数小于0即相当无限制，默认值-1<br /> 支持最大值为：9<br /> 支持最小值为：-1
        /// </summary>
        public Nullable<long> PassengerNum { get; set; }

        /// <summary>
        /// 淘宝推广者pid
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 搜索类型：支持三个类型，1. outbound，表示搜索航段最低价，每个航班一个最低价；2. lowprice，表示搜索指定航班topN最低价；3. gaoduan，表示搜索指定航班下高端大气上档次价格列表<br /> 支持最大长度为：10<br /> 支持的最大列表长度为：10
        /// </summary>
        public string SearchType { get; set; }

        /// <summary>
        /// 是否提供报销凭证(行程单),0.不提供和提供报销凭证的都查询出来,1.只查询提供报销凭证的<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> SupplyItinerary { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trip.jipiao.nsearch.ow.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("arr_city_code", this.ArrCityCode);
            parameters.Add("cabin_class", this.CabinClass);
            parameters.Add("dep_city_code", this.DepCityCode);
            parameters.Add("dep_date", this.DepDate);
            parameters.Add("flight_no", this.FlightNo);
            parameters.Add("passenger_num", this.PassengerNum);
            parameters.Add("pid", this.Pid);
            parameters.Add("search_type", this.SearchType);
            parameters.Add("supply_itinerary", this.SupplyItinerary);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("arr_city_code", this.ArrCityCode);
            RequestValidator.ValidateMaxLength("arr_city_code", this.ArrCityCode, 3);
            RequestValidator.ValidateMaxValue("cabin_class", this.CabinClass, 6);
            RequestValidator.ValidateMinValue("cabin_class", this.CabinClass, 0);
            RequestValidator.ValidateRequired("dep_city_code", this.DepCityCode);
            RequestValidator.ValidateMaxLength("dep_city_code", this.DepCityCode, 3);
            RequestValidator.ValidateRequired("dep_date", this.DepDate);
            RequestValidator.ValidateMaxLength("dep_date", this.DepDate, 10);
            RequestValidator.ValidateMaxLength("flight_no", this.FlightNo, 7);
            RequestValidator.ValidateMaxValue("passenger_num", this.PassengerNum, 9);
            RequestValidator.ValidateMinValue("passenger_num", this.PassengerNum, -1);
            RequestValidator.ValidateMaxLength("search_type", this.SearchType, 10);
            RequestValidator.ValidateMinValue("supply_itinerary", this.SupplyItinerary, 0);
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
