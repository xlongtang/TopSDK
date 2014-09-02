using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.creative.add
    /// </summary>
    public class SimbaCreativeAddRequest : ITopRequest<SimbaCreativeAddResponse>
    {
        /// <summary>
        /// 推广组Id
        /// </summary>
        public Nullable<long> AdgroupId { get; set; }

        /// <summary>
        /// 创意图片地址，必须是推广组对应商品的图片之一
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 创意标题，最多20个汉字<br /> 支持最大长度为：40<br /> 支持的最大列表长度为：40
        /// </summary>
        public string Title { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.creative.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adgroup_id", this.AdgroupId);
            parameters.Add("img_url", this.ImgUrl);
            parameters.Add("nick", this.Nick);
            parameters.Add("title", this.Title);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("adgroup_id", this.AdgroupId);
            RequestValidator.ValidateRequired("img_url", this.ImgUrl);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 40);
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
