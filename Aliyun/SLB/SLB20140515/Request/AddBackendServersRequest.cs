using System;
using System.Collections.Generic;
using Aliyun.Api.SLB.SLB20140515.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.SLB.SLB20140515.Request
{	
    
    /// <summary>
    /// TOP API: slb.aliyuncs.com.AddBackendServers.2014-05-15
    /// </summary>
    public class AddBackendServersRequest : IAliyunRequest<AddBackendServersResponse>
    {
        /// <summary>
        /// BackendServers 数组格式，需要添加的后端服务器列表，最多20个
        /// </summary>
        public string BackendServers { get; set; }

        /// <summary>
        /// slb id
        /// </summary>
        public string LoadBalancerId { get; set; }

    
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
            return "slb.aliyuncs.com.AddBackendServers.2014-05-15";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("BackendServers", this.BackendServers);
            parameters.Add("LoadBalancerId", this.LoadBalancerId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("LoadBalancerId", this.LoadBalancerId);
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
