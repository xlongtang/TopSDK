using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sp.content.custom.update
    /// </summary>
    public class SpContentCustomUpdateRequest : ITopRequest<SpContentCustomUpdateResponse>
    {
        /// <summary>
        /// 内容的自定义分类，数值为文本内容，主要用于区分内容的分类（譬如连衣裙、T恤、阿迪达斯等），分类名称的长度限制为(0,5] (单位是字符，不区分中英文)，分类名称中不能包含非法内容，且一个站点下所拥有的总自定义分类数量不能超过16个<br /> 支持最大长度为：5<br /> 支持的最大列表长度为：5
        /// </summary>
        public string Classname { get; set; }

        /// <summary>
        /// 自定义内容的正文，数值为文本内容（html形式），长度限制为[100,20000] (单位是字符，不区分中英文), 内容中不能有外链，不能有恶意脚本；内容中包含的商品链接系统自自动提取并保存起来;多个商品链接以空格隔开(如 href=http://detail.tmall.com/item.htm?id=35743839682 href=http://item.taobao.com/item.htm?id=36366644805 )<br /> 支持最大长度为：20000<br /> 支持的最大列表长度为：20000
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 内容的detail页面地址，数值为html链接，主要用于展现内容的detail信息的
        /// </summary>
        public string Detailurl { get; set; }

        /// <summary>
        /// 内容ID
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 站长Key<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string SiteKey { get; set; }

        /// <summary>
        /// 内容的自定义标签，数值为文本内容，多个标签以逗号“,”分割。  主要用于细化内容的分类（譬如小清新，棉质、雪纺等），标签名称的长度限制为[0,6] (单位是字符，不区分中英文)，标签名称中不能包含非法内容，且一个内容关联的标签数目不能超过6个
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 内容标题,标题的长度限制为(0,32](单位是字符，不区分中英文)<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string Title { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sp.content.custom.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("classname", this.Classname);
            parameters.Add("content", this.Content);
            parameters.Add("detailurl", this.Detailurl);
            parameters.Add("id", this.Id);
            parameters.Add("site_key", this.SiteKey);
            parameters.Add("tags", this.Tags);
            parameters.Add("title", this.Title);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("classname", this.Classname);
            RequestValidator.ValidateMaxLength("classname", this.Classname, 5);
            RequestValidator.ValidateRequired("content", this.Content);
            RequestValidator.ValidateMaxLength("content", this.Content, 20000);
            RequestValidator.ValidateRequired("detailurl", this.Detailurl);
            RequestValidator.ValidateRequired("id", this.Id);
            RequestValidator.ValidateRequired("site_key", this.SiteKey);
            RequestValidator.ValidateMaxLength("site_key", this.SiteKey, 32);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 32);
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
