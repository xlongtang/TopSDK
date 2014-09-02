using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.members.get
    /// </summary>
    public class CrmMembersGetRequest : ITopRequest<CrmMembersGetResponse>
    {
        /// <summary>
        /// 买家的昵称<br /> 支持最大长度为：1000<br /> 支持的最大列表长度为：1000
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 显示第几页的会员，如果输入的页码大于总共的页码数，例如总共10页，但是current_page的值为11，则返回空白页，最小页数为1，最大页数为1000<br /> 支持最大值为：1000<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 会员等级，0：店铺客户，1：普通会员，2：高级会员，3：VIP会员， 4：至尊VIP会员。如果不传入值则默认为全部等级。<br /> 支持最大值为：4<br /> 支持最小值为：-1<br /> 支持的最大列表长度为：32
        /// </summary>
        public Nullable<long> Grade { get; set; }

        /// <summary>
        /// 最迟上次交易时间
        /// </summary>
        public Nullable<DateTime> MaxLastTradeTime { get; set; }

        /// <summary>
        /// 最大交易额，单位为元
        /// </summary>
        public string MaxTradeAmount { get; set; }

        /// <summary>
        /// 最大交易量<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> MaxTradeCount { get; set; }

        /// <summary>
        /// 最早上次交易时间
        /// </summary>
        public Nullable<DateTime> MinLastTradeTime { get; set; }

        /// <summary>
        /// 最小交易额,单位为元
        /// </summary>
        public string MinTradeAmount { get; set; }

        /// <summary>
        /// 最小交易量<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> MinTradeCount { get; set; }

        /// <summary>
        /// 表示每页显示的会员数量,page_size的最大值不能超过100条,最小值不能低于1，<br /> 支持最大值为：100<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.members.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("grade", this.Grade);
            parameters.Add("max_last_trade_time", this.MaxLastTradeTime);
            parameters.Add("max_trade_amount", this.MaxTradeAmount);
            parameters.Add("max_trade_count", this.MaxTradeCount);
            parameters.Add("min_last_trade_time", this.MinLastTradeTime);
            parameters.Add("min_trade_amount", this.MinTradeAmount);
            parameters.Add("min_trade_count", this.MinTradeCount);
            parameters.Add("page_size", this.PageSize);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("buyer_nick", this.BuyerNick, 1000);
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
            RequestValidator.ValidateMaxValue("current_page", this.CurrentPage, 1000);
            RequestValidator.ValidateMinValue("current_page", this.CurrentPage, 1);
            RequestValidator.ValidateMaxValue("grade", this.Grade, 4);
            RequestValidator.ValidateMinValue("grade", this.Grade, -1);
            RequestValidator.ValidateMinValue("max_trade_count", this.MaxTradeCount, 0);
            RequestValidator.ValidateMinValue("min_trade_count", this.MinTradeCount, 0);
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
