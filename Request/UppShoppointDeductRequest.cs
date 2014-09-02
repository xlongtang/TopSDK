using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.upp.shoppoint.deduct
    /// </summary>
    public class UppShoppointDeductRequest : ITopRequest<UppShoppointDeductResponse>
    {
        /// <summary>
        /// 处理的店铺积分数量
        /// </summary>
        public Nullable<long> PointNum { get; set; }

        /// <summary>
        /// 卖家NICK
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 用于实际扣减的时候关联系统发放记录，由预扣减接口返回<br /> 支持的最大列表长度为：32
        /// </summary>
        public Nullable<long> TransactionId { get; set; }

        /// <summary>
        /// 6:业务成功  4:业务失败<br /> 支持的最大列表长度为：1
        /// </summary>
        public Nullable<long> TransactionStatus { get; set; }

        /// <summary>
        /// 业务发生的时间
        /// </summary>
        public Nullable<DateTime> TransactionTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.upp.shoppoint.deduct";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("point_num", this.PointNum);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("transaction_id", this.TransactionId);
            parameters.Add("transaction_status", this.TransactionStatus);
            parameters.Add("transaction_time", this.TransactionTime);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("point_num", this.PointNum);
            RequestValidator.ValidateRequired("seller_nick", this.SellerNick);
            RequestValidator.ValidateRequired("transaction_id", this.TransactionId);
            RequestValidator.ValidateRequired("transaction_status", this.TransactionStatus);
            RequestValidator.ValidateRequired("transaction_time", this.TransactionTime);
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
