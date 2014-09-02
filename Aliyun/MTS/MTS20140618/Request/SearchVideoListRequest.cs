using System;
using System.Collections.Generic;
using Aliyun.Api.MTS.MTS20140618.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.MTS.MTS20140618.Request
{	
    
    /// <summary>
    /// TOP API: mts.aliyuncs.com.SearchVideoList.2014-06-18
    /// </summary>
    public class SearchVideoListRequest : IAliyunRequest<SearchVideoListResponse>
    {
        /// <summary>
        /// 当前页号
        /// </summary>
        public Nullable<long> PageNumber { get; set; }

        /// <summary>
        /// 分页查询时设置的每页行数页面大小<br /> 支持最大值为：100<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

    
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
            return "mts.aliyuncs.com.SearchVideoList.2014-06-18";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("PageNumber", this.PageNumber);
            parameters.Add("PageSize", this.PageSize);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("PageSize", this.PageSize, 100);
            RequestValidator.ValidateMinValue("PageSize", this.PageSize, 1);
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
