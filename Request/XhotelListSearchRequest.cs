using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.xhotel.list.search
    /// </summary>
    public class XhotelListSearchRequest : ITopRequest<XhotelListSearchResponse>
    {
        /// <summary>
        /// 入住时间，默认值为当前时间加3天
        /// </summary>
        public Nullable<DateTime> CheckIn { get; set; }

        /// <summary>
        /// 离店日期，默认值为当前时间加4天
        /// </summary>
        public Nullable<DateTime> CheckOut { get; set; }

        /// <summary>
        /// 城市编码，需通过taobao.xhotel.city.get接口获取
        /// </summary>
        public Nullable<long> CityCode { get; set; }

        /// <summary>
        /// 城市名称，需通过taobao.xhotel.city.get接口获取
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// 分页参数：当前页数，从1开始计数。  默认值：1
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 酒店星级/档次。  五星/豪华:5  四星/高档:4  三星/舒适:3  二星及以下：2  经济连锁：1  客栈公寓:0  支持设置多个档次，多个档次用","隔开，如5,4,3
        /// </summary>
        public string Dangcis { get; set; }

        /// <summary>
        /// 排序方向。  从高往低: DESC  从低往高: ASC。  默认值为DESC  注意：如果按距离排序，设置此参数无效。如果按距离排序，则按离搜索中心点从近到远的顺序返回酒店列表，不需要再设置dir参数。
        /// </summary>
        public string Dir { get; set; }

        /// <summary>
        /// 指定价格范围搜索时的最高价，单位：元。
        /// </summary>
        public Nullable<long> HighPrice { get; set; }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 指定价格范围搜索时的最低价，单位：元。
        /// </summary>
        public Nullable<long> LowPrice { get; set; }

        /// <summary>
        /// 排序方式。  默认排序：DEFAULT   按销量排序：SALESCOUNT   按价格排序：PRICE  按照距离排序：DISTANCE。  注意：如果按距离排序，则按离搜索中心点从近到远的顺序返回酒店列表，不需要再设置dir参数。
        /// </summary>
        public string Order { get; set; }

        /// <summary>
        /// 分页参数：每页酒店数量。最小值1，最大值为20。默认值：20
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// pid
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 地图搜的半径，单位:米。默认值为5000米，允许的最大值为50000米。<br /> 支持最大值为：50000<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> Radius { get; set; }

        /// <summary>
        /// 地图搜时中心点的经度。注意：如果设置此参数，则参数radius_lng也必须设置。
        /// </summary>
        public string RadiusLat { get; set; }

        /// <summary>
        /// 地图搜索时中心点的经度。注意：如果设置此参数，则参数radius_lat也必须设置。
        /// </summary>
        public string RadiusLng { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.xhotel.list.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("check_in", this.CheckIn);
            parameters.Add("check_out", this.CheckOut);
            parameters.Add("city_code", this.CityCode);
            parameters.Add("city_name", this.CityName);
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("dangcis", this.Dangcis);
            parameters.Add("dir", this.Dir);
            parameters.Add("high_price", this.HighPrice);
            parameters.Add("keywords", this.Keywords);
            parameters.Add("low_price", this.LowPrice);
            parameters.Add("order", this.Order);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("pid", this.Pid);
            parameters.Add("radius", this.Radius);
            parameters.Add("radius_lat", this.RadiusLat);
            parameters.Add("radius_lng", this.RadiusLng);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("radius", this.Radius, 50000);
            RequestValidator.ValidateMinValue("radius", this.Radius, 1);
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
