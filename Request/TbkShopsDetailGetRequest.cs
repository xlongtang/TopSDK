using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tbk.shops.detail.get
    /// </summary>
    public class TbkShopsDetailGetRequest : ITopRequest<TbkShopsDetailGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表.可选值:user_id,seller_nick,shop_title,pic_url,shop_url;字段之间用","分隔.
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 标识一个应用是否来在无线或者手机应用,如果是true则会生成无线店铺URL.如果不传值,则默认是false.
        /// </summary>
        public Nullable<bool> IsMobile { get; set; }

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
            return "taobao.tbk.shops.detail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("is_mobile", this.IsMobile);
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
