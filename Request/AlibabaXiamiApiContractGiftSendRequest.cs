using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.xiami.api.contract.gift.send
    /// </summary>
    public class AlibabaXiamiApiContractGiftSendRequest : ITopRequest<AlibabaXiamiApiContractGiftSendResponse>
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 来源，可以传isv的应用名称，用来区分不同的isv
        /// </summary>
        public string Comefrom { get; set; }

        /// <summary>
        /// 关联订单ID，必须保证唯一，可以传时间戳或者isv赠送详情表的主键ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 关联信息ID，用来关联该礼包是isv的哪次赠送，建议传isv赠送详情表的主键ID
        /// </summary>
        public string RelationId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public Nullable<long> ShopId { get; set; }

        /// <summary>
        /// 礼包类型
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alibaba.xiami.api.contract.gift.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("comefrom", this.Comefrom);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("relation_id", this.RelationId);
            parameters.Add("shop_id", this.ShopId);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("buyer_nick", this.BuyerNick);
            RequestValidator.ValidateRequired("comefrom", this.Comefrom);
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("relation_id", this.RelationId);
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
            RequestValidator.ValidateRequired("type", this.Type);
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
