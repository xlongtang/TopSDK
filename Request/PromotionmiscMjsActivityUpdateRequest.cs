using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.promotionmisc.mjs.activity.update
    /// </summary>
    public class PromotionmiscMjsActivityUpdateRequest : ITopRequest<PromotionmiscMjsActivityUpdateResponse>
    {
        /// <summary>
        /// 活动id。
        /// </summary>
        public Nullable<long> ActivityId { get; set; }

        /// <summary>
        /// 减多少钱。当is_decrease_money为true时，该值才有意义。注意：该值单位为分，即100表示1元。
        /// </summary>
        public Nullable<long> DecreaseAmount { get; set; }

        /// <summary>
        /// 折扣值。当is_discount为true时，该值才有意义。注意：800表示8折。
        /// </summary>
        public Nullable<long> DiscountRate { get; set; }

        /// <summary>
        /// 活动结束时间。
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 免邮的排除地区，即，除指定地区外，其他地区包邮。当is_free_post为true时，该值才有意义。代码使用*链接，代码为行政区划代码。
        /// </summary>
        public string ExcludeArea { get; set; }

        /// <summary>
        /// 礼品id，当is_send_gift为true时，该值才有意义。 1）只有填写真实的淘宝商品id时，才能生成物流单，并且在确定订单的页面上可以点击该商品名称跳转到商品详情页面。2）当礼物为实物商品时(有宝贝id),礼物必须为上架商品,不能为虚拟商品,不能为拍卖商品,不能有sku,不符合条件的,不做为礼物。
        /// </summary>
        public Nullable<long> GiftId { get; set; }

        /// <summary>
        /// 礼品名称。当is_send_gift为true时，该值才有意义。
        /// </summary>
        public string GiftName { get; set; }

        /// <summary>
        /// 商品详情的url，当is_send_gift为true时，该值才有效。
        /// </summary>
        public string GiftUrl { get; set; }

        /// <summary>
        /// 满元是否上不封顶。当is_amount_over为true时，该值才有意义。当该值为true时，表示满元上不封顶，例如满100元减10元，当满200时，则减20元。。。默认为false。
        /// </summary>
        public Nullable<bool> IsAmountMultiple { get; set; }

        /// <summary>
        /// 是否有满元条件。
        /// </summary>
        public Nullable<bool> IsAmountOver { get; set; }

        /// <summary>
        /// 是否有减钱行为。
        /// </summary>
        public Nullable<bool> IsDecreaseMoney { get; set; }

        /// <summary>
        /// 是否有打折行为。
        /// </summary>
        public Nullable<bool> IsDiscount { get; set; }

        /// <summary>
        /// 是否有免邮行为。
        /// </summary>
        public Nullable<bool> IsFreePost { get; set; }

        /// <summary>
        /// 是否有满件条件。
        /// </summary>
        public Nullable<bool> IsItemCountOver { get; set; }

        /// <summary>
        /// 满件是否上不封顶。当is_amount_multiple为true时，该值才有意义。当该值为true时，表示满件上不封顶，例如满10件减2元，当满20件时，则减4元。。。 默认为false。
        /// </summary>
        public Nullable<bool> IsItemMultiple { get; set; }

        /// <summary>
        /// 是否有送礼品行为。
        /// </summary>
        public Nullable<bool> IsSendGift { get; set; }

        /// <summary>
        /// 是否有店铺会员等级条件。
        /// </summary>
        public Nullable<bool> IsShopMember { get; set; }

        /// <summary>
        /// 是否指定用户标签。
        /// </summary>
        public Nullable<bool> IsUserTag { get; set; }

        /// <summary>
        /// 满多少件。当is_item_count_over为true时，该值才有意义。
        /// </summary>
        public Nullable<long> ItemCount { get; set; }

        /// <summary>
        /// 活动名称。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 活动范围：0表示全部参与； 1表示部分商品参与。
        /// </summary>
        public Nullable<long> ParticipateRange { get; set; }

        /// <summary>
        /// 店铺会员等级，当is_shop_member为true时，该值才有意义。0：店铺客户；1：普通客户；2：高级会员；3：VIP会员； 4：至尊VIP会员。
        /// </summary>
        public Nullable<long> ShopMemberLevel { get; set; }

        /// <summary>
        /// 活动开始时间。
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 满多少元。当is_amount_over为true时，该才字段有意义。注意：单位是分，即10000表示100元。
        /// </summary>
        public Nullable<long> TotalPrice { get; set; }

        /// <summary>
        /// 用户标签。当is_user_tag为true时，该值才有意义。
        /// </summary>
        public string UserTag { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.promotionmisc.mjs.activity.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("activity_id", this.ActivityId);
            parameters.Add("decrease_amount", this.DecreaseAmount);
            parameters.Add("discount_rate", this.DiscountRate);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("exclude_area", this.ExcludeArea);
            parameters.Add("gift_id", this.GiftId);
            parameters.Add("gift_name", this.GiftName);
            parameters.Add("gift_url", this.GiftUrl);
            parameters.Add("is_amount_multiple", this.IsAmountMultiple);
            parameters.Add("is_amount_over", this.IsAmountOver);
            parameters.Add("is_decrease_money", this.IsDecreaseMoney);
            parameters.Add("is_discount", this.IsDiscount);
            parameters.Add("is_free_post", this.IsFreePost);
            parameters.Add("is_item_count_over", this.IsItemCountOver);
            parameters.Add("is_item_multiple", this.IsItemMultiple);
            parameters.Add("is_send_gift", this.IsSendGift);
            parameters.Add("is_shop_member", this.IsShopMember);
            parameters.Add("is_user_tag", this.IsUserTag);
            parameters.Add("item_count", this.ItemCount);
            parameters.Add("name", this.Name);
            parameters.Add("participate_range", this.ParticipateRange);
            parameters.Add("shop_member_level", this.ShopMemberLevel);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("total_price", this.TotalPrice);
            parameters.Add("user_tag", this.UserTag);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("activity_id", this.ActivityId);
            RequestValidator.ValidateMinValue("activity_id", this.ActivityId, 0);
            RequestValidator.ValidateMinValue("decrease_amount", this.DecreaseAmount, 0);
            RequestValidator.ValidateMinValue("discount_rate", this.DiscountRate, 0);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateMaxLength("gift_name", this.GiftName, 32);
            RequestValidator.ValidateMinValue("item_count", this.ItemCount, 0);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 32);
            RequestValidator.ValidateRequired("participate_range", this.ParticipateRange);
            RequestValidator.ValidateMaxValue("participate_range", this.ParticipateRange, 1);
            RequestValidator.ValidateMinValue("participate_range", this.ParticipateRange, 0);
            RequestValidator.ValidateMaxValue("shop_member_level", this.ShopMemberLevel, 9);
            RequestValidator.ValidateMinValue("shop_member_level", this.ShopMemberLevel, 0);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
            RequestValidator.ValidateMinValue("total_price", this.TotalPrice, 0);
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
