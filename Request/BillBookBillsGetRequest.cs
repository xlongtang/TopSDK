using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.bill.book.bills.get
    /// </summary>
    public class BillBookBillsGetRequest : ITopRequest<BillBookBillsGetResponse>
    {
        /// <summary>
        /// 虚拟账户科目编号
        /// </summary>
        public Nullable<long> AccountId { get; set; }

        /// <summary>
        /// 记账结束时间,end_time与start_time相差不能超过30天
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 需要返回的字段:bid,account_id,journal_type,amount,book_time,description,gmt_create,gmt_modified ,如果不是以上字段将自动忽略
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 明细流水类型:流水类型:101、可用金充值；102、可用金扣除；103、冻结；104、解冻；105、冻结金充值；106、冻结金扣除
        /// </summary>
        public string JournalTypes { get; set; }

        /// <summary>
        /// 页码,传入值为1代表第一页,传入值为2代表第二页,依此类推.默认返回的数据是从第一页开始
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页大小,建议40~100,不能超过100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 记账开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.bill.book.bills.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("account_id", this.AccountId);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("journal_types", this.JournalTypes);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_time", this.StartTime);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("account_id", this.AccountId);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxLength("fields", this.Fields, 300);
            RequestValidator.ValidateMaxListSize("journal_types", this.JournalTypes, 10);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
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
