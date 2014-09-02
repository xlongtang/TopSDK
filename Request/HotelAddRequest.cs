using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.add
    /// </summary>
    public class HotelAddRequest : ITopUploadRequest<HotelAddResponse>
    {
        /// <summary>
        /// 酒店地址。长度不能超过120<br /> 支持最大长度为：120<br /> 支持的最大列表长度为：120
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 城市编码。参见：http://kezhan.trip.taobao.com/area.html，domestic为false时，输入对应国家的海外城市编码，可调用海外城市查询接口获取<br /> 支持最大值为：999999<br /> 支持最小值为：0<br /> 支持的最大列表长度为：6
        /// </summary>
        public Nullable<long> City { get; set; }

        /// <summary>
        /// domestic为true时，固定China；  domestic为false时，必须传定义的海外国家编码值。参见：http://kezhan.trip.taobao.com/countrys.html
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 装修年份。长度不能超过4。<br /> 支持最大长度为：4<br /> 支持的最大列表长度为：4
        /// </summary>
        public string DecorateTime { get; set; }

        /// <summary>
        /// 酒店介绍。不超过25000个汉字<br /> 支持最大长度为：50000<br /> 支持的最大列表长度为：50000
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 区域（县级市）编码。参见：http://kezhan.trip.taobao.com/area.html<br /> 支持最大值为：999999<br /> 支持最小值为：0<br /> 支持的最大列表长度为：6
        /// </summary>
        public Nullable<long> District { get; set; }

        /// <summary>
        /// 是否国内酒店。可选值：true，false
        /// </summary>
        public Nullable<bool> Domestic { get; set; }

        /// <summary>
        /// 酒店级别。可选值：A,B,C,D,E,F。代表客栈公寓、经济连锁、二星级/以下、三星级/舒适、四星级/高档、五星级/豪华<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// 酒店名称。不能超过60<br /> 支持最大长度为：60<br /> 支持的最大列表长度为：60
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 开业年份。长度不能超过4。<br /> 支持最大长度为：4<br /> 支持的最大列表长度为：4
        /// </summary>
        public string OpeningTime { get; set; }

        /// <summary>
        /// 酒店定位。可选值：T,B。代表旅游度假、商务出行<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string Orientation { get; set; }

        /// <summary>
        /// 酒店图片。最大长度:500K。支持的文件类型：gif,jpg,png<br /> 支持的文件类型为：jpg,png,gif<br /> 支持的最大列表长度为：512000
        /// </summary>
        public FileItem Pic { get; set; }

        /// <summary>
        /// 省份编码。参见：http://kezhan.trip.taobao.com/area.html，domestic为false时默认为0<br /> 支持最大值为：999999<br /> 支持最小值为：0<br /> 支持的最大列表长度为：6
        /// </summary>
        public Nullable<long> Province { get; set; }

        /// <summary>
        /// 房间数。长度不能超过4。<br /> 支持最大值为：9999<br /> 支持最小值为：0<br /> 支持的最大列表长度为：4
        /// </summary>
        public Nullable<long> Rooms { get; set; }

        /// <summary>
        /// 交通距离与设施服务。JSON格式。cityCenterDistance、railwayDistance、airportDistance分别代表距离市中心、距离火车站、距离机场公里数，为不超过3位正整数，默认-1代表无数据。  其他key值true代表有此服务，false代表没有。  parking：停车场，airportShuttle：机场接送，rentCar：租车，meetingRoom：会议室，businessCenter：商务中心，swimmingPool：游泳池，fitnessClub：健身中心，laundry：洗衣服务，morningCall：叫早服务，bankCard：接受银行卡，creditCard：接受信用卡，chineseRestaurant：中餐厅，westernRestaurant：西餐厅，cafe：咖啡厅，bar：酒吧，ktv：KTV。
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// 接入卖家数据主键<br /> 支持最大长度为：100<br /> 支持的最大列表长度为：100
        /// </summary>
        public string SiteParam { get; set; }

        /// <summary>
        /// 楼层数。长度不能超过4。<br /> 支持最大值为：9999<br /> 支持最小值为：0<br /> 支持的最大列表长度为：4
        /// </summary>
        public Nullable<long> Storeys { get; set; }

        /// <summary>
        /// 酒店电话。格式：国家代码（最长6位）#区号（最长4位）#电话（最长20位）。国家代码提示：中国大陆0086、香港00852、澳门00853、台湾00886<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string Tel { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("address", this.Address);
            parameters.Add("city", this.City);
            parameters.Add("country", this.Country);
            parameters.Add("decorate_time", this.DecorateTime);
            parameters.Add("desc", this.Desc);
            parameters.Add("district", this.District);
            parameters.Add("domestic", this.Domestic);
            parameters.Add("level", this.Level);
            parameters.Add("name", this.Name);
            parameters.Add("opening_time", this.OpeningTime);
            parameters.Add("orientation", this.Orientation);
            parameters.Add("province", this.Province);
            parameters.Add("rooms", this.Rooms);
            parameters.Add("service", this.Service);
            parameters.Add("site_param", this.SiteParam);
            parameters.Add("storeys", this.Storeys);
            parameters.Add("tel", this.Tel);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("address", this.Address);
            RequestValidator.ValidateMaxLength("address", this.Address, 120);
            RequestValidator.ValidateRequired("city", this.City);
            RequestValidator.ValidateMaxValue("city", this.City, 999999);
            RequestValidator.ValidateMinValue("city", this.City, 0);
            RequestValidator.ValidateRequired("country", this.Country);
            RequestValidator.ValidateMaxLength("decorate_time", this.DecorateTime, 4);
            RequestValidator.ValidateRequired("desc", this.Desc);
            RequestValidator.ValidateMaxLength("desc", this.Desc, 50000);
            RequestValidator.ValidateMaxValue("district", this.District, 999999);
            RequestValidator.ValidateMinValue("district", this.District, 0);
            RequestValidator.ValidateRequired("domestic", this.Domestic);
            RequestValidator.ValidateRequired("level", this.Level);
            RequestValidator.ValidateMaxLength("level", this.Level, 1);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 60);
            RequestValidator.ValidateMaxLength("opening_time", this.OpeningTime, 4);
            RequestValidator.ValidateRequired("orientation", this.Orientation);
            RequestValidator.ValidateMaxLength("orientation", this.Orientation, 1);
            RequestValidator.ValidateRequired("pic", this.Pic);
            RequestValidator.ValidateMaxLength("pic", this.Pic, 512000);
            RequestValidator.ValidateRequired("province", this.Province);
            RequestValidator.ValidateMaxValue("province", this.Province, 999999);
            RequestValidator.ValidateMinValue("province", this.Province, 0);
            RequestValidator.ValidateMaxValue("rooms", this.Rooms, 9999);
            RequestValidator.ValidateMinValue("rooms", this.Rooms, 0);
            RequestValidator.ValidateMaxLength("site_param", this.SiteParam, 100);
            RequestValidator.ValidateMaxValue("storeys", this.Storeys, 9999);
            RequestValidator.ValidateMinValue("storeys", this.Storeys, 0);
            RequestValidator.ValidateMaxLength("tel", this.Tel, 32);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("pic", this.Pic);
            return parameters;
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
