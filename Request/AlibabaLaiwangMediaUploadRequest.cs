using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.laiwang.media.upload
    /// </summary>
    public class AlibabaLaiwangMediaUploadRequest : ITopUploadRequest<AlibabaLaiwangMediaUploadResponse>
    {
        /// <summary>
        /// 需要上传的文件内容.
        /// </summary>
        public FileItem Media { get; set; }

        /// <summary>
        /// 多媒体文件类型，目前支持: image(图片),audio(音频),video(视频)
        /// </summary>
        public string Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alibaba.laiwang.media.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("media", this.Media);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("media", this.Media);
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
