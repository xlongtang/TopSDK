using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.eai.order.refund.good.return.mget
    /// </summary>
    public class TmallEaiOrderRefundGoodReturnMgetRequest : ITopRequest<TmallEaiOrderRefundGoodReturnMgetResponse>
    {
        /// <summary>
        /// 批量查询结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零的整数; 默认值:1<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数。取值范围:大于零的整数; 默认值:10;最大值:40<br /> 支持最大值为：40<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 批量查询开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 退货单 退款单状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 是否启用has_next的分页方式，如果指定true,则返回的结果中不包含总记录数，但是会新增一个是否存在下一页的的字段，通过此种方式获取增量退款，接口调用成功率在原有的基础上有所提升。
        /// </summary>
        public Nullable<bool> UseHasNext { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.eai.order.refund.good.return.mget";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("status", this.Status);
            parameters.Add("use_has_next", this.UseHasNext);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 40);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
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
