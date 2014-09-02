using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.distributor.procuct.static.get
    /// </summary>
    public class FenxiaoDistributorProcuctStaticGetRequest : ITopRequest<FenxiaoDistributorProcuctStaticGetResponse>
    {
        /// <summary>
        /// 分销商淘宝店主nick
        /// </summary>
        public string DistributorUserNick { get; set; }

        /// <summary>
        /// 供应商商品id，一次可以传多个，每次最多40个。  以,(英文)作为分隔符。
        /// </summary>
        public string ProductIdArray { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.distributor.procuct.static.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor_user_nick", this.DistributorUserNick);
            parameters.Add("product_id_array", this.ProductIdArray);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("distributor_user_nick", this.DistributorUserNick);
            RequestValidator.ValidateRequired("product_id_array", this.ProductIdArray);
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
