using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.videos.search
    /// </summary>
    public class VideosSearchRequest : ITopRequest<VideosSearchResponse>
    {
        /// <summary>
        /// 页码。默认返回的数据是从第一页开始
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 需要返回的视频对象字段。VideoItem结构体中所有字段均可返回；多个字段用“,”分隔；其中video_play_info中的播放url可选择性返回，其余属性全部返回；如果想返回整个子对象中所有url，那字段为video_play_info，如果是想返回子对象里面的字段，那字段为video_play_info.web_url。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 关键字(标题or标签，不能同时设置title,tag，否则冲突)
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// 每页条数，默认值是12
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 视频状态列表；视频状态：等待转码（1），转码中（2），转码失败（3），等待审核（4），未通过审核（5），通过审核（6）
        /// </summary>
        public string States { get; set; }

        /// <summary>
        /// 视频标签
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 视频标题
        /// </summary>
        public string Title { get; set; }

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
            return "taobao.videos.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("fields", this.Fields);
            parameters.Add("keywords", this.Keywords);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("states", this.States);
            parameters.Add("tag", this.Tag);
            parameters.Add("title", this.Title);
            parameters.Add("uploader_id", this.UploaderId);
            parameters.Add("video_app_key", this.VideoAppKey);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxListSize("states", this.States, 10);
            RequestValidator.ValidateMaxLength("tag", this.Tag, 256);
            RequestValidator.ValidateMaxLength("title", this.Title, 256);
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
