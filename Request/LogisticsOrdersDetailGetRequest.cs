using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.orders.detail.get
    /// </summary>
    public class LogisticsOrdersDetailGetRequest : ITopRequest<LogisticsOrdersDetailGetResponse>
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 创建时间结束.格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> EndCreated { get; set; }

        /// <summary>
        /// 需返回的字段列表.可选值:Shipping 物流数据结构中所有字段.fileds中可以指定返回以上任意一个或者多个字段,以","分隔.
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 谁承担运费.可选值:buyer(买家),seller(卖家).如:buyer
        /// </summary>
        public string FreightPayer { get; set; }

        /// <summary>
        /// 页码.该字段没传 或 值<1 ,则默认page_no为1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数.该字段没传 或 值<1 ，则默认page_size为40
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 卖家是否发货.可选值:yes(是),no(否).如:yes.
        /// </summary>
        public string SellerConfirm { get; set; }

        /// <summary>
        /// 创建时间开始.格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> StartCreated { get; set; }

        /// <summary>
        /// 物流状态.可查看数据结构 Shipping 中的status字段.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 交易ID.如果加入tid参数的话,不用传其他的参数,但是仅会返回一条物流订单信息.
        /// </summary>
        public Nullable<long> Tid { get; set; }

        /// <summary>
        /// 物流方式.可选值:post(平邮),express(快递),ems(EMS).如:post
        /// </summary>
        public string Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.orders.detail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("fields", this.Fields);
            parameters.Add("freight_payer", this.FreightPayer);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("receiver_name", this.ReceiverName);
            parameters.Add("seller_confirm", this.SellerConfirm);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("status", this.Status);
            parameters.Add("tid", this.Tid);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
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
