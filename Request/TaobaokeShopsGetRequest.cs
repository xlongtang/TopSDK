using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.shops.get
    /// </summary>
    public class TaobaokeShopsGetRequest : ITopRequest<TaobaokeShopsGetResponse>
    {
        /// <summary>
        /// 店铺前台展示类目id，可以通过taobao.shopcats.list.get获取。
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 店铺商品数查询结束值。需要跟start_auctioncount同时设置才生效，只设置该值不生效。
        /// </summary>
        public string EndAuctioncount { get; set; }

        /// <summary>
        /// 店铺佣金比例查询结束值
        /// </summary>
        public string EndCommissionrate { get; set; }

        /// <summary>
        /// 店铺掌柜信用等级查询结束  店铺的信用等级总共为20级 1-5:1heart-5heart;6-10:1diamond-5diamond;11-15:1crown-5crown;16-20:1goldencrown-5goldencrown
        /// </summary>
        public string EndCredit { get; set; }

        /// <summary>
        /// 店铺累计推广数查询结束值
        /// </summary>
        public string EndTotalaction { get; set; }

        /// <summary>
        /// 需要返回的字段，目前包括如下字段 user_id click_url shop_title commission_rate seller_credit shop_type auction_count total_auction
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 标识一个应用是否来在无线或者手机应用,如果是true则会使用其他规则加密点击串.如果不传值,则默认是false.
        /// </summary>
        public Nullable<bool> IsMobile { get; set; }

        /// <summary>
        /// 店铺主题关键字查询
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 淘宝用户昵称，注：指的是淘宝的会员登录名.如果昵称错误,那么客户就收不到佣金.每个淘宝昵称都对应于一个pid，在这里输入要结算佣金的淘宝昵称，当推广的商品成功后，佣金会打入此输入的淘宝昵称的账户。具体的信息可以登入阿里妈妈的网站查看
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 是否只显示商城店铺
        /// </summary>
        public Nullable<bool> OnlyMall { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道.
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 页码.结果页1~99
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数.最大每页40
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 用户的pid,必须是mm_xxxx_0_0这种格式中间的"xxxx". 注意nick和pid至少需要传递一个,如果2个都传了,将以pid为准,且pid的最大长度是20。第一次调用接口的用户，推荐该入参不要填写，使用nick=（淘宝账号）的方式去获取，以免出错。
        /// </summary>
        public Nullable<long> Pid { get; set; }

        /// <summary>
        /// 排序字段。目前支持的排序字段有：  commission_rate，auction_count，total_auction。必须输入这三个任意值，否则排序无效
        /// </summary>
        public string SortField { get; set; }

        /// <summary>
        /// 排序类型.必须输入desc,asc任一值，否则无效  desc-降序,asc-升序
        /// </summary>
        public string SortType { get; set; }

        /// <summary>
        /// 店铺宝贝数查询开始值。需要跟end_auctioncount同时设置才生效，只设置该值不生效。
        /// </summary>
        public string StartAuctioncount { get; set; }

        /// <summary>
        /// 店铺佣金比例查询开始值，注意佣金比例是x10000的整数.50表示0.5%
        /// </summary>
        public string StartCommissionrate { get; set; }

        /// <summary>
        /// 店铺掌柜信用等级起始  店铺的信用等级总共为20级 1-5:1heart-5heart;6-10:1diamond-5diamond;11-15:1crown-5crown;16-20:1goldencrown-5goldencrown
        /// </summary>
        public string StartCredit { get; set; }

        /// <summary>
        /// 店铺累计推广量开始值
        /// </summary>
        public string StartTotalaction { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.shops.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("end_auctioncount", this.EndAuctioncount);
            parameters.Add("end_commissionrate", this.EndCommissionrate);
            parameters.Add("end_credit", this.EndCredit);
            parameters.Add("end_totalaction", this.EndTotalaction);
            parameters.Add("fields", this.Fields);
            parameters.Add("is_mobile", this.IsMobile);
            parameters.Add("keyword", this.Keyword);
            parameters.Add("nick", this.Nick);
            parameters.Add("only_mall", this.OnlyMall);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("pid", this.Pid);
            parameters.Add("sort_field", this.SortField);
            parameters.Add("sort_type", this.SortType);
            parameters.Add("start_auctioncount", this.StartAuctioncount);
            parameters.Add("start_commissionrate", this.StartCommissionrate);
            parameters.Add("start_credit", this.StartCredit);
            parameters.Add("start_totalaction", this.StartTotalaction);
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
