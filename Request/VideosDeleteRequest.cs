using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.videos.delete
    /// </summary>
    public class VideosDeleteRequest : ITopRequest<VideosDeleteResponse>
    {
        /// <summary>
        /// 在淘宝视频中的应用key，该值向淘宝视频申请产生
        /// </summary>
        public Nullable<long> VideoAppKey { get; set; }

        /// <summary>
        /// 视频id列表
        /// </summary>
        public string VideoIds { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.videos.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("video_app_key", this.VideoAppKey);
            parameters.Add("video_ids", this.VideoIds);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("video_app_key", this.VideoAppKey);
            RequestValidator.ValidateRequired("video_ids", this.VideoIds);
            RequestValidator.ValidateMaxListSize("video_ids", this.VideoIds, 100);
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
