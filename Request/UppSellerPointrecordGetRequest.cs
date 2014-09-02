using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.upp.seller.pointrecord.get
    /// </summary>
    public class UppSellerPointrecordGetRequest : ITopRequest<UppSellerPointrecordGetResponse>
    {
        /// <summary>
        /// 查询的页数
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 每页记录数，最大30条，默认20<br /> 支持最大值为：30<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 记录状态 1成功 0冻结  -1失败
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// upp内部业务ID，由预扣或预发积分接口返回，ISV可以直接使用，或映射自己的业务ID。<br /> 支持的最大列表长度为：32
        /// </summary>
        public Nullable<long> TransactionId { get; set; }

        /// <summary>
        /// 业务发生的开始时间
        /// </summary>
        public Nullable<DateTime> TransactionTimeBegin { get; set; }

        /// <summary>
        /// 业务发生的结束时间
        /// </summary>
        public Nullable<DateTime> TransactionTimeEnd { get; set; }

        /// <summary>
        /// 卖家积分活动的类型  3：发送积分  4：扣减积分<br /> 支持的最大列表长度为：1
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.upp.seller.pointrecord.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("status", this.Status);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("transaction_time_begin", this.TransactionTimeBegin);
            parameters.Add("transaction_time_end", this.TransactionTimeEnd);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 30);
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
