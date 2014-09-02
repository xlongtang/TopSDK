using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.widget.itempanel.get
    /// </summary>
    public class WidgetItempanelGetRequest : ITopRequest<WidgetItempanelGetResponse>
    {
        /// <summary>
        /// 参数fields为选填参数，表示需要返回哪些字段，默认为空：表示所有字段都返回。指定item_id返回item_id; 指定title返回title; 指定click_url返回click_url(如果此商品有淘宝客会默认返回转换过的淘宝客连接，绑定用户为appkey对应的用户); 指定price返回price(商品价格，如果有多个sku返回的是sku的价格区间); 指定quantify返回quantity(商品总数); 指定pic_url返回pic_url(商品主图地址); 指定item_pics返回item_pics(商品图片列表); 指定skus返回skus和sku_props组合; 指定shop_promotion_data返回shop_promotion_data(商品所属的店铺优惠信息); 指定item_promotion_data返回item_promotion_data(商品的优惠信息); 指定seller_nick返回seller_nick(卖家昵称); 指定is_mall返回is_mall(是否商城商品，true表示是商城商品);add_url不可选一定会返回
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 要查询的商品的数字id，等同于Item的num_iid
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.widget.itempanel.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("item_id", this.ItemId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
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
