using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sp.content.graphic.update
    /// </summary>
    public class SpContentGraphicUpdateRequest : ITopRequest<SpContentGraphicUpdateResponse>
    {
        /// <summary>
        /// 内容的自定义分类，数值为文本内容，主要用于区分内容的分类（譬如连衣裙、T恤、阿迪达斯等），分类名称的长度限制为(0,5] (单位是字符，不区分中英文)，分类名称中不能包含非法内容，且一个站点下所拥有的总自定义分类数量不能超过16个<br /> 支持最大长度为：5<br /> 支持的最大列表长度为：5
        /// </summary>
        public string Classname { get; set; }

        /// <summary>
        /// 图文内容，Json格式的数据。  必须是数组类型元素列表。展示时每一个元素会单独一行显示。  type: 表示图文元素的类型，目前支持3种类型的元素  1:text;文本元素；  2:image;图片元素；  3:item;宝贝元素；    value:表示图文类型的元素值。  当类型为text时，value值就是文本类型字符串；  当类型为image时，value值就是图片地址;  当类型为item时，value值就是宝贝ID;
        /// </summary>
        public string Contents { get; set; }

        /// <summary>
        /// 封面图片地址  图文的封面尺寸不能低于680*680，否则该条图文将无法同步至微淘  图片地址必须匹配正则表达式:http://(img01|img02|img03|img04|img1|img2|img3|img4)\.(taobaocdn|tbcdn)\.(com|net|cn).*
        /// </summary>
        public string Coverpicurl { get; set; }

        /// <summary>
        /// 内容的detail页面地址，数值为html链接，主要用于展现内容的detail信息的
        /// </summary>
        public string Detailurl { get; set; }

        /// <summary>
        /// 内容ID
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 是否要发送到微淘广播流
        /// </summary>
        public Nullable<bool> Intimeline { get; set; }

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
            return "taobao.sp.content.graphic.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("classname", this.Classname);
            parameters.Add("contents", this.Contents);
            parameters.Add("coverpicurl", this.Coverpicurl);
            parameters.Add("detailurl", this.Detailurl);
            parameters.Add("id", this.Id);
            parameters.Add("intimeline", this.Intimeline);
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
            RequestValidator.ValidateRequired("contents", this.Contents);
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
