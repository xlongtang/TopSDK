using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.video.add
    /// </summary>
    public class VideoAddRequest : ITopRequest<VideoAddResponse>
    {
        /// <summary>
        /// 视频封面url,不能为空且不能超过512个英文字母
        /// </summary>
        public string CoverUrl { get; set; }

        /// <summary>
        /// 视频描述信息，不能为空且不能超过256个汉字
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 视频标签，以','隔开，不能为空且总长度不超过128个汉字
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 视频标题，不能为空且不超过128个汉字
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 上传唯一识别符,上传id
        /// </summary>
        public string UploadId { get; set; }

        /// <summary>
        /// 视频上传者数字id
        /// </summary>
        public Nullable<long> UploaderId { get; set; }

        /// <summary>
        /// 在淘宝视频中的应用key，该值向淘宝视频申请产生
        /// </summary>
        public Nullable<long> VideoAppKey { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.video.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cover_url", this.CoverUrl);
            parameters.Add("description", this.Description);
            parameters.Add("tags", this.Tags);
            parameters.Add("title", this.Title);
            parameters.Add("upload_id", this.UploadId);
            parameters.Add("uploader_id", this.UploaderId);
            parameters.Add("video_app_key", this.VideoAppKey);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cover_url", this.CoverUrl);
            RequestValidator.ValidateMaxLength("cover_url", this.CoverUrl, 512);
            RequestValidator.ValidateRequired("description", this.Description);
            RequestValidator.ValidateMaxLength("description", this.Description, 512);
            RequestValidator.ValidateRequired("tags", this.Tags);
            RequestValidator.ValidateMaxListSize("tags", this.Tags, 25);
            RequestValidator.ValidateMaxLength("tags", this.Tags, 256);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 256);
            RequestValidator.ValidateRequired("upload_id", this.UploadId);
            RequestValidator.ValidateRequired("uploader_id", this.UploaderId);
            RequestValidator.ValidateRequired("video_app_key", this.VideoAppKey);
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
