using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.AllocateEipAddress.2014-05-26
    /// </summary>
    public class AllocateEipAddressRequest : IAliyunRequest<AllocateEipAddressResponse>
    {
        /// <summary>
        /// 弹性IP地址的限速，如果不指定，默认为5Mbps
        /// </summary>
        public string Bandwidth { get; set; }

        /// <summary>
        /// PayByBandwidth 和 PayByTraffic，默认是PayByBandwidth
        /// </summary>
        public string InternetChargeType { get; set; }

        /// <summary>
        /// 申请的弹性IP地址所在的地域
        /// </summary>
        public string RegionId { get; set; }

    
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
            return "ecs.aliyuncs.com.AllocateEipAddress.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("Bandwidth", this.Bandwidth);
            parameters.Add("InternetChargeType", this.InternetChargeType);
            parameters.Add("RegionId", this.RegionId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("RegionId", this.RegionId);
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
