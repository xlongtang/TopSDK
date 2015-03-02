using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ma.qrcode.common.create
    /// </summary>
    public class MaQrcodeCommonCreateRequest : ITopRequest<MaQrcodeCommonCreateResponse>
    {
        /// <summary>
        /// 二维码需要布点的位置，方便用户在码平台上可以区分看到不同布点的扫码数据情况；列表值，用半角','号分割，单个渠道名不能超过16字符。
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// 二维码的内容之一，由type决定：type=page时，content传入无线页面的URL连接内容；type=item时，content传入宝贝数字ID；type=url时，content传入普通的URL连接内容；type=shop时，content传入店铺ID；
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 二维码的logo地址，只允许淘宝官方图片空间的图片地址，其他非图片空间图片不支持。官方淘logo图片地址：http://img01.taobaocdn.com/imgextra/T1Od8YFT8eXXXXXXXX。
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// 二维码名字，即创建的二维码，在码平台上显示记录的名字。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否需要矢量图，如果需要矢量图，设置为true；只支持普通二维码，官方模板不支持矢量图
        /// </summary>
        public Nullable<bool> NeedEps { get; set; }

        /// <summary>
        /// 二维码尺寸，只支持普通二维码，不支持官方模板，单位为像素，最小为60×60，最大为300×300，建议175×175。官方模板大小尺寸见style说明。
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 二维码的样式名，支持普通码的颜色或官方模板的模板名；普通码的颜色可选输入：“000000”(黑色)、“EF4F2B”(橙色);官方模板的可选输入（实际尺寸比样例大）：“ww_color.png“ 尺寸290x320，样例：http://gtms03.alicdn.com/tps/i3/T1YLPRFRXXXXbsbYwb-100-102.png；“tb_scan.png“ 尺寸290x320，样例：http://gtms01.alicdn.com/tps/i1/T14vsEFThdXXbsbYwb-100-102.png；“ww_hide_color.png“  尺寸200x263，样例：http://gtms04.alicdn.com/tps/i4/TB1URvlFVXXXXbRXFXXwxcf6pXX-76-100.png；“tmall_hide_color.png“ 尺寸200x263，样例：http://gtms01.alicdn.com/tps/i1/TB1S5PiFVXXXXacXVXXwxcf6pXX-76-100.png。
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// 要制作的二维码业务类型：page:无线页面类型item:宝贝ID类型url:普通的URL连接类型shop:店铺ID类型
        /// </summary>
        public string Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ma.qrcode.common.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_name", this.ChannelName);
            parameters.Add("content", this.Content);
            parameters.Add("logo", this.Logo);
            parameters.Add("name", this.Name);
            parameters.Add("need_eps", this.NeedEps);
            parameters.Add("size", this.Size);
            parameters.Add("style", this.Style);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("channel_name", this.ChannelName, 160);
            RequestValidator.ValidateRequired("content", this.Content);
            RequestValidator.ValidateMaxLength("content", this.Content, 256);
            RequestValidator.ValidateMaxLength("logo", this.Logo, 256);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 32);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 300);
            RequestValidator.ValidateMinValue("size", this.Size, 60);
            RequestValidator.ValidateRequired("style", this.Style);
            RequestValidator.ValidateMaxLength("style", this.Style, 50);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateMaxLength("type", this.Type, 10);
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
