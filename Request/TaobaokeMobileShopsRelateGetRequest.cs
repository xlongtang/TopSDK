using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.mobile.shops.relate.get
    /// </summary>
    public class TaobaokeMobileShopsRelateGetRequest : ITopRequest<TaobaokeMobileShopsRelateGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表.可选值:TaobaokeShop淘宝客商品结构体中的user_id,seller_nick,shop_id,shop_title,seller_credit,shop_type,commission_rate,click_url,total_auction,auction_count,字段之间用","分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 指定返回结果的最大条数,实际返回结果个数根据算法来确定
        /// </summary>
        public Nullable<long> MaxCount { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 卖家id.seller_id和seller_nick不能同时为空,如果都有值,则以seller_id为主
        /// </summary>
        public Nullable<long> SellerId { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 店铺类型.所有:all,商城:b,集市:c
        /// </summary>
        public string ShopType { get; set; }

        /// <summary>
        /// default(默认排序,关联推荐相关度),commissionRate_desc(佣金比率从高到低), commissionRate_asc(佣金比率从低到高),credit_desc(信用等级从高到低), credit_asc(信用等级从低到高)
        /// </summary>
        public string Sort { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.mobile.shops.relate.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("max_count", this.MaxCount);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("seller_id", this.SellerId);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("shop_type", this.ShopType);
            parameters.Add("sort", this.Sort);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
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
