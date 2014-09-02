using System;
using System.Collections.Generic;
using Aliyun.Api.BSS.BSS20140714.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.BSS.BSS20140714.Request
{	
    
    /// <summary>
    /// TOP API: bss.aliyuncs.com.SetResourceBusinessStatus.2014-07-14
    /// </summary>
    public class SetResourceBusinessStatusRequest : IAliyunRequest<SetResourceBusinessStatusResponse>
    {
        /// <summary>
        /// 操作类型  expired:过期状态  normal:正常状态
        /// </summary>
        public string BusinessStatus { get; set; }

        /// <summary>
        /// 要操作的实例Id可创建多实例的服务，需要填写此参数。
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// 要操作的资源的类型。
        /// </summary>
        public string ResourceType { get; set; }

    
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
            return "bss.aliyuncs.com.SetResourceBusinessStatus.2014-07-14";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("BusinessStatus", this.BusinessStatus);
            parameters.Add("ResourceId", this.ResourceId);
            parameters.Add("ResourceType", this.ResourceType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("BusinessStatus", this.BusinessStatus);
            RequestValidator.ValidateRequired("ResourceId", this.ResourceId);
            RequestValidator.ValidateRequired("ResourceType", this.ResourceType);
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
