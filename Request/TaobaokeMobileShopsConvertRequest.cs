using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.mobile.shops.convert
    /// </summary>
    public class TaobaokeMobileShopsConvertRequest : ITopRequest<TaobaokeMobileShopsConvertResponse>
    {
        /// <summary>
        /// 需返回的字段列表.可选值:TaobaokeShop淘宝客商品结构体中的user_id,shop_title,click_url,commission_rate;字段之间用","分隔.
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道.
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 卖家昵称串.最大输入10个.格式如:"value1,value2,value3" 用" , "号分隔。  注意：sids和seller_nicks两个参数任意必须输入一个，如果同时输入，则以seller_nicks为准
        /// </summary>
        public string SellerNicks { get; set; }

        /// <summary>
        /// 店铺id串.最大输入10个.格式如:"value1,value2,value3" 用" , "号分隔店铺id.  注意：sids和seller_nicks两个参数任意必须输入一个，如果同时输入，则以seller_nicks为准
        /// </summary>
        public string Sids { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.mobile.shops.convert";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("seller_nicks", this.SellerNicks);
            parameters.Add("sids", this.Sids);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxListSize("seller_nicks", this.SellerNicks, 10);
            RequestValidator.ValidateMaxListSize("sids", this.Sids, 10);
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
