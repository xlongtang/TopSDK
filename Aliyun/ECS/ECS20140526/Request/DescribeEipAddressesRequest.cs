using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.DescribeEipAddresses.2014-05-26
    /// </summary>
    public class DescribeEipAddressesRequest : IAliyunRequest<DescribeEipAddressesResponse>
    {
        /// <summary>
        /// 申请Id
        /// </summary>
        public string AllocationId { get; set; }

        /// <summary>
        /// 弹性IP地址
        /// </summary>
        public string EipAddress { get; set; }

        /// <summary>
        /// 实例状态列表的页码，起始值为1，默认值为1<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageNumber { get; set; }

        /// <summary>
        /// 分页查询时设置的每页行数，最大值50行，默认为10<br /> 支持最大值为：50
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 需要查询的地域
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// Eip状态，单选 InUse | Available
        /// </summary>
        public string Status { get; set; }

    
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
            return "ecs.aliyuncs.com.DescribeEipAddresses.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("AllocationId", this.AllocationId);
            parameters.Add("EipAddress", this.EipAddress);
            parameters.Add("PageNumber", this.PageNumber);
            parameters.Add("PageSize", this.PageSize);
            parameters.Add("RegionId", this.RegionId);
            parameters.Add("Status", this.Status);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("PageNumber", this.PageNumber, 1);
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
