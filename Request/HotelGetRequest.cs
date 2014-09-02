using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.get
    /// </summary>
    public class HotelGetRequest : ITopRequest<HotelGetResponse>
    {
        /// <summary>
        /// true表示查询酒店审核状态，false表示查询已审核通过酒店详细信息
        /// </summary>
        public Nullable<bool> CheckAudit { get; set; }

        /// <summary>
        /// 要查询的酒店id。必须为数字
        /// </summary>
        public Nullable<long> Hid { get; set; }

        /// <summary>
        /// 是否需要返回该酒店的房型列表。可选值：true，false。
        /// </summary>
        public Nullable<bool> NeedRoomType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("check_audit", this.CheckAudit);
            parameters.Add("hid", this.Hid);
            parameters.Add("need_room_type", this.NeedRoomType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("hid", this.Hid);
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
