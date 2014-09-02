using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.room.img.delete
    /// </summary>
    public class HotelRoomImgDeleteRequest : ITopRequest<HotelRoomImgDeleteResponse>
    {
        /// <summary>
        /// 酒店房间商品gid。必须为数字。
        /// </summary>
        public Nullable<long> Gid { get; set; }

        /// <summary>
        /// 图片序号，可选值：1，2，3，4，5。  如果原图片个数小于等于1，则报错，不能删除图片。  如果原图片个数小于待删除的图片序号，则报错，图片序号错误。<br /> 支持的最大列表长度为：1
        /// </summary>
        public Nullable<long> Position { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.room.img.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("gid", this.Gid);
            parameters.Add("position", this.Position);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("gid", this.Gid);
            RequestValidator.ValidateRequired("position", this.Position);
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
