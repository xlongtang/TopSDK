using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.brandcat.propinput.get
    /// </summary>
    public class TmallBrandcatPropinputGetRequest : ITopRequest<TmallBrandcatPropinputGetResponse>
    {
        /// <summary>
        /// 品牌ID，如果类目没有品牌，指定null
        /// </summary>
        public Nullable<long> BrandId { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 属性ID，如果属性有子属性，请指定最后一级子属性ID，tmall.brandcat.propinput.get返回的即为的该属性ID对应的输入特征，对于有子属性模板的情况指定顶级属性ID即可
        /// </summary>
        public Nullable<long> Pid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.brandcat.propinput.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("brand_id", this.BrandId);
            parameters.Add("cid", this.Cid);
            parameters.Add("pid", this.Pid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("brand_id", this.BrandId);
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateRequired("pid", this.Pid);
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
