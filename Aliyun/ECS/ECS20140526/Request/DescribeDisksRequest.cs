using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.DescribeDisks.2014-05-26
    /// </summary>
    public class DescribeDisksRequest : IAliyunRequest<DescribeDisksResponse>
    {
        /// <summary>
        /// 磁盘种类，all|cloud|ephemaral。默认值为all
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 删除磁盘时，是否同时删除自动快照。  True表示同时删除自动快照  False表示保留自动快照
        /// </summary>
        public Nullable<bool> DeleteAutoSnapshot { get; set; }

        /// <summary>
        /// 磁盘是否随实例释放：  True表示Instance释放时，这块磁盘随Instance一起释放；  False表示Instance释放时，这块磁盘保留不释放。  默认值为
        /// </summary>
        public Nullable<bool> DeleteWithInstance { get; set; }

        /// <summary>
        /// 磁盘ID
        /// </summary>
        public string DiskIds { get; set; }

        /// <summary>
        /// all|system|data，默认值为all。
        /// </summary>
        public string DiskType { get; set; }

        /// <summary>
        /// 目标云服务器ID
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例状态列表的页码，起始值为1，默认值为1<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageNumber { get; set; }

        /// <summary>
        /// 分页查询时设置的每页行数，最大值50行，默认为10<br /> 支持最大值为：50<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// True代表是独立云磁盘，可以独立存在且可以自由在独立区内挂载和下载，false代表非独立云磁盘，只能和实例同生同灭。用户如果需要做attach和detach操作，必须先查询一下这个属性为true的磁盘才能操作。临时磁盘，云磁盘的系统盘和包月的云磁盘，该属性都为false。这个属性用户不能更改
        /// </summary>
        public Nullable<bool> Portable { get; set; }

        /// <summary>
        /// 实例所属于的Region ID
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// 创建数据盘使用的快照  指定该参数后Size会被忽略，实际创建的磁盘大小为指定快照的大小  2013年7月15日（含）前的快照不能用来创建磁盘
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// 磁盘状态  In-use|Availalble|Attaching|  Detaching|Creating|Deleting|All，默认值为All
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 可用区ID。
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
            return "ecs.aliyuncs.com.DescribeDisks.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("Category", this.Category);
            parameters.Add("DeleteAutoSnapshot", this.DeleteAutoSnapshot);
            parameters.Add("DeleteWithInstance", this.DeleteWithInstance);
            parameters.Add("DiskIds", this.DiskIds);
            parameters.Add("DiskType", this.DiskType);
            parameters.Add("InstanceId", this.InstanceId);
            parameters.Add("PageNumber", this.PageNumber);
            parameters.Add("PageSize", this.PageSize);
            parameters.Add("Portable", this.Portable);
            parameters.Add("RegionId", this.RegionId);
            parameters.Add("SnapshotId", this.SnapshotId);
            parameters.Add("Status", this.Status);
            parameters.Add("ZoneId", this.ZoneId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("PageNumber", this.PageNumber, 1);
            RequestValidator.ValidateMaxValue("PageSize", this.PageSize, 50);
            RequestValidator.ValidateMinValue("PageSize", this.PageSize, 1);
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
