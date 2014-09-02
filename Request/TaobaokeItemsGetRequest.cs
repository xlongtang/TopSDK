using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.items.get
    /// </summary>
    public class TaobaokeItemsGetRequest : ITopRequest<TaobaokeItemsGetResponse>
    {
        /// <summary>
        /// 商品所在地
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 是否自动发货
        /// </summary>
        public string AutoSend { get; set; }

        /// <summary>
        /// 是否支持抵价券，设置为true表示该商品支持抵价券，设置为false或不设置表示不判断这个属性
        /// </summary>
        public string CashCoupon { get; set; }

        /// <summary>
        /// 是否支持货到付款，设置为true表示该商品是支持货到付款，设置为false或不设置表示不判断这个属性
        /// </summary>
        public string CashOndelivery { get; set; }

        /// <summary>
        /// 标准商品后台类目id。该ID可以通过taobao.itemcats.get接口获取到。
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 30天累计推广量（与返回数据中的commission_num字段对应）上限.
        /// </summary>
        public string EndCommissionNum { get; set; }

        /// <summary>
        /// 佣金比率上限，如：2345表示23.45%。注：start_commissionRate和end_commissionRate一起设置才有效。
        /// </summary>
        public string EndCommissionRate { get; set; }

        /// <summary>
        /// 可选值和start_credit一样.start_credit的值一定要小于或等于end_credit的值。注：end_credit与start_credit一起使用才生效
        /// </summary>
        public string EndCredit { get; set; }

        /// <summary>
        /// 最高价格
        /// </summary>
        public string EndPrice { get; set; }

        /// <summary>
        /// 商品总成交量（与返回字段volume对应）上限。
        /// </summary>
        public string EndTotalnum { get; set; }

        /// <summary>
        /// 需返回的字段列表.可选值:num_iid,title,nick,pic_url,price,click_url,commission,commission_rate,commission_num,commission_volume,shop_click_url,seller_credit_score,item_location,volume ;字段之间用","分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 是否查询消保卖家
        /// </summary>
        public string Guarantee { get; set; }

        /// <summary>
        /// 标识一个应用是否来在无线或者手机应用,如果是true则会使用其他规则加密点击串.如果不传值,则默认是false.
        /// </summary>
        public Nullable<bool> IsMobile { get; set; }

        /// <summary>
        /// 商品标题中包含的关键字. 注意:查询时keyword,cid至少选择其中一个参数
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 是否商城的商品，设置为true表示该商品是属于淘宝商城的商品，设置为false或不设置表示不判断这个属性
        /// </summary>
        public string MallItem { get; set; }

        /// <summary>
        /// 淘宝用户昵称，注：指的是淘宝的会员登录名.如果昵称错误,那么客户就收不到佣金.每个淘宝昵称都对应于一个pid，在这里输入要结算佣金的淘宝昵称，当推广的商品成功后，佣金会打入此输入的淘宝昵称的账户。具体的信息可以登入阿里妈妈的网站查看.  <font color="red">注意nick和pid至少需要传递一个,如果2个都传了,将以pid为准</font>
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 是否30天维修，设置为true表示该商品是支持30天维修，设置为false或不设置表示不判断这个属性
        /// </summary>
        public string OnemonthRepair { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道.
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 是否海外商品，设置为true表示该商品是属于海外商品，默认为false
        /// </summary>
        public string OverseasItem { get; set; }

        /// <summary>
        /// 结果页数.1~10
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页返回结果数.最大每页40
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 用户的pid,必须是mm_xxxx_0_0这种格式中间的"xxxx". <font color="red">注意nick和pid至少需要传递一个,如果2个都传了,将以pid为准,且pid的最大长度是20</font>。第一次调用接口的用户，推荐该入参不要填写，使用nick=（淘宝账号）的方式去获取，以免出错。
        /// </summary>
        public Nullable<long> Pid { get; set; }

        /// <summary>
        /// 是否如实描述(即:先行赔付)商品，设置为true表示该商品是如实描述的商品，设置为false或不设置表示不判断这个属性
        /// </summary>
        public string RealDescribe { get; set; }

        /// <summary>
        /// 点击串跳转类型，1：单品，2：单品中间页（无线暂无）
        /// </summary>
        public Nullable<long> ReferType { get; set; }

        /// <summary>
        /// 是否支持7天退换，设置为true表示该商品支持7天退换，设置为false或不设置表示不判断这个属性
        /// </summary>
        public string SevendaysReturn { get; set; }

        /// <summary>
        /// 默认排序:default  price_desc(价格从高到低)  price_asc(价格从低到高)  credit_desc(信用等级从高到低)  commissionRate_desc(佣金比率从高到低)  commissionRate_asc(佣金比率从低到高)  commissionNum_desc(成交量成高到低)  commissionNum_asc(成交量从低到高)  commissionVolume_desc(总支出佣金从高到低)  commissionVolume_asc(总支出佣金从低到高)  delistTime_desc(商品下架时间从高到低)  delistTime_asc(商品下架时间从低到高)
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 30天累计推广量（与返回数据中的commission_num字段对应）下限.注：该字段要与end_commissionNum一起使用才生效
        /// </summary>
        public string StartCommissionNum { get; set; }

        /// <summary>
        /// 佣金比率下限，如：1234表示12.34%
        /// </summary>
        public string StartCommissionRate { get; set; }

        /// <summary>
        /// 卖家信用:    1heart(一心)   2heart (两心)   3heart(三心)   4heart(四心)   5heart(五心)   1diamond(一钻)   2diamond(两钻)   3diamond(三钻)   4diamond(四钻)   5diamond(五钻)   1crown(一冠)   2crown(两冠)   3crown(三冠)   4crown(四冠)   5crown(五冠)   1goldencrown(一黄冠)   2goldencrown(二黄冠)   3goldencrown(三黄冠)   4goldencrown(四黄冠)   5goldencrown(五黄冠)
        /// </summary>
        public string StartCredit { get; set; }

        /// <summary>
        /// 起始价格.传入价格参数时,需注意起始价格和最高价格必须一起传入,并且 start_price <= end_price
        /// </summary>
        public string StartPrice { get; set; }

        /// <summary>
        /// 商品总成交量（与返回字段volume对应）下限。
        /// </summary>
        public string StartTotalnum { get; set; }

        /// <summary>
        /// 是否支持VIP卡，设置为true表示该商品支持VIP卡，设置为false或不设置表示不判断这个属性
        /// </summary>
        public string VipCard { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.items.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area", this.Area);
            parameters.Add("auto_send", this.AutoSend);
            parameters.Add("cash_coupon", this.CashCoupon);
            parameters.Add("cash_ondelivery", this.CashOndelivery);
            parameters.Add("cid", this.Cid);
            parameters.Add("end_commissionNum", this.EndCommissionNum);
            parameters.Add("end_commissionRate", this.EndCommissionRate);
            parameters.Add("end_credit", this.EndCredit);
            parameters.Add("end_price", this.EndPrice);
            parameters.Add("end_totalnum", this.EndTotalnum);
            parameters.Add("fields", this.Fields);
            parameters.Add("guarantee", this.Guarantee);
            parameters.Add("is_mobile", this.IsMobile);
            parameters.Add("keyword", this.Keyword);
            parameters.Add("mall_item", this.MallItem);
            parameters.Add("nick", this.Nick);
            parameters.Add("onemonth_repair", this.OnemonthRepair);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("overseas_item", this.OverseasItem);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("pid", this.Pid);
            parameters.Add("real_describe", this.RealDescribe);
            parameters.Add("refer_type", this.ReferType);
            parameters.Add("sevendays_return", this.SevendaysReturn);
            parameters.Add("sort", this.Sort);
            parameters.Add("start_commissionNum", this.StartCommissionNum);
            parameters.Add("start_commissionRate", this.StartCommissionRate);
            parameters.Add("start_credit", this.StartCredit);
            parameters.Add("start_price", this.StartPrice);
            parameters.Add("start_totalnum", this.StartTotalnum);
            parameters.Add("vip_card", this.VipCard);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("cid", this.Cid, 2147483647);
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxValue("page_no", this.PageNo, 10);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 400);
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
