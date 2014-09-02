using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.sold.orders.increment.get
    /// </summary>
    public class HotelSoldOrdersIncrementGetRequest : ITopRequest<HotelSoldOrdersIncrementGetResponse>
    {
        /// <summary>
        /// 查询修改结束时间，必须大于修改开始时间（修改时间跨度不能大于1天）。格式：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        public Nullable<DateTime> EndModified { get; set; }

        /// <summary>
        /// 是否需要返回该订单的入住人列表。可选值：true，false。
        /// </summary>
        public Nullable<bool> NeedGuest { get; set; }

        /// <summary>
        /// 是否返回买家留言，可选值true、false
        /// </summary>
        public Nullable<bool> NeedMessage { get; set; }

        /// <summary>
        /// 分页页码。取值范围，大于零的整数，默认值1，即返回第一页的数据。
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 页面大小，取值范围1-100，默认大小20。
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询修改开始时间（修改时间跨度不能大于1天）。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> StartModified { get; set; }

        /// <summary>
        /// 交易状态，默认查询所有交易状态的数据，除了默认值外每次只能查询一种状态。可选值：A：等待买家付款。B：买家已付款待卖家发货。C：卖家已发货待买家确认。D：交易成功。E：交易关闭<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 是否使用has_next的分页方式，如果指定true，则返回的结果中不包含总记录数，但是会新增一个是否存在下一页的字段，效率比总记录数高
        /// </summary>
        public Nullable<bool> UseHasNext { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.sold.orders.increment.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("need_guest", this.NeedGuest);
            parameters.Add("need_message", this.NeedMessage);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("status", this.Status);
            parameters.Add("use_has_next", this.UseHasNext);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_modified", this.EndModified);
            RequestValidator.ValidateRequired("start_modified", this.StartModified);
            RequestValidator.ValidateMaxLength("status", this.Status, 1);
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
