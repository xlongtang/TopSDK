using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jae.client.sharing.showsharingmenu
    /// </summary>
    public class JaeClientSharingShowsharingmenuRequest : ITopRequest<JaeClientSharingShowsharingmenuResponse>
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 分享内容
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 分享的连接地址
        /// </summary>
        public string Url { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jae.client.sharing.showsharingmenu";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("image", this.Image);
            parameters.Add("text", this.Text);
            parameters.Add("title", this.Title);
            parameters.Add("url", this.Url);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("text", this.Text);
            RequestValidator.ValidateRequired("title", this.Title);
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
