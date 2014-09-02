using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.video.update
    /// </summary>
    public class VideoUpdateRequest : ITopRequest<VideoUpdateResponse>
    {
        /// <summary>
        /// 视频封面url,不能超过512个英文字母
        /// </summary>
        public string CoverUrl { get; set; }

        /// <summary>
        /// 视频描述信息，不能超过256个汉字
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 视频标签，以','隔开，且总长度不超过128个汉字
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 视频标题，不超过128个汉字。title, tags,cover_url和description至少必须传一个
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 在淘宝视频中的应用key，该值向淘宝视频申请产生
        /// </summary>
        public Nullable<long> VideoAppKey { get; set; }

        /// <summary>
        /// 视频id
        /// </summary>
        public Nullable<long> VideoId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.video.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cover_url", this.CoverUrl);
            parameters.Add("description", this.Description);
            parameters.Add("tags", this.Tags);
            parameters.Add("title", this.Title);
            parameters.Add("video_app_key", this.VideoAppKey);
            parameters.Add("video_id", this.VideoId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("cover_url", this.CoverUrl, 512);
            RequestValidator.ValidateMaxLength("description", this.Description, 512);
            RequestValidator.ValidateMaxListSize("tags", this.Tags, 25);
            RequestValidator.ValidateMaxLength("tags", this.Tags, 256);
            RequestValidator.ValidateMaxLength("title", this.Title, 256);
            RequestValidator.ValidateRequired("video_app_key", this.VideoAppKey);
            RequestValidator.ValidateRequired("video_id", this.VideoId);
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
