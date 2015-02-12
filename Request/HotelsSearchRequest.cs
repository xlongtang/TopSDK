using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotels.search
    /// </summary>
    public class HotelsSearchRequest : ITopRequest<HotelsSearchResponse>
    {
        /// <summary>
        /// 城市编码。参见：http://kezhan.trip.taobao.com/area.html。  domestic为true时，province,city,district不能同时为空或为0
        /// </summary>
        public Nullable<long> City { get; set; }

        /// <summary>
        /// domestic为true时，固定China；  domestic为false时，必须传定义的海外国家编码值，是必填项。参见：http://kezhan.trip.taobao.com/countrys.html
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 区域（县级市）编码。参见：http://kezhan.trip.taobao.com/area.html。  domestic为true时，province,city,district不能同时为空或为0
        /// </summary>
        public Nullable<long> District { get; set; }

        /// <summary>
        /// 是否国内酒店。可选值：true，false
        /// </summary>
        public Nullable<bool> Domestic { get; set; }

        /// <summary>
        /// 酒店名称。不能超过60字节
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分页页码。取值范围，大于零的整数，默认值1，即返回第一页的数据。页面大小为20
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 省份编码。参见：http://kezhan.trip.taobao.com/area.html。  domestic为true时，province,city,district不能同时为空或为0
        /// </summary>
        public Nullable<long> Province { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotels.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("city", this.City);
            parameters.Add("country", this.Country);
            parameters.Add("district", this.District);
            parameters.Add("domestic", this.Domestic);
            parameters.Add("name", this.Name);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("province", this.Province);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("domestic", this.Domestic);
            RequestValidator.ValidateMaxLength("name", this.Name, 60);
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
