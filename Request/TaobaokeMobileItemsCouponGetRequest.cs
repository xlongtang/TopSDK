using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.mobile.items.coupon.get
    /// </summary>
    public class TaobaokeMobileItemsCouponGetRequest : ITopRequest<TaobaokeMobileItemsCouponGetResponse>
    {
        /// <summary>
        /// 商品所在地
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 标准商品后台类目id。该ID可以通过taobao.itemcats.get接口获取到。
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 优惠商品类型.1:打折商品,默认值为1
        /// </summary>
        public Nullable<long> CouponType { get; set; }

        /// <summary>
        /// 设置30天累计推广量（与返回数据中的commission_num字段对应）上限.注：该字段要与start_commissionNum一起使用才生效
        /// </summary>
        public Nullable<long> EndCommissionNum { get; set; }

        /// <summary>
        /// 最高佣金比率选项，如：2345表示23.45%。注：要起始佣金比率和最高佣金比率一起设置才有效。
        /// </summary>
        public Nullable<long> EndCommissionRate { get; set; }

        /// <summary>
        /// 最高累计推广佣金选项
        /// </summary>
        public Nullable<long> EndCommissionVolume { get; set; }

        /// <summary>
        /// 设置折扣比例范围上限,如：8000表示80.00%.注：要起始折扣比率和最高折扣比率一起设置才有效
        /// </summary>
        public Nullable<long> EndCouponRate { get; set; }

        /// <summary>
        /// 可选值和start_credit一样.start_credit的值一定要小于或等于end_credit的值。注：end_credit与start_credit一起使用才生效
        /// </summary>
        public string EndCredit { get; set; }

        /// <summary>
        /// 设置商品总成交量（与返回字段volume对应）上限。
        /// </summary>
        public Nullable<long> EndVolume { get; set; }

        /// <summary>
        /// 需返回的字段列表.可选值:num_iid,title,nick,pic_url,price,click_url,commission,commission_rate,commission_num,commission_volume,shop_click_url,seller_credit_score,item_location,volume,coupon_price,coupon_rate,coupon_start_time,coupon_end_time,shop_type;字段之间用","分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 商品标题中包含的关键字. 注意:查询时keyword,cid至少选择其中一个参数
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 结果页数.1~99
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页返回结果数.最大每页100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 点击串跳转类型，1：单品，2：单品中间页（无线暂无）
        /// </summary>
        public Nullable<long> ReferType { get; set; }

        /// <summary>
        /// 店铺类型.默认all,商城:b,集市:c
        /// </summary>
        public string ShopType { get; set; }

        /// <summary>
        /// default(默认排序),  price_desc(折扣价格从高到低),  price_asc(折扣价格从低到高),  credit_desc(信用等级从高到低),  credit_asc(信用等级从低到高),  commissionRate_desc(佣金比率从高到低),  commissionRate_asc(佣金比率从低到高),  volume_desc(成交量成高到低), volume_asc(成交量从低到高)
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 设置30天累计推广量（与返回数据中的commission_num字段对应）下限.注：该字段要与end_commissionNum一起使用才生效
        /// </summary>
        public Nullable<long> StartCommissionNum { get; set; }

        /// <summary>
        /// 起始佣金比率选项，如：1234表示12.34%
        /// </summary>
        public Nullable<long> StartCommissionRate { get; set; }

        /// <summary>
        /// 起始累计推广量佣金.注：返回的数据是30天内累计推广佣金，该字段要与最高累计推广佣金一起使用才生效
        /// </summary>
        public Nullable<long> StartCommissionVolume { get; set; }

        /// <summary>
        /// 设置折扣比例范围下限,如：7000表示70.00%
        /// </summary>
        public Nullable<long> StartCouponRate { get; set; }

        /// <summary>
        /// 卖家信用: 1heart(一心) 2heart (两心) 3heart(三心) 4heart(四心) 5heart(五心) 1diamond(一钻) 2diamond(两钻) 3diamond(三钻) 4diamond(四钻) 5diamond(五钻) 1crown(一冠) 2crown(两冠) 3crown(三冠) 4crown(四冠) 5crown(五冠) 1goldencrown(一黄冠) 2goldencrown(二黄冠) 3goldencrown(三黄冠) 4goldencrown(四黄冠) 5goldencrown(五黄冠)
        /// </summary>
        public string StartCredit { get; set; }

        /// <summary>
        /// 设置商品总成交量（与返回字段volume对应）下限。
        /// </summary>
        public Nullable<long> StartVolume { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.mobile.items.coupon.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area", this.Area);
            parameters.Add("cid", this.Cid);
            parameters.Add("coupon_type", this.CouponType);
            parameters.Add("end_commission_num", this.EndCommissionNum);
            parameters.Add("end_commission_rate", this.EndCommissionRate);
            parameters.Add("end_commission_volume", this.EndCommissionVolume);
            parameters.Add("end_coupon_rate", this.EndCouponRate);
            parameters.Add("end_credit", this.EndCredit);
            parameters.Add("end_volume", this.EndVolume);
            parameters.Add("fields", this.Fields);
            parameters.Add("keyword", this.Keyword);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("refer_type", this.ReferType);
            parameters.Add("shop_type", this.ShopType);
            parameters.Add("sort", this.Sort);
            parameters.Add("start_commission_num", this.StartCommissionNum);
            parameters.Add("start_commission_rate", this.StartCommissionRate);
            parameters.Add("start_commission_volume", this.StartCommissionVolume);
            parameters.Add("start_coupon_rate", this.StartCouponRate);
            parameters.Add("start_credit", this.StartCredit);
            parameters.Add("start_volume", this.StartVolume);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("cid", this.Cid, 2147483647);
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
