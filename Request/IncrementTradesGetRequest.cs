using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.increment.trades.get
    /// </summary>
    public class IncrementTradesGetRequest : ITopRequest<IncrementTradesGetResponse>
    {
        /// <summary>
        /// 消息所对应的操作时间的最大值。和start_modified搭配使用能过滤消通知消息的时间段。不传时：如果设置了start_modified，默认为与start_modified同一天的23:59:59；否则默认为调用接口当天的23:59:59。（格式：yyyy-MM-dd HH:mm:ss）<br> <font color="red">注意：start_modified和end_modified的日期必须在必须在同一天内，比如：start_modified设置2000-01-01 00:00:00，则end_modified必须设置为2000-01-01这个日期</font>
        /// </summary>
        public Nullable<DateTime> EndModified { get; set; }

        /// <summary>
        /// 消息所属于的用户的昵称。设置此参数，返回的消息会根据传入nick的进行过滤。自用型appKey的昵称默认为自己的绑定昵称，此参数无效。
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数; 默认值:1,即返回第一页数据。
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数。取值范围:大于零的整数;最大值:200;默认值:40。
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 消息所对应的操作时间的最小值。和end_modified搭配使用能过滤消通知消息的时间段。不传时：如果设置了end_modified，默认为与end_modified同一天的00:00:00，否则默认为调用接口当天的00:00:00。（格式：yyyy-MM-dd HH:mm:ss）<br> <font color="red">注意：start_modified和end_modified的日期必须在必须在同一天内，比如：start_modified设置2000-01-01 00:00:00，则end_modified必须设置为2000-01-01这个日期</font>
        /// </summary>
        public Nullable<DateTime> StartModified { get; set; }

        /// <summary>
        /// 交易或评价的状态，默认查询所有状态的数据，除了默认值外每次只能查询一种状态。除了交易超时提醒消息没有type分类以外，交易的其他消息都有type分类。  可选值   TradeCreate（创建交易）   TradeModifyFee（修改交易费用）   TradeCloseAndModifyDetailOrder（关闭或修改子订单）   TradeClose（关闭交易）   TradeBuyerPay（买家付款）   TradeSellerShip（卖家发货）   TradeDelayConfirmPay（延长收货时间）   TradePartlyRefund（子订单退款成功）   TradePartlyConfirmPay（子订单打款成功）   TradeSuccess（交易成功）   TradeTimeoutRemind（交易超时提醒）   TradeRated（交易评价变更）   TradeMemoModified（交易备注修改）   TradeLogisticsAddressChanged（修改交易收货地址）   TradeChanged（修改订单信息（SKU等））
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 交易所属的类型，默认查询所有类型的数据，除了默认值外每次只能查询一种类型。交易超时提醒类型的消息没有消息类型，固定返回“timeout”。  可选值：  ec（直冲）   guarantee_trade（一口价、拍卖）   auto_delivery（自动发货）   cod（货到付款）   independent_shop_trade（旺店标准版交易）   independent_simple_trade（旺店入门版交易）   shopex_trade（ShopEX版)   netcn_trade（淘宝与万网合作版网）   travel（旅游产品交易）   fenxiao（分销平台交易）   game_equipment（网游虚拟交易）
        /// </summary>
        public string Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.increment.trades.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("nick", this.Nick);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("status", this.Status);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 200);
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
