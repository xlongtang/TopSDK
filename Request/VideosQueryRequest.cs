using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.videos.query
    /// </summary>
    public class VideosQueryRequest : ITopRequest<VideosQueryResponse>
    {
        /// <summary>
        /// 需要返回的视频对象字段。VideoItem结构体中所有字段均可返回；多个字段用“,”分隔；其中video_play_info中的播放url可选择性返回，其余属性全部返回；如果想返回整个子对象中所有url，那字段为video_play_info，如果是想返回子对象里面的字段，那字段为video_play_info.web_url。
        /// </summary>
        public string Fields { get; set; }

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
            return "taobao.videos.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("video_app_key", this.VideoAppKey);
            parameters.Add("video_ids", this.VideoIds);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
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
