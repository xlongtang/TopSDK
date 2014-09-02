using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.ModifyInstanceAttribute.2014-05-26
    /// </summary>
    public class ModifyInstanceAttributeRequest : IAliyunRequest<ModifyInstanceAttributeResponse>
    {
        /// <summary>
        /// 实例说明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 表示实例的主机名。必须以字母开始，并只可以含有字母、“-”字符。Windows系统最长为15字节，Linux系统最长为30字节
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// 指定的实例ID
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// 重置为用户指定的密码，密码只能是数字或者英文  字母。长度必须在6~30个英文字符
        /// </summary>
        public string Password { get; set; }

    
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
            return "ecs.aliyuncs.com.ModifyInstanceAttribute.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("Description", this.Description);
            parameters.Add("HostName", this.HostName);
            parameters.Add("InstanceId", this.InstanceId);
            parameters.Add("InstanceName", this.InstanceName);
            parameters.Add("Password", this.Password);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("InstanceId", this.InstanceId);
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
