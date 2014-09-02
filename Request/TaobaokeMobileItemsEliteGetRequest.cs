using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.taobaoke.mobile.items.elite.get
    /// </summary>
    public class TaobaokeMobileItemsEliteGetRequest : ITopRequest<TaobaokeMobileItemsEliteGetResponse>
    {
        /// <summary>
        /// 商品所在地，只作为权重
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 后台类目,逗号分隔
        /// </summary>
        public string Ecat { get; set; }

        /// <summary>
        /// 可选值和start_credit一样.start_credit的值一定要小于或等于end_credit的值。注：end_credit与start_credit一起使用才生效
        /// </summary>
        public string EndCredit { get; set; }

        /// <summary>
        /// 折扣比率上限，如：2345表示23.45%。注：start_discount_rate和end_discount_rate一起设置才有效。
        /// </summary>
        public Nullable<long> EndDiscountRate { get; set; }

        /// <summary>
        /// 最高价格
        /// </summary>
        public string EndPrice { get; set; }

        /// <summary>
        /// 需返回的字段列表.可选值:num_iid,title,nick,pic_url,price,click_url,commission,commission_rate,commission_num,commission_volume,shop_click_url,seller_credit_score,item_location,volume ;字段之间用","分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 自定义输入串.格式:英文和数字组成;长度不能大于12个字符,区分不同的推广渠道,如:bbs,表示bbs为推广渠道;blog,表示blog为推广渠道.
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 获取精品库商品数量
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 是否免邮费，设置为true都是免邮费商品，设置false只作为权重
        /// </summary>
        public Nullable<bool> PostageFree { get; set; }

        /// <summary>
        /// 关键词,使用逗号分割；q和ecat都存在以q为主
        /// </summary>
        public string Q { get; set; }

        /// <summary>
        /// 店铺类型.所有:all,商城:b,集市:c
        /// </summary>
        public string ShopType { get; set; }

        /// <summary>
        /// 图片大小。默认160x160。
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 卖家信用:    1heart(一心)   2heart (两心)   3heart(三心)   4heart(四心)   5heart(五心)   1diamond(一钻)   2diamond(两钻)   3diamond(三钻)   4diamond(四钻)   5diamond(五钻)   1crown(一冠)   2crown(两冠)   3crown(三冠)   4crown(四冠)   5crown(五冠)   1goldencrown(一黄冠)   2goldencrown(二黄冠)   3goldencrown(三黄冠)   4goldencrown(四黄冠)   5goldencrown(五黄冠)
        /// </summary>
        public string StartCredit { get; set; }

        /// <summary>
        /// 折扣比率下限，如：1234表示12.34%
        /// </summary>
        public Nullable<long> StartDiscountRate { get; set; }

        /// <summary>
        /// 起始价格.传入价格参数时,需注意起始价格和最高价格必须一起传入,并且 start_price <= end_price；价格范围只是作为权重，不作为过滤条件，在价格范围内优先展现。
        /// </summary>
        public string StartPrice { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.taobaoke.mobile.items.elite.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area", this.Area);
            parameters.Add("ecat", this.Ecat);
            parameters.Add("end_credit", this.EndCredit);
            parameters.Add("end_discount_rate", this.EndDiscountRate);
            parameters.Add("end_price", this.EndPrice);
            parameters.Add("fields", this.Fields);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("postage_free", this.PostageFree);
            parameters.Add("q", this.Q);
            parameters.Add("shop_type", this.ShopType);
            parameters.Add("size", this.Size);
            parameters.Add("start_credit", this.StartCredit);
            parameters.Add("start_discount_rate", this.StartDiscountRate);
            parameters.Add("start_price", this.StartPrice);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 40);
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
