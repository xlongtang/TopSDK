using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.media.file.add
    /// </summary>
    public class MediaFileAddRequest : ITopUploadRequest<MediaFileAddResponse>
    {
        /// <summary>
        /// 接入多媒体平台的业务code 每个应用有一个特有的业务code
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 文件属于的那个目录的目录编号<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> DirId { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        public Nullable<long> Ext { get; set; }

        /// <summary>
        /// 文件
        /// </summary>
        public FileItem FileData { get; set; }

        /// <summary>
        /// 上传文件的名称<br /> 支持最大长度为：50<br /> 支持的最大列表长度为：50
        /// </summary>
        public string Name { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.media.file.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("dir_id", this.DirId);
            parameters.Add("ext", this.Ext);
            parameters.Add("name", this.Name);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("dir_id", this.DirId);
            RequestValidator.ValidateMinValue("dir_id", this.DirId, 0);
            RequestValidator.ValidateRequired("file_data", this.FileData);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 50);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file_data", this.FileData);
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
