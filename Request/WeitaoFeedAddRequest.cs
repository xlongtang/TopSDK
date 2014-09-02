using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weitao.feed.add
    /// </summary>
    public class WeitaoFeedAddRequest : ITopRequest<WeitaoFeedAddResponse>
    {
        /// <summary>
        /// 封面图片地址，必须为自己在图片空间上传的图片<br /> 支持最大长度为：1000<br /> 支持的最大列表长度为：1000
        /// </summary>
        public string CoverPic { get; set; }

        /// <summary>
        /// feed的区域内容，有两种类型type=text或者type=pic。当type=text时，为文本内容，请输入description对应的文本值；当type=pic时，为图片内容，请输入pic对应的图片URL，图片的URL必须为当前操作用户(卖家)的图片空间图片地址,并且图片宽度要大于480，高宽比大于1/3小于2/3。支持type=text和type=pic的混排json<br /> 支持最大长度为：3000<br /> 支持的最大列表长度为：3000
        /// </summary>
        public string JsonTiles { get; set; }

        /// <summary>
        /// feed详情里允许放的一个超连接,不允许微信地址，最大长度256字符；输入link_desc后必须输入此参数<br /> 支持最大长度为：256<br /> 支持的最大列表长度为：256
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// link超连接的描述，最大长度15字符，utf-8,byte[]长度22，允许为空<br /> 支持最大长度为：22<br /> 支持的最大列表长度为：22
        /// </summary>
        public string LinkDesc { get; set; }

        /// <summary>
        /// 手机等客户端是否能够查看feed详情，如果为false，在feeds流时点击就进入到插件详情地址，否则进入查看feed详情
        /// </summary>
        public Nullable<bool> ShowDetail { get; set; }

        /// <summary>
        /// 发送的微淘内容的标题<br /> 支持最大长度为：64<br /> 支持的最大列表长度为：64
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 业务参数，用key=value格式，有多个时用'&'连接
        /// </summary>
        public string UrlParam { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.weitao.feed.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cover_pic", this.CoverPic);
            parameters.Add("json_tiles", this.JsonTiles);
            parameters.Add("link", this.Link);
            parameters.Add("link_desc", this.LinkDesc);
            parameters.Add("show_detail", this.ShowDetail);
            parameters.Add("title", this.Title);
            parameters.Add("url_param", this.UrlParam);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cover_pic", this.CoverPic);
            RequestValidator.ValidateMaxLength("cover_pic", this.CoverPic, 1000);
            RequestValidator.ValidateMaxLength("json_tiles", this.JsonTiles, 3000);
            RequestValidator.ValidateMaxLength("link", this.Link, 256);
            RequestValidator.ValidateMaxLength("link_desc", this.LinkDesc, 22);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 64);
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
