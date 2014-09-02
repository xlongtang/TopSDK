using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.orders.search
    /// </summary>
    public class HotelOrdersSearchRequest : ITopRequest<HotelOrdersSearchResponse>
    {
        /// <summary>
        /// 入住时间查询结束时间，格式为：yyyy-MM-dd。不能早于checkin_date_start，间隔不能大于30
        /// </summary>
        public Nullable<DateTime> CheckinDateEnd { get; set; }

        /// <summary>
        /// 入住时间查询起始时间，格式为：yyyy-MM-dd
        /// </summary>
        public Nullable<DateTime> CheckinDateStart { get; set; }

        /// <summary>
        /// 离店时间查询结束时间，格式为：yyyy-MM-dd。不能早于checkout_date_start，间隔不能大于30
        /// </summary>
        public Nullable<DateTime> CheckoutDateEnd { get; set; }

        /// <summary>
        /// 离店时间查询起始时间，格式为：yyyy-MM-dd
        /// </summary>
        public Nullable<DateTime> CheckoutDateStart { get; set; }

        /// <summary>
        /// 订单创建时间查询结束时间，格式为：yyyy-MM-dd。不能早于created_start，间隔不能大于30
        /// </summary>
        public Nullable<DateTime> CreatedEnd { get; set; }

        /// <summary>
        /// 订单创建时间查询起始时间，格式为：yyyy-MM-dd
        /// </summary>
        public Nullable<DateTime> CreatedStart { get; set; }

        /// <summary>
        /// 商品gid列表，多个gid用英文逗号隔开，一次不超过5个
        /// </summary>
        public string Gids { get; set; }

        /// <summary>
        /// 酒店hid列表，多个hid用英文逗号隔开，一次不超过5个
        /// </summary>
        public string Hids { get; set; }

        /// <summary>
        /// 是否需要返回该订单的入住人列表。可选值：true，false。
        /// </summary>
        public Nullable<bool> NeedGuest { get; set; }

        /// <summary>
        /// 是否显示买家留言，可选值true、false
        /// </summary>
        public Nullable<bool> NeedMessage { get; set; }

        /// <summary>
        /// 酒店订单oids列表，多个oid用英文逗号隔开，一次不超过20个。oids，tids，hids，rids，gids，（checkin_date_start，checkin_date_end），（checkout_date_start，checkout_date_end），（created_start，created_end）必须传入一项，括号表示需同时存在才做为查询条件。  oids，tids，hids，rids，gids同时出现时，优先级按此顺序由高到低只取一项。其他同时出现时，并列使用。
        /// </summary>
        public string Oids { get; set; }

        /// <summary>
        /// 分页页码。取值范围，大于零的整数，默认值1，即返回第一页的数据。页面大小为20
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 房型rid列表，多个rid用英文逗号隔开，一次不超过5个
        /// </summary>
        public string Rids { get; set; }

        /// <summary>
        /// 订单状态。A：等待买家付款。B：买家已付款待卖家发货。C：卖家已发货待买家确认。D：交易成功。E：交易关闭<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 淘宝订单tid列表，多个tid用英文逗号隔开，一次不超过20个。
        /// </summary>
        public string Tids { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.orders.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("checkin_date_end", this.CheckinDateEnd);
            parameters.Add("checkin_date_start", this.CheckinDateStart);
            parameters.Add("checkout_date_end", this.CheckoutDateEnd);
            parameters.Add("checkout_date_start", this.CheckoutDateStart);
            parameters.Add("created_end", this.CreatedEnd);
            parameters.Add("created_start", this.CreatedStart);
            parameters.Add("gids", this.Gids);
            parameters.Add("hids", this.Hids);
            parameters.Add("need_guest", this.NeedGuest);
            parameters.Add("need_message", this.NeedMessage);
            parameters.Add("oids", this.Oids);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("rids", this.Rids);
            parameters.Add("status", this.Status);
            parameters.Add("tids", this.Tids);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
