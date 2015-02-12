using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.image.upload
    /// </summary>
    public class HotelImageUploadRequest : ITopUploadRequest<HotelImageUploadResponse>
    {
        /// <summary>
        /// 酒店id
        /// </summary>
        public Nullable<long> Hid { get; set; }

        /// <summary>
        /// 上传的图片
        /// </summary>
        public FileItem Pic { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.image.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("hid", this.Hid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("hid", this.Hid);
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
