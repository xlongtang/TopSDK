using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.items.discount.search
    /// </summary>
    public class TmallItemsDiscountSearchRequest : ITopRequest<TmallItemsDiscountSearchResponse>
    {
        /// <summary>
        /// 商品标签。品牌特卖商品库：3458；天猫原创商品库：4801,不再支持 天猫精品库：8578；
        /// </summary>
        public Nullable<long> AuctionTag { get; set; }

        /// <summary>
        /// 品牌的id。点击某品牌类目的时候会出现。
        /// </summary>
        public Nullable<long> Brand { get; set; }

        /// <summary>
        /// 前台类目id，目前其他接口无法获取，只能自己去寻找。建议使用关键字获取数据。支持多选过滤，cat=catid1,catid2。
        /// </summary>
        public string Cat { get; set; }

        /// <summary>
        /// 商品最高价格
        /// </summary>
        public string EndPrice { get; set; }

        /// <summary>
        /// 是否包邮，-1为包邮
        /// </summary>
        public Nullable<long> PostFee { get; set; }

        /// <summary>
        /// 表示搜索的关键字，例如搜索query=nike。当输入关键字为中文时，将对他进行URLEncode的UTF-8格式编码，如 耐克，那么q=%E8%80%90%E5%85%8B。
        /// </summary>
        public string Q { get; set; }

        /// <summary>
        /// 排序类型。类型包括：  s: 人气排序  p: 价格从低到高;  pd: 价格从高到低;  d: 月销量从高到低;  td: 总销量从高到低;  pt: 按发布时间排序.
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 可以用该字段来实现分页功能。表示查询起始位置，默认从第0条开始，start=10,表示从第10条数据开始查询，start不得大于1000。
        /// </summary>
        public Nullable<long> Start { get; set; }

        /// <summary>
        /// 商品最低价格
        /// </summary>
        public string StartPrice { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.items.discount.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auction_tag", this.AuctionTag);
            parameters.Add("brand", this.Brand);
            parameters.Add("cat", this.Cat);
            parameters.Add("end_price", this.EndPrice);
            parameters.Add("post_fee", this.PostFee);
            parameters.Add("q", this.Q);
            parameters.Add("sort", this.Sort);
            parameters.Add("start", this.Start);
            parameters.Add("start_price", this.StartPrice);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("start", this.Start, 1000);
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
