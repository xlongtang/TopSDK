using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.CreateRouteEntry.2014-05-26
    /// </summary>
    public class CreateRouteEntryRequest : IAliyunRequest<CreateRouteEntryResponse>
    {
        /// <summary>
        /// 用于保证请求的幂等性。由客户端生成该参数值，要保证在不同请求间唯一，最大不值过64个ASCII字符。
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// 新增路由条目的目的网段
        /// </summary>
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// 新增路由条目的下一跳实例ID
        /// </summary>
        public string NextHopId { get; set; }

        /// <summary>
        /// 默认值为Instance。可选值为Instance
        /// </summary>
        public string NextHopType { get; set; }

        /// <summary>
        /// 虚拟路由表Id
        /// </summary>
        public string RouteTableId { get; set; }

    
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
            return "ecs.aliyuncs.com.CreateRouteEntry.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("ClientToken", this.ClientToken);
            parameters.Add("DestinationCidrBlock", this.DestinationCidrBlock);
            parameters.Add("NextHopId", this.NextHopId);
            parameters.Add("NextHopType", this.NextHopType);
            parameters.Add("RouteTableId", this.RouteTableId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("DestinationCidrBlock", this.DestinationCidrBlock);
            RequestValidator.ValidateRequired("NextHopId", this.NextHopId);
            RequestValidator.ValidateRequired("RouteTableId", this.RouteTableId);
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
