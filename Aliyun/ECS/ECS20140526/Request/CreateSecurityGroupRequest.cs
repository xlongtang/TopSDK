using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.CreateSecurityGroup.2014-05-26
    /// </summary>
    public class CreateSecurityGroupRequest : IAliyunRequest<CreateSecurityGroupResponse>
    {
        /// <summary>
        /// 用于保证请求的幂等性。由客户端生成该参数值，要保证在不同请求间唯一，最大不值过64个ASCII字符。 具体参见附录：如何保证幂等性。
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// 安全组描述信息，长度限制在500个字节，不支持中文
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 安全组所属Region ID
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// 安全组名称
        /// </summary>
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// 虚拟网络类型实例组成的安全组，需要指定安全组所在的虚拟网络ID
        /// </summary>
        public string VpcId { get; set; }

    
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
            return "ecs.aliyuncs.com.CreateSecurityGroup.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("ClientToken", this.ClientToken);
            parameters.Add("Description", this.Description);
            parameters.Add("RegionId", this.RegionId);
            parameters.Add("SecurityGroupName", this.SecurityGroupName);
            parameters.Add("VpcId", this.VpcId);
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
