using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.ModifyAutoSnapshotPolicy.2014-05-26
    /// </summary>
    public class ModifyAutoSnapshotPolicyRequest : IAliyunRequest<ModifyAutoSnapshotPolicyResponse>
    {
        /// <summary>
        /// 数据盘自动快照策略开关：  True：该磁盘属性的磁盘打自动快照，  False：不打自动快照，  默认值：无，表示保留当前值
        /// </summary>
        public Nullable<bool> DataDiskPolicyEnabled { get; set; }

        /// <summary>
        /// 数据盘自动快照策略的保留天数：  可选值， 1，2，3，  默认值：无，表示保留当前值<br /> 支持最大值为：3<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> DataDiskPolicyRetentionDays { get; set; }

        /// <summary>
        /// 数据盘自动快照策略的保留上周日选项：  True：代表保留上周日的快照，  False：不保留，  默认值：无，表示保留当前值
        /// </summary>
        public Nullable<bool> DataDiskPolicyRetentionLastWeek { get; set; }

        /// <summary>
        /// 数据盘自动快照策略的时间段：  4个时间段，  1：1:00-7:00  2：7:00-13:00  3：13:00-19:00  4：19:00-1:00  默认值：无，表示保留当前值<br /> 支持最大值为：4<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> DataDiskPolicyTimePeriod { get; set; }

        /// <summary>
        /// 系统盘自动快照策略开关
        /// </summary>
        public Nullable<bool> SystemDiskPolicyEnabled { get; set; }

        /// <summary>
        /// 系统盘自动快照策略的保留天数：  可选值， 1，2，3，  默认值：无，表示保留当前值<br /> 支持最大值为：3<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> SystemDiskPolicyRetentionDays { get; set; }

        /// <summary>
        /// 系统盘自动快照策略的保留上周日选项：  True：代表保留上周日的快照，  False：不保留，  默认值：无，表示保留当前值
        /// </summary>
        public Nullable<bool> SystemDiskPolicyRetentionLastWeek { get; set; }

        /// <summary>
        /// 系统盘自动快照策略的时间段：  4个时间段，  1：1:00-7:00  2：7:00-13:00  3：13:00-19:00  4：19:00-1:00  默认值：无，表示保留当前值<br /> 支持最大值为：4<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> SystemDiskPolicyTimePeriod { get; set; }

    
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
            return "ecs.aliyuncs.com.ModifyAutoSnapshotPolicy.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("DataDiskPolicyEnabled", this.DataDiskPolicyEnabled);
            parameters.Add("DataDiskPolicyRetentionDays", this.DataDiskPolicyRetentionDays);
            parameters.Add("DataDiskPolicyRetentionLastWeek", this.DataDiskPolicyRetentionLastWeek);
            parameters.Add("DataDiskPolicyTimePeriod", this.DataDiskPolicyTimePeriod);
            parameters.Add("SystemDiskPolicyEnabled", this.SystemDiskPolicyEnabled);
            parameters.Add("SystemDiskPolicyRetentionDays", this.SystemDiskPolicyRetentionDays);
            parameters.Add("SystemDiskPolicyRetentionLastWeek", this.SystemDiskPolicyRetentionLastWeek);
            parameters.Add("SystemDiskPolicyTimePeriod", this.SystemDiskPolicyTimePeriod);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("DataDiskPolicyRetentionDays", this.DataDiskPolicyRetentionDays, 3);
            RequestValidator.ValidateMinValue("DataDiskPolicyRetentionDays", this.DataDiskPolicyRetentionDays, 1);
            RequestValidator.ValidateMaxValue("DataDiskPolicyTimePeriod", this.DataDiskPolicyTimePeriod, 4);
            RequestValidator.ValidateMinValue("DataDiskPolicyTimePeriod", this.DataDiskPolicyTimePeriod, 1);
            RequestValidator.ValidateMaxValue("SystemDiskPolicyRetentionDays", this.SystemDiskPolicyRetentionDays, 3);
            RequestValidator.ValidateMinValue("SystemDiskPolicyRetentionDays", this.SystemDiskPolicyRetentionDays, 1);
            RequestValidator.ValidateMaxValue("SystemDiskPolicyTimePeriod", this.SystemDiskPolicyTimePeriod, 4);
            RequestValidator.ValidateMinValue("SystemDiskPolicyTimePeriod", this.SystemDiskPolicyTimePeriod, 1);
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
