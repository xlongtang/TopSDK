using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.mobile.items.relate.get
    /// </summary>
    public class TaobaokeMobileItemsRelateGetRequest : ITopRequest<TaobaokeMobileItemsRelateGetResponse>
    {
        /// <summary>
        /// 分类id.推荐类型为5时cid不能为空。仅支持叶子类目ID，即通过taobao.itemcats.get获取到is_parent=false的cid。
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 需返回的字段列表.可选值:num_iid,title,nick,pic_url,price,click_url,commission,ommission_rate,commission_num,commission_volume,shop_click_url,seller_credit_score,item_location,volume;字段之间用","分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 指定返回结果的最大条数.实际返回结果个数根据算法来确定,所以该值会小于或者等于该值
        /// </summary>
        public Nullable<long> MaxCount { get; set; }

        /// <summary>
        /// 淘宝客商品数字id.推荐类型为1,2,3时num_iid不能为空
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 点击串跳转类型，1：单品，2：单品中间页（无线暂无）
        /// </summary>
        public Nullable<long> ReferType { get; set; }

        /// <summary>
        /// <p>推荐类型.</p> <p>1:同类商品推荐;此时必须得输入num_iid</p> <p>2:异类商品推荐;此时必须得输入num_iid</p> <p>3:同店商品推荐;此时必须得输入num_iid</p> <p>4:店铺热门推荐;此时必须得输入seller_id，这里的seller_id得通过<a href="http://api.taobao.com/apidoc/api.htm?path=cid:38-apiId:10449">taobao.taobaoke.shops.get</a> 跟<a href="http://api.taobao.com/apidoc/api.htm?path=cid:38-apiId:21419">taobao.taobaoke.widget.shops.convert</a>这两个接口去获取user_id字段</p> <p>5:类目热门推荐;此时必须得输入cid</p>
        /// </summary>
        public Nullable<long> RelateType { get; set; }

        /// <summary>
        /// 卖家的用户id，这里的seller_id得通过<a href="http://api.taobao.com/apidoc/api.htm?path=cid:38-apiId:10449">taobao.taobaoke.shops.get</a> 跟<a href="http://api.taobao.com/apidoc/api.htm?path=cid:38-apiId:21419">taobao.taobaoke.widget.shops.convert</a>这两个接口去获取user_id字段。 注：推荐类型为4时seller_id不能为空
        /// </summary>
        public Nullable<long> SellerId { get; set; }

        /// <summary>
        /// 店铺类型.默认all,商城:b,集市:c
        /// </summary>
        public string ShopType { get; set; }

        /// <summary>
        /// default(默认排序,关联推荐相关度),price_desc(价格从高到低), price_asc(价格从低到高),commissionRate_desc(佣金比率从高到低), commissionRate_asc(佣金比率从低到高), commissionNum_desc(成交量成高到低), commissionNum_asc(成交量从低到高)
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 商品数字ID(带有跟踪效果)
        /// </summary>
        public string TrackIid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.mobile.items.relate.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("fields", this.Fields);
            parameters.Add("max_count", this.MaxCount);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("refer_type", this.ReferType);
            parameters.Add("relate_type", this.RelateType);
            parameters.Add("seller_id", this.SellerId);
            parameters.Add("shop_type", this.ShopType);
            parameters.Add("sort", this.Sort);
            parameters.Add("track_iid", this.TrackIid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("relate_type", this.RelateType);
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
