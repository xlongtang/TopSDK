using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.waimai.orders.get
    /// </summary>
    public class TradeWaimaiOrdersGetRequest : ITopRequest<TradeWaimaiOrdersGetResponse>
    {
        /// <summary>
        /// true 仅有支付宝订单,false 包括所有类型订单(货到付款,支付券等)
        /// </summary>
        public Nullable<bool> IsAllOrder { get; set; }

        /// <summary>
        /// true-查询仅按商家维度  false-查询按商家下所属店铺维度
        /// </summary>
        public Nullable<bool> IsAllShop { get; set; }

        /// <summary>
        /// 买家昵称/订单ID 搜索
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 订单状态 待确认订单2 , 退款中订单4 , 已发货12 关闭20 交易成功21
        /// </summary>
        public Nullable<long> OrderStatus { get; set; }

        /// <summary>
        /// 页码<br /> 支持的最大列表长度为：100
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 返回记录数，超过20按20条返回数据<br /> 支持最大值为：20<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 外卖分店ID
        /// </summary>
        public Nullable<long> ShopId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.waimai.orders.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_all_order", this.IsAllOrder);
            parameters.Add("is_all_shop", this.IsAllShop);
            parameters.Add("keyword", this.Keyword);
            parameters.Add("order_status", this.OrderStatus);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("shop_id", this.ShopId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("is_all_shop", this.IsAllShop);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 20);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
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
