using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.caipiao.lottery.sendbynick
    /// </summary>
    public class CaipiaoLotterySendbynickRequest : ITopRequest<CaipiaoLotterySendbynickResponse>
    {
        /// <summary>
        /// 彩票接收方nick， 不可为空、""。
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 彩种ID，此彩种ID为彩票系统中的序号。
        /// </summary>
        public Nullable<long> LotteryTypeId { get; set; }

        /// <summary>
        /// 彩票注数，不可为空、0和负数，最大值为100。
        /// </summary>
        public Nullable<long> StakeCount { get; set; }

        /// <summary>
        /// 送彩票给接收方的赠言。 不能超过20个字符，1个中文字符、1个英文字母及1个数字等均当作一个字符，如果超过，则会截取。
        /// </summary>
        public string SweetyWords { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.caipiao.lottery.sendbynick";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("lottery_type_id", this.LotteryTypeId);
            parameters.Add("stake_count", this.StakeCount);
            parameters.Add("sweety_words", this.SweetyWords);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("buyer_nick", this.BuyerNick);
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
