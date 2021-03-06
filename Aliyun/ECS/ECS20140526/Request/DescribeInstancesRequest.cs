using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.DescribeInstances.2014-05-26
    /// </summary>
    public class DescribeInstancesRequest : IAliyunRequest<DescribeInstancesResponse>
    {
        /// <summary>
        /// 实例网络类型
        /// </summary>
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// 实例状态列表的页码，起始值为1，默认值为1
        /// </summary>
        public Nullable<long> PageNumber { get; set; }

        /// <summary>
        /// 分页查询时设置的每页行数，最大值50行，默认为10<br /> 支持最大值为：50
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 区域Id
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// 安全组Id
        /// </summary>
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 虚拟交换机Id
        /// </summary>
        public string VSwitchId { get; set; }

        /// <summary>
        /// 虚拟专有网络Id
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// 可用区Id
        /// </summary>
        public string ZoneId { get; set; }

    
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
            return "ecs.aliyuncs.com.DescribeInstances.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("InstanceNetworkType", this.InstanceNetworkType);
            parameters.Add("PageNumber", this.PageNumber);
            parameters.Add("PageSize", this.PageSize);
            parameters.Add("RegionId", this.RegionId);
            parameters.Add("SecurityGroupId", this.SecurityGroupId);
            parameters.Add("VSwitchId", this.VSwitchId);
            parameters.Add("VpcId", this.VpcId);
            parameters.Add("ZoneId", this.ZoneId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("PageSize", this.PageSize, 50);
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
