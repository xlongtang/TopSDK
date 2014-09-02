using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weitao.cloudtags.group.custom.add
    /// </summary>
    public class WeitaoCloudtagsGroupCustomAddRequest : ITopUploadRequest<WeitaoCloudtagsGroupCustomAddResponse>
    {
        /// <summary>
        /// 所要创建自定义分组的描述<br /> 支持最大长度为：256<br /> 支持的最大列表长度为：256
        /// </summary>
        public string GroupDesc { get; set; }

        /// <summary>
        /// 想要创建的自定义分组名称<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 上传的文件内容转换成的字节数组。文件需要使用UTF-8编码方式编写。其中内容为用户id或手机号用英文逗号连接起来的单行文本。<br /> 支持的最大列表长度为：2097152
        /// </summary>
        public FileItem UserListFileContent { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.weitao.cloudtags.group.custom.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_desc", this.GroupDesc);
            parameters.Add("group_name", this.GroupName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("group_desc", this.GroupDesc);
            RequestValidator.ValidateMaxLength("group_desc", this.GroupDesc, 256);
            RequestValidator.ValidateRequired("group_name", this.GroupName);
            RequestValidator.ValidateMaxLength("group_name", this.GroupName, 32);
            RequestValidator.ValidateRequired("user_list_file_content", this.UserListFileContent);
            RequestValidator.ValidateMaxLength("user_list_file_content", this.UserListFileContent, 2097152);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("user_list_file_content", this.UserListFileContent);
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
