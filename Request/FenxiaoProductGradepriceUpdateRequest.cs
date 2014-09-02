using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.gradeprice.update
    /// </summary>
    public class FenxiaoProductGradepriceUpdateRequest : ITopRequest<FenxiaoProductGradepriceUpdateResponse>
    {
        /// <summary>
        /// 会员等级的id或者分销商id，例如：”1001,2001,1002”
        /// </summary>
        public string Ids { get; set; }

        /// <summary>
        /// 优惠价格,大小为0到100000000之间的整数或两位小数，例：优惠价格为：100元2角5分，传入的参数应写成：100.25
        /// </summary>
        public string Prices { get; set; }

        /// <summary>
        /// 产品Id
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// skuId，如果产品有skuId,必须要输入skuId;没有skuId的时候不必选
        /// </summary>
        public Nullable<long> SkuId { get; set; }

        /// <summary>
        /// 选择折扣方式：GRADE（按等级进行设置）;DISCITUTOR(按分销商进行设置）。例如"GRADE,DISTRIBUTOR"
        /// </summary>
        public string TargetType { get; set; }

        /// <summary>
        /// 交易类型： AGENT(代销)、DEALER(经销)，ALL(代销和经销)
        /// </summary>
        public string TradeType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.product.gradeprice.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ids", this.Ids);
            parameters.Add("prices", this.Prices);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sku_id", this.SkuId);
            parameters.Add("target_type", this.TargetType);
            parameters.Add("trade_type", this.TradeType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ids", this.Ids);
            RequestValidator.ValidateMaxListSize("ids", this.Ids, 200);
            RequestValidator.ValidateRequired("prices", this.Prices);
            RequestValidator.ValidateMaxListSize("prices", this.Prices, 200);
            RequestValidator.ValidateRequired("product_id", this.ProductId);
            RequestValidator.ValidateRequired("target_type", this.TargetType);
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
