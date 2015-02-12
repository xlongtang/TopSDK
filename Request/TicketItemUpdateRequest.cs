using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ticket.item.update
    /// </summary>
    public class TicketItemUpdateRequest : ITopRequest<TicketItemUpdateResponse>
    {
        /// <summary>
        /// 门票商品返点比例（只对B卖家开放，单位为%）
        /// </summary>
        public string AuctionPoint { get; set; }

        /// <summary>
        /// 门票商品状态（onsale：上架，instock：仓库）
        /// </summary>
        public string AuctionStatus { get; set; }

        /// <summary>
        /// 门票商品所在地-城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 门票宝贝描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 门票商品电子凭证是否关联本地商户-在门票商品为电子凭证时必选
        /// </summary>
        public Nullable<bool> EtcAssociationStatus { get; set; }

        /// <summary>
        /// 门票商品电子凭证的自动退款比例-在门票商品为电子凭证时必选
        /// </summary>
        public Nullable<long> EtcAutoRefund { get; set; }

        /// <summary>
        /// 门票商品电子凭证的码商-在门票商品为电子凭证时必选
        /// </summary>
        public string EtcMerchantId { get; set; }

        /// <summary>
        /// 门票商品电子凭证的码商名-在门票商品为电子凭证时必选
        /// </summary>
        public string EtcMerchantNick { get; set; }

        /// <summary>
        /// 门票商品电子凭证网店ID-在门票商品为电子凭证时必选
        /// </summary>
        public string EtcNetworkId { get; set; }

        /// <summary>
        /// 门票商品电子凭证的过期退款比例-在门票商品为电子凭证时必选
        /// </summary>
        public Nullable<long> EtcOverduePay { get; set; }

        /// <summary>
        /// 门票商品电子凭证是否核销打款-在门票商品为电子凭证时必选
        /// </summary>
        public Nullable<bool> EtcVerificationPay { get; set; }

        /// <summary>
        /// 门票商品是否有发票（有发票：true，没有发票：false）.  对于B卖家来说只能选择有发票。
        /// </summary>
        public Nullable<bool> HaveInvoice { get; set; }

        /// <summary>
        /// 商品主图-该值来自图片空间接口返回的图片链接（不包含域名和前缀）
        /// </summary>
        public string Image1 { get; set; }

        /// <summary>
        /// 第一张多图-该值来自图片空间接口返回的图片链接（不包含域名和前缀）
        /// </summary>
        public string Image2 { get; set; }

        /// <summary>
        /// 第二张多图-该值来自图片空间接口返回的图片链接（不包含域名和前缀）
        /// </summary>
        public string Image3 { get; set; }

        /// <summary>
        /// 第三张多图-该值来自图片空间接口返回的图片链接（不包含域名和前缀）
        /// </summary>
        public string Image4 { get; set; }

        /// <summary>
        /// 第四张多图-该值来自图片空间接口返回的图片链接（不包含域名和前缀）
        /// </summary>
        public string Image5 { get; set; }

        /// <summary>
        /// 需要更新的门票商品标识（只支持门票二期商品）
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 门票商品的上架时间（精确到分，格式为：yyyy-MM-dd HH:mm）
        /// </summary>
        public string ListTime { get; set; }

        /// <summary>
        /// 门票商品的物流运费模板-在产品规格使用到物流时必选
        /// </summary>
        public Nullable<long> PostageId { get; set; }

        /// <summary>
        /// 门票商品挂载到的产品<br>  通过taobao.products.search获取产品信息，并且对应产品必须是小二确认的达尔文体系产品。
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 门票商品是否橱窗推荐（橱窗推荐；true，不推荐则可不用设置该值）
        /// </summary>
        public Nullable<bool> PromotedStatus { get; set; }

        /// <summary>
        /// 门票商品所在地-省份
        /// </summary>
        public string Prov { get; set; }

        /// <summary>
        /// 需要删除的字段列表
        /// </summary>
        public string RemoveFields { get; set; }

        /// <summary>
        /// 门票宝贝所属的店铺分类列表-店铺分类标识请使用店铺相关接口获取获取，多个店铺分类标识之间通过逗号进行分隔，最多包含10个分类标识
        /// </summary>
        public string ShopCats { get; set; }

        /// <summary>
        /// 门票商品产品规格信息（门票的产品规格信息可以通过tmall.product.specs.get接口获取）<br>。请通过门票商品使用的产品所对应的产品规格信息进行设置，注意由于产品规格信息比较复杂，所以直接使用json作为传输，请按照约定传入正确的json格式）<br>  格式定义：<br>  <pre>  {    "SKU":   {    "20890017-121840019_20394-121290067":{// 产品下的某个产品规格的属性属性值信息（pid-vid_pid-vid）     "effDates":{      "1":{       "type":"0",// 有效期类型，0-非指定日票，1-指定日票，2-年卡       "effDate" :{ // 有效期，如下几块，type已经去掉        "startDate":"2013-01-01",// 有效期时间段开始时间,null代表未设置        "endDate":"2013-12-31",// 有效期时间段结束时间,null代表未设置        "weeks":["1","4"],// 有效期周,1~7代表周一到周日，null代表未设置        "startHour":"12",// 有效期开始时间小时,null代表未设置        "startMinute":"59",// 有效期开始时间分钟,null代表未设置        "endHour":"18"// 有效期结束时间小时,null代表未设置        "endMinute":"30"// 有效期结束时间分钟,null代表未设置        "effDays":"1",// xx后n天内有效的天数，购买后、出票后、开卡后n天内有效,null代表未设置       },       "timeLimit":{// 入园时间限制数据        "limit":{         "type":"0",// 入园时间限制类型,0-不限，1-提前n天的n点n分，2-提前n小时n分钟         "aheadDays":"3",// 入园时间限制类型为提前n天的n点n分时才使用，入园时间提前n天的天数         "aheadAtHour":"12",// 入园时间限制类型为提前n天的n点n分时才使用，入园时间在n点n分之前的小时         "aheadAtMinute":"30",// 入园时间限制类型为提前n天的n点n分时才使用，入园时间在n点n分之前的分钟         "aheadHours":"48",// 入园时间限制类型为提前n小时n分时才使用，入园时间提前n小时的小时         "aheadMinutes":"30",// 入园时间限制类型为提前n小时n分时才使用，入园时间提前n分钟的分钟        }        "autoActivate":{ // 有效期类型为年卡时才使用         "type":"0",// 是否有最晚自动开卡时间,0-无，1-有最晚自动开卡         "time":"30" // 天数,无最晚自动开发时间时为null        }       }         "price" : 10000,        "inventory" : 100,       "outerId" : "商家编码"      },      "222":{}     },     "save":true, // 必须，代表是保存的有效数据        "returnRule":{       "type":"0",      // 0,1,2       "value":""      // type 0:""，1:""，2:"卖家输入的文本"      },      "changeRule":{       "type":"1",      // 0,1,2       "value":""      // type 0:""，1:""，2:"卖家输入的文本"      },      "guide": "卖家输入的文本"    }   }  }  </pre><br>
        /// </summary>
        public string Skus { get; set; }

        /// <summary>
        /// 门票商品库存技术方式（拍下减库存：true，付款减库存：false）
        /// </summary>
        public Nullable<bool> SubStockAtBuy { get; set; }

        /// <summary>
        /// 门票商品标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 门票商品视频-视频标识由多媒体中相关接口获取
        /// </summary>
        public Nullable<long> VideoId { get; set; }

        /// <summary>
        /// 门票商品是否参与店铺会员打折
        /// </summary>
        public Nullable<bool> VipPromoted { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ticket.item.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auction_point", this.AuctionPoint);
            parameters.Add("auction_status", this.AuctionStatus);
            parameters.Add("city", this.City);
            parameters.Add("description", this.Description);
            parameters.Add("etc.association_status", this.EtcAssociationStatus);
            parameters.Add("etc.auto_refund", this.EtcAutoRefund);
            parameters.Add("etc.merchant_id", this.EtcMerchantId);
            parameters.Add("etc.merchant_nick", this.EtcMerchantNick);
            parameters.Add("etc.network_id", this.EtcNetworkId);
            parameters.Add("etc.overdue_pay", this.EtcOverduePay);
            parameters.Add("etc.verification_pay", this.EtcVerificationPay);
            parameters.Add("have_invoice", this.HaveInvoice);
            parameters.Add("image_1", this.Image1);
            parameters.Add("image_2", this.Image2);
            parameters.Add("image_3", this.Image3);
            parameters.Add("image_4", this.Image4);
            parameters.Add("image_5", this.Image5);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("list_time", this.ListTime);
            parameters.Add("postage_id", this.PostageId);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("promoted_status", this.PromotedStatus);
            parameters.Add("prov", this.Prov);
            parameters.Add("remove_fields", this.RemoveFields);
            parameters.Add("shop_cats", this.ShopCats);
            parameters.Add("skus", this.Skus);
            parameters.Add("sub_stock_at_buy", this.SubStockAtBuy);
            parameters.Add("title", this.Title);
            parameters.Add("video_id", this.VideoId);
            parameters.Add("vip_promoted", this.VipPromoted);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("auction_status", this.AuctionStatus, 10);
            RequestValidator.ValidateMaxLength("city", this.City, 20);
            RequestValidator.ValidateMaxLength("description", this.Description, 25000);
            RequestValidator.ValidateMaxValue("etc.auto_refund", this.EtcAutoRefund, 100);
            RequestValidator.ValidateMinValue("etc.auto_refund", this.EtcAutoRefund, 0);
            RequestValidator.ValidateMaxValue("etc.overdue_pay", this.EtcOverduePay, 100);
            RequestValidator.ValidateMinValue("etc.overdue_pay", this.EtcOverduePay, 0);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateMaxLength("list_time", this.ListTime, 20);
            RequestValidator.ValidateMaxLength("prov", this.Prov, 20);
            RequestValidator.ValidateMaxLength("title", this.Title, 60);
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
