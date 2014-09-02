using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20130110.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20130110.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.AddDisk.2013-01-10
    /// </summary>
    public class AddDiskRequest : IAliyunRequest<AddDiskResponse>
    {
        /// <summary>
        /// 用于保证请求的幂等性。由客户端生成该参数值，要保证在不同请求间唯一，最大不值过64个ASCII字符。 具体参见附录：如何保证幂等性。
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// 指定实例的名称
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// 需要增加的磁盘大小，以GB为单位，取值范围为5~2048
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 如不传则增加空数据盘，若指定SnapshotId，磁盘的大小以Snapshot大小为准。Snapshot只能是数据盘的Snapshot。
        /// </summary>
        public string SnapshotId { get; set; }

    
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
            return "ecs.aliyuncs.com.AddDisk.2013-01-10";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("ClientToken", this.ClientToken);
            parameters.Add("InstanceId", this.InstanceId);
            parameters.Add("Size", this.Size);
            parameters.Add("SnapshotId", this.SnapshotId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("InstanceId", this.InstanceId);
            RequestValidator.ValidateRequired("Size", this.Size);
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
