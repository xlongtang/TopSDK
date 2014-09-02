using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.orderstore.push
    /// </summary>
    public class LogisticsOrderstorePushRequest : ITopRequest<LogisticsOrderstorePushResponse>
    {
        /// <summary>
        /// 表明是否是拆单，默认值0，1表示拆单
        /// </summary>
        public Nullable<long> IsSplit { get; set; }

        /// <summary>
        /// 流转状态发生时间
        /// </summary>
        public Nullable<DateTime> OccureTime { get; set; }

        /// <summary>
        /// 仓内操作描述
        /// </summary>
        public string OperateDetail { get; set; }

        /// <summary>
        /// 快递业务员联系方式
        /// </summary>
        public string OperatorContact { get; set; }

        /// <summary>
        /// 快递业务员名称
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// 拆单子订单列表，对应的数据是：子订单号的列表。可以不传，但是如果传了则必须符合传递的规则。子订单必须是操作的物流订单的子订单的真子集！
        /// </summary>
        public string SubTid { get; set; }

        /// <summary>
        /// 淘宝订单交易号
        /// </summary>
        public Nullable<long> TradeId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.orderstore.push";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_split", this.IsSplit);
            parameters.Add("occure_time", this.OccureTime);
            parameters.Add("operate_detail", this.OperateDetail);
            parameters.Add("operator_contact", this.OperatorContact);
            parameters.Add("operator_name", this.OperatorName);
            parameters.Add("sub_tid", this.SubTid);
            parameters.Add("trade_id", this.TradeId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("occure_time", this.OccureTime);
            RequestValidator.ValidateRequired("operate_detail", this.OperateDetail);
            RequestValidator.ValidateMaxLength("operate_detail", this.OperateDetail, 200);
            RequestValidator.ValidateMaxLength("operator_contact", this.OperatorContact, 20);
            RequestValidator.ValidateMaxLength("operator_name", this.OperatorName, 20);
            RequestValidator.ValidateMaxListSize("sub_tid", this.SubTid, 50);
            RequestValidator.ValidateRequired("trade_id", this.TradeId);
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
