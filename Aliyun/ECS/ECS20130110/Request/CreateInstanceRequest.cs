using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20130110.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20130110.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.CreateInstance.2013-01-10
    /// </summary>
    public class CreateInstanceRequest : IAliyunRequest<CreateInstanceResponse>
    {
        /// <summary>
        /// 用于保证请求的幂等性。由客户端生成该参数值，要保证在不同请求间唯一，最大不值过64个ASCII字符。  具体参见附录：如何保证幂等性。
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// 数据盘1类型。
        /// </summary>
        public string DataDisk1Category { get; set; }

        /// <summary>
        /// 数据盘1大小
        /// </summary>
        public Nullable<long> DataDisk1Size { get; set; }

        /// <summary>
        /// 数据盘1快照
        /// </summary>
        public string DataDisk1SnapshotId { get; set; }

        /// <summary>
        /// 数据盘2类型
        /// </summary>
        public string DataDisk2Category { get; set; }

        /// <summary>
        /// 数据盘2大小
        /// </summary>
        public Nullable<long> DataDisk2Size { get; set; }

        /// <summary>
        /// 数据盘2快照
        /// </summary>
        public string DataDisk2SnapshotId { get; set; }

        /// <summary>
        /// 数据盘3类型
        /// </summary>
        public string DataDisk3Category { get; set; }

        /// <summary>
        /// 数据盘3大小
        /// </summary>
        public Nullable<long> DataDisk3Size { get; set; }

        /// <summary>
        /// 数据盘3快照
        /// </summary>
        public string DataDisk3SnapshotId { get; set; }

        /// <summary>
        /// 数据盘4类型
        /// </summary>
        public string DataDisk4Category { get; set; }

        /// <summary>
        /// 数据盘4大小
        /// </summary>
        public Nullable<long> DataDisk4Size { get; set; }

        /// <summary>
        /// 数据盘4快照
        /// </summary>
        public string DataDisk4SnapshotId { get; set; }

        /// <summary>
        /// 表示云服务器的主机名，最少2字符，“.”和“-”是不能作为hostname的首尾字符，不能连续使用。  Windows平台最长为15字符，允许字母（不限制大小写）、数字和“-”组成，不支持点号（"."），不能全是数字。  其他（Linux等）平台最长为30字符，允许支持多个点号，点之间为一段，每段允许字母（不限制大小写）、数字和“-”组成。
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// 镜像文件ID，表示启动实例时选择的镜像资源
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 实例的显示名称，由字母、数字、"-"组成，最长64个字符  实例的显示名称在同一个用户账号下必须唯一，不能重名  如果没有指定该参数，默认值为实例的InstanceId
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// 实例的资源规则。取值参见附表实例资源规格对照表，也可以调用查询实例资源规格列表接口获得最新的规格表。
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// 带宽计费类型.
        /// </summary>
        public string InternetChargeType { get; set; }

        /// <summary>
        /// 公网入带宽最大值，单位为Mbps(Mega bit per second)，取值范围为1~200，即最大值为200Mbps  默认值为200Mbps
        /// </summary>
        public Nullable<long> InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// 公网出带宽最大值，单位为Mbps(Mega bit per second)，取值范围为1~200，即最大值为200Mbps  默认值为200Mbps
        /// </summary>
        public Nullable<long> InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// 实例的密码，用户传入的密码只能是数字或者英文字母，必须在6~30个字节
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 实例所属的Region ID
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// 指定新创建实例所属于的安全组代码，同一个安全组内的实例之间可以互相访问。注意：同一安全组内的实例不能超过1000个
        /// </summary>
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 系统盘类型
        /// </summary>
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// 实例所属可用区
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
            return "ecs.aliyuncs.com.CreateInstance.2013-01-10";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("ClientToken", this.ClientToken);
            parameters.Add("DataDisk.1.Category", this.DataDisk1Category);
            parameters.Add("DataDisk.1.Size", this.DataDisk1Size);
            parameters.Add("DataDisk.1.SnapshotId", this.DataDisk1SnapshotId);
            parameters.Add("DataDisk.2.Category", this.DataDisk2Category);
            parameters.Add("DataDisk.2.Size", this.DataDisk2Size);
            parameters.Add("DataDisk.2.SnapshotId", this.DataDisk2SnapshotId);
            parameters.Add("DataDisk.3.Category", this.DataDisk3Category);
            parameters.Add("DataDisk.3.Size", this.DataDisk3Size);
            parameters.Add("DataDisk.3.SnapshotId", this.DataDisk3SnapshotId);
            parameters.Add("DataDisk.4.Category", this.DataDisk4Category);
            parameters.Add("DataDisk.4.Size", this.DataDisk4Size);
            parameters.Add("DataDisk.4.SnapshotId", this.DataDisk4SnapshotId);
            parameters.Add("HostName", this.HostName);
            parameters.Add("ImageId", this.ImageId);
            parameters.Add("InstanceName", this.InstanceName);
            parameters.Add("InstanceType", this.InstanceType);
            parameters.Add("InternetChargeType", this.InternetChargeType);
            parameters.Add("InternetMaxBandwidthIn", this.InternetMaxBandwidthIn);
            parameters.Add("InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            parameters.Add("Password", this.Password);
            parameters.Add("RegionId", this.RegionId);
            parameters.Add("SecurityGroupId", this.SecurityGroupId);
            parameters.Add("SystemDisk.Category", this.SystemDiskCategory);
            parameters.Add("ZoneId", this.ZoneId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ImageId", this.ImageId);
            RequestValidator.ValidateRequired("InstanceType", this.InstanceType);
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
