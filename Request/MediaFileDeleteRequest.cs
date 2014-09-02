using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.media.file.delete
    /// </summary>
    public class MediaFileDeleteRequest : ITopRequest<MediaFileDeleteResponse>
    {
        /// <summary>
        /// 接入多媒体平台的业务code 每个应用有一个特有的业务code
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 文件ID字符串,可以一个也可以一组,用英文逗号间隔,如450,120,155
        /// </summary>
        public string FileIds { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.media.file.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("file_ids", this.FileIds);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("file_ids", this.FileIds);
            RequestValidator.ValidateMaxListSize("file_ids", this.FileIds, 50);
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
