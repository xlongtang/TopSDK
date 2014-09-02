using System;
using System.Collections.Generic;
using Aliyun.Api.MTS.MTS20140618.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.MTS.MTS20140618.Request
{	
    
    /// <summary>
    /// TOP API: mts.aliyuncs.com.AddVideo.2014-06-18
    /// </summary>
    public class AddVideoRequest : IAliyunRequest<AddVideoResponse>
    {
        /// <summary>
        /// 视频的描述<br /> 支持最大长度为：512<br /> 支持的最大列表长度为：512
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 用户授权给视频服务访问的OSS Bucket下的视频文件地址<br /> 支持最大长度为：1152<br /> 支持的最大列表长度为：1152
        /// </summary>
        public string InputFileUrl { get; set; }

        /// <summary>
        /// 视频标签，如果有多个用逗号分隔<br /> 支持最大长度为：256<br /> 支持的最大列表长度为：256
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 视频标题<br /> 支持最大长度为：256<br /> 支持的最大列表长度为：256
        /// </summary>
        public string Title { get; set; }

    
    	/// <summary>
    	///仅用于渠道商发起API调用时，指定访问的资源拥有者的ID
    	/// </summary>
        public string OwnerId { get; set; }
        
        /// <summary>
    	///仅用于渠道商发起API调用时，指定访问的资源拥有者的账号
    	/// </summary>
    	public string OwnerAccount { get; set; }
    	
    	/// <summary>
    	///API调用者试图通过API调用来访问别人拥有但已经授权给他的资源时，通过使用该参数来声明此次操作涉及到的资源是谁名下的.该参数仅官网用户可用
    	/// </summary>
    	public string ResourceOwnerAccount { get; set; }
    	
        private IDictionary<string, string> otherParameters;

        #region IAliyunRequest Members

        public string GetApiName()
        {
            return "mts.aliyuncs.com.AddVideo.2014-06-18";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("Description", this.Description);
            parameters.Add("InputFileUrl", this.InputFileUrl);
            parameters.Add("Tags", this.Tags);
            parameters.Add("Title", this.Title);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("Description", this.Description);
            RequestValidator.ValidateMaxLength("Description", this.Description, 512);
            RequestValidator.ValidateRequired("InputFileUrl", this.InputFileUrl);
            RequestValidator.ValidateMaxLength("InputFileUrl", this.InputFileUrl, 1152);
            RequestValidator.ValidateRequired("Tags", this.Tags);
            RequestValidator.ValidateMaxLength("Tags", this.Tags, 256);
            RequestValidator.ValidateRequired("Title", this.Title);
            RequestValidator.ValidateMaxLength("Title", this.Title, 256);
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
