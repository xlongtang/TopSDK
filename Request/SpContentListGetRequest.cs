using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sp.content.list.get
    /// </summary>
    public class SpContentListGetRequest : ITopRequest<SpContentListGetResponse>
    {
        /// <summary>
        /// JOSN格式的分页参数：  page： 查询起始页 >=1   rows： 分页大小 <= 50  sort : 排序字段(如果没有指定排序方式，默认按修改时间倒序)，支持的排序类型包括：gmtModified – 最后修改时间；likeNum – 喜欢数；viewNum – 浏览数；  order：排序方式：asc – 顺序；desc – 倒序
        /// </summary>
        public string Pagerequest { get; set; }

        /// <summary>
        /// JSON格式的查询条件： type(Integer，选填) ：内容类型，包括四种： 1 -- 宝贝，2 -- 图片，3 -- 自定义，4 -- 图文； className(String，选填)：内容的自定义分类名称；tags(String，选填)：内容的自定义标签名称，多个标签以逗号“,”分割。如果设置了多个标签，则他们是或的关系；title(String，选填): 内容标题，此条件为模糊搜索，慎用，可能比较慢；
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 站长Key<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string SiteKey { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sp.content.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("pagerequest", this.Pagerequest);
            parameters.Add("query", this.Query);
            parameters.Add("site_key", this.SiteKey);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("pagerequest", this.Pagerequest);
            RequestValidator.ValidateRequired("query", this.Query);
            RequestValidator.ValidateRequired("site_key", this.SiteKey);
            RequestValidator.ValidateMaxLength("site_key", this.SiteKey, 32);
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
