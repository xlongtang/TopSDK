using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.dealer.requisitionorder.query
    /// </summary>
    public class FenxiaoDealerRequisitionorderQueryRequest : ITopRequest<FenxiaoDealerRequisitionorderQueryResponse>
    {
        /// <summary>
        /// 经销采购单编号。  多个编号用英文符号的逗号隔开。最多支持50个经销采购单编号的查询。
        /// </summary>
        public string DealerOrderIds { get; set; }

        /// <summary>
        /// 多个字段用","分隔。 fields 如果为空：返回所有经销采购单对象(dealer_orders)字段。 如果不为空：返回指定采购单对象(dealer_orders)字段。 例1： dealer_order_details.product_id 表示只返回product_id 例2： dealer_order_details 表示只返回明细列表
        /// </summary>
        public string Fields { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.dealer.requisitionorder.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dealer_order_ids", this.DealerOrderIds);
            parameters.Add("fields", this.Fields);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("dealer_order_ids", this.DealerOrderIds);
            RequestValidator.ValidateMaxListSize("dealer_order_ids", this.DealerOrderIds, 50);
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
