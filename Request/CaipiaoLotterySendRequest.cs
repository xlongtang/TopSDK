using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.caipiao.lottery.send
    /// </summary>
    public class CaipiaoLotterySendRequest : ITopRequest<CaipiaoLotterySendResponse>
    {
        /// <summary>
        /// 彩票接收方淘宝数字ID，不可为空、0和负数。
        /// </summary>
        public Nullable<long> BuyerNumId { get; set; }

        /// <summary>
        /// 彩种ID，此彩种ID为彩票系统中的序号。
        /// </summary>
        public Nullable<long> LotteryTypeId { get; set; }

        /// <summary>
        /// 送彩方淘宝数字ID， 不可为空、0和负数。
        /// </summary>
        public Nullable<long> SellerNumId { get; set; }

        /// <summary>
        /// 彩票注数，不可为空、0和负数，最大值为100。
        /// </summary>
        public Nullable<long> StakeCount { get; set; }

        /// <summary>
        /// 送彩票给接收方的赠言。 不能超过50个字符，1个中文字符、1个英文字母及1个数字等均当作一个字符，如果超过，则会截取。
        /// </summary>
        public string SweetyWords { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.caipiao.lottery.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_num_id", this.BuyerNumId);
            parameters.Add("lottery_type_id", this.LotteryTypeId);
            parameters.Add("seller_num_id", this.SellerNumId);
            parameters.Add("stake_count", this.StakeCount);
            parameters.Add("sweety_words", this.SweetyWords);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("buyer_num_id", this.BuyerNumId);
            RequestValidator.ValidateRequired("seller_num_id", this.SellerNumId);
            RequestValidator.ValidateRequired("stake_count", this.StakeCount);
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
