using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.traderates.get
    /// </summary>
    public class TraderatesGetRequest : ITopRequest<TraderatesGetResponse>
    {
        /// <summary>
        /// 评价结束时间。如果只输入结束时间，那么全部返回所有评价数据。
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// 需返回的字段列表。可选值：TradeRate 结构中的所有字段，多个字段之间用“,”分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 商品的数字ID
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数最大限制为200; 默认值:1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页获取条数。默认值40，最小值1，最大值150。
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 评价类型。可选值:get(得到),give(给出)
        /// </summary>
        public string RateType { get; set; }

        /// <summary>
        /// 评价结果。可选值:good(好评),neutral(中评),bad(差评)
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 评价者角色即评价的发起方。可选值:seller(卖家),buyer(买家)。 当 give buyer 以买家身份给卖家的评价； 当 get seller 以买家身份得到卖家给的评价； 当 give seller 以卖家身份给买家的评价； 当 get buyer 以卖家身份得到买家给的评价。
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// 评价开始时。如果只输入开始时间，那么能返回开始时间之后的评价数据。
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        /// <summary>
        /// 交易订单id，可以是父订单id号，也可以是子订单id号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        /// <summary>
        /// 是否启用has_next的分页方式，如果指定true,则返回的结果中不包含总记录数，但是会新增一个是否存在下一页的的字段，通过此种方式获取评价信息，效率在原有的基础上有80%的提升。
        /// </summary>
        public Nullable<bool> UseHasNext { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.traderates.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("fields", this.Fields);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("rate_type", this.RateType);
            parameters.Add("result", this.Result);
            parameters.Add("role", this.Role);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("tid", this.Tid);
            parameters.Add("use_has_next", this.UseHasNext);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 150);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateRequired("rate_type", this.RateType);
            RequestValidator.ValidateRequired("role", this.Role);
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
