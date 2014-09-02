using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sp.item.info.list.advanced.get
    /// </summary>
    public class SpItemInfoListAdvancedGetRequest : ITopRequest<SpItemInfoListAdvancedGetResponse>
    {
        /// <summary>
        /// 商品所在地:省名
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 标准商品后台类目id。该ID可以通过taobao.itemcats.get接口获取到。
        /// </summary>
        public Nullable<long> Cid { get; set; }

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
        /// 商品标题中包含的关键字. 注意:查询时keyword,cid至少选择其中一个参数
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 结果页数
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页返回结果数.最大每页40
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 站点key<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string SiteKey { get; set; }

        /// <summary>
        /// price_asc: 价格从低到高, 默认为折扣价格; sales_desc:销量从高到低; credit_desc:信用从高到低
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 佣金比率下限，如：1234表示12.34%
        /// </summary>
        public string StartCommissionRate { get; set; }

        /// <summary>
        /// 卖家信用: 1(一心) 2(两心) 3(三心) 4(四心) 5(五心) 6(一钻) 7(两钻) 8(三钻) 9(四钻) 10(五钻) 11(一冠) 12(两冠) 13(三冠) 14(四冠) 15(五冠) 16(一黄冠) 17(二黄冠) 18(三黄冠) 19(四黄冠) 20(五黄冠)
        /// </summary>
        public string StartCredit { get; set; }

        /// <summary>
        /// 起始价格, 默认为折扣价格.传入价格参数时,需注意起始价格和最高价格必须一起传入,并且 start_price <= end_price
        /// </summary>
        public string StartPrice { get; set; }

        /// <summary>
        /// 是否商城的商品，设置为true表示该商品是属于淘宝商城的商品，设置为false或不设置表示不判断这个属性
        /// </summary>
        public string TmallItem { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sp.item.info.list.advanced.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area", this.Area);
            parameters.Add("cid", this.Cid);
            parameters.Add("end_commission_rate", this.EndCommissionRate);
            parameters.Add("end_credit", this.EndCredit);
            parameters.Add("end_price", this.EndPrice);
            parameters.Add("keyword", this.Keyword);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("site_key", this.SiteKey);
            parameters.Add("sort", this.Sort);
            parameters.Add("start_commission_rate", this.StartCommissionRate);
            parameters.Add("start_credit", this.StartCredit);
            parameters.Add("start_price", this.StartPrice);
            parameters.Add("tmall_item", this.TmallItem);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("site_key", this.SiteKey);
            RequestValidator.ValidateMaxLength("site_key", this.SiteKey, 32);
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
