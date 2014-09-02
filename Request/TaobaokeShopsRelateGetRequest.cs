using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.shops.relate.get
    /// </summary>
    public class TaobaokeShopsRelateGetRequest : ITopRequest<TaobaokeShopsRelateGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表.可选值:TaobaokeShop淘宝客商品结构体中的user_id,seller_nick,shop_id,shop_title,seller_credit,shop_type,commission_rate,click_url,total_auction,auction_count,字段之间用","分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 标识一个应用是否来在无线或者手机应用,如果是true则会使用其他规则加密点击串,如果不传值,则默认是false
        /// </summary>
        public Nullable<bool> IsMobile { get; set; }

        /// <summary>
        /// 指定返回结果的最大条数,实际返回结果个数根据算法来确定
        /// </summary>
        public Nullable<long> MaxCount { get; set; }

        /// <summary>
        /// 淘宝用户昵称.注:指的是淘宝的会员登录名.如果昵称错误,那么客户就收不到佣金.每个淘宝昵称都对应于一个pid,在这里输入要结算佣金的淘宝昵称,当推广的商品成功后,佣金会打入此输入的淘宝昵称的账户.具体的信息可以登入阿里妈妈的网站查看
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 用户的pid,必须是mm_xxxx_0_0这种格式中间的"xxxx". 注意nick和pid至少需要传递一个,如果2个都传了,将以pid为准,且pid的最大长度是20。第一次调用接口的用户，推荐该入参不要填写，使用nick=（淘宝账号）的方式去获取，以免出错。
        /// </summary>
        public Nullable<long> Pid { get; set; }

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
            return "taobao.taobaoke.shops.relate.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("is_mobile", this.IsMobile);
            parameters.Add("max_count", this.MaxCount);
            parameters.Add("nick", this.Nick);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("pid", this.Pid);
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
