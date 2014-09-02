using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.DescribeImages.2014-05-26
    /// </summary>
    public class DescribeImagesRequest : IAliyunRequest<DescribeImagesResponse>
    {
        /// <summary>
        /// 镜像系统类型：i386 | x86_64
        /// </summary>
        public string Architecture { get; set; }

        /// <summary>
        /// 镜像ID，可以输入多个，以”,”分割
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像的名称
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// 镜像所有者别名。  取值：  ？ System| self| others| marketplace  默认值:无，表示返回system+self+others  不设置该参数说明不使用该参数进行过滤条件  取值说明:  system 阿里云官方提供镜像  self 用户自定义镜像  others 非自己的可用镜像  ？ marketplace 镜像市场提供的镜像
        /// </summary>
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// 实例状态列表的页码，起始值为1，默认值为1<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageNumber { get; set; }

        /// <summary>
        /// 分页查询时设置的每页行数，最大值50行，默认为10<br /> 支持最大值为：50<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 实例所属于的Region ID
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// 创建镜像的快照ID
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
            return "ecs.aliyuncs.com.DescribeImages.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("Architecture", this.Architecture);
            parameters.Add("ImageId", this.ImageId);
            parameters.Add("ImageName", this.ImageName);
            parameters.Add("ImageOwnerAlias", this.ImageOwnerAlias);
            parameters.Add("PageNumber", this.PageNumber);
            parameters.Add("PageSize", this.PageSize);
            parameters.Add("RegionId", this.RegionId);
            parameters.Add("SnapshotId", this.SnapshotId);
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
