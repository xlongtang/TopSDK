using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.room.img.upload
    /// </summary>
    public class HotelRoomImgUploadRequest : ITopUploadRequest<HotelRoomImgUploadResponse>
    {
        /// <summary>
        /// 酒店房间商品gid。必须为数字。
        /// </summary>
        public Nullable<long> Gid { get; set; }

        /// <summary>
        /// 酒店商品图片。类型:JPG,GIF;最大长度:500K。支持的文件类型：gif,jpg,jpeg,png。  如果原图片少于5张，若没传序号或序号大于原图片个数，则在原图片最后添加，否则按序号插入到原图片中去，自动后移。  如果原图片大于5张，若没传序号，则替换最后一张图片，否则在序号位置插入，图片向后移，最后一张被删除。<br /> 支持的文件类型为：jpg,png,gif<br /> 支持的最大列表长度为：512000
        /// </summary>
        public FileItem Pic { get; set; }

        /// <summary>
        /// 图片序号，可选值：1，2，3，4，5<br /> 支持的最大列表长度为：1
        /// </summary>
        public Nullable<long> Position { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.room.img.upload";
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
            RequestValidator.ValidateRequired("pic", this.Pic);
            RequestValidator.ValidateMaxLength("pic", this.Pic, 512000);
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
