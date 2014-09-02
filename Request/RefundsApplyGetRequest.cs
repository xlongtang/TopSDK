using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refunds.apply.get
    /// </summary>
    public class RefundsApplyGetRequest : ITopRequest<RefundsApplyGetResponse>
    {
        /// <summary>
        /// 需要返回的字段。目前支持有：refund_id, tid, title, buyer_nick, seller_nick, total_fee, status, created, refund_fee
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 页码。传入值为 1 代表第一页，传入值为 2 代表第二页，依此类推。默认返回的数据是从第一页开始
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数。取值范围:大于零的整数; 默认值:40;最大值:100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 退款状态，默认查询所有退款状态的数据，除了默认值外每次只能查询一种状态。  WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意)   WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货)   WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货)   SELLER_REFUSE_BUYER(卖家拒绝退款)   CLOSED(退款关闭)   SUCCESS(退款成功)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 交易类型列表，一次查询多种类型可用半角逗号分隔，默认同时查询guarantee_trade, auto_delivery的2种类型的数据。  fixed(一口价)   auction(拍卖)   guarantee_trade(一口价、拍卖)   independent_simple_trade(旺店入门版交易)   independent_shop_trade(旺店标准版交易)   auto_delivery(自动发货)   ec(直冲)   cod(货到付款)   fenxiao(分销)   game_equipment(游戏装备)   shopex_trade(ShopEX交易)   netcn_trade(万网交易)   external_trade(统一外部交易)
        /// </summary>
        public string Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refunds.apply.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
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
