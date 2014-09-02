using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20130110.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20130110.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.RevokeSecurityGroup.2013-01-10
    /// </summary>
    public class RevokeSecurityGroupRequest : IAliyunRequest<RevokeSecurityGroupResponse>
    {
        /// <summary>
        /// P 协议，取值：tcp|udp|icmp|gre|all；   All 表示同时支持四种协议
        /// </summary>
        public string IpProtocol { get; set; }

        /// <summary>
        /// 网络类型，取值：internet|intranet；   默认值为internet
        /// </summary>
        public string NicType { get; set; }

        /// <summary>
        /// 授权策略，参数值可为：accept（接受访问）、  drop（访问时丢弃包）、reject（访问时拒  绝包）   默认值为：accept
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// IP 协议相关的端口号范围，tcp、udp协议  的默认端口号，取值范围为1~65535；例  如“1/200”意思是端口号范围为1~200，  若输入值为：“200/1”接口调用将报错。   icmp 协议时端口号范围值为-1/-1，gre协  议时端口号范围值为-1/-1，当  IpProtocol为all时端口号范围值为-1/-1；取值范围
        /// </summary>
        public string PortRange { get; set; }

        /// <summary>
        /// 安全组所属Region ID
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// 安全组编码
        /// </summary>
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 授权可访问目标安全组的源IP 地址范围  （采用CIDR格式来指定IP 地址范围），  默认值为0.0.0.0/0（表示不受限制），其  他支持的格式如10.159.6.18/12、  10.159.6.186、或  10.159.6.186-10.159.6.201（IP 区间）
        /// </summary>
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// 授权同一Region内可访问目标安全组的源  安全组编码，SourceGroupId或者  SourceCidrIp参数必须设置一项，如果  两项都设置，则默认对SourceCidrIp授  权。指定了该字段之后，NicType只能选  择intranet
        /// </summary>
        public string SourceGroupId { get; set; }

    
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
            return "ecs.aliyuncs.com.RevokeSecurityGroup.2013-01-10";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("IpProtocol", this.IpProtocol);
            parameters.Add("NicType", this.NicType);
            parameters.Add("Policy", this.Policy);
            parameters.Add("PortRange", this.PortRange);
            parameters.Add("RegionId", this.RegionId);
            parameters.Add("SecurityGroupId", this.SecurityGroupId);
            parameters.Add("SourceCidrIp", this.SourceCidrIp);
            parameters.Add("SourceGroupId", this.SourceGroupId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("IpProtocol", this.IpProtocol);
            RequestValidator.ValidateRequired("PortRange", this.PortRange);
            RequestValidator.ValidateRequired("RegionId", this.RegionId);
            RequestValidator.ValidateRequired("SecurityGroupId", this.SecurityGroupId);
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
