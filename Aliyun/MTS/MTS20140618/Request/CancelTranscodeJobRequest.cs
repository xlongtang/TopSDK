using System;
using System.Collections.Generic;
using Aliyun.Api.MTS.MTS20140618.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.MTS.MTS20140618.Request
{	
    
    /// <summary>
    /// TOP API: mts.aliyuncs.com.CancelTranscodeJob.2014-06-18
    /// </summary>
    public class CancelTranscodeJobRequest : IAliyunRequest<CancelTranscodeJobResponse>
    {
        /// <summary>
        /// 媒资ID
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// 转码模板ID
        /// </summary>
        public string TemplateId { get; set; }

    
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
            return "mts.aliyuncs.com.CancelTranscodeJob.2014-06-18";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("MediaId", this.MediaId);
            parameters.Add("TemplateId", this.TemplateId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("MediaId", this.MediaId);
            RequestValidator.ValidateRequired("TemplateId", this.TemplateId);
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
