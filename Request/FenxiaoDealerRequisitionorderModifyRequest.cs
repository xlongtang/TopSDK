using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.dealer.requisitionorder.modify
    /// </summary>
    public class FenxiaoDealerRequisitionorderModifyRequest : ITopRequest<FenxiaoDealerRequisitionorderModifyResponse>
    {
        /// <summary>
        /// 经销采购单编号
        /// </summary>
        public Nullable<long> DealerOrderId { get; set; }

        /// <summary>
        /// 要删除的商品明细id列表，多个id使用英文符号的逗号隔开
        /// </summary>
        public string DeleteDetailIds { get; set; }

        /// <summary>
        /// 经销采购单的商品明细的新的采购价格。格式为商品明细id:价格修改值,商品明细id:价格修改值
        /// </summary>
        public string DetailIdPrices { get; set; }

        /// <summary>
        /// 修改经销采购单的商品明细的新的库存。格式为商品明细id:库存修改值,商品明细id:库存修改值
        /// </summary>
        public string DetailIdQuantities { get; set; }

        /// <summary>
        /// 新邮费（单位：分，示例值1005表示10.05元）。必须大于等于0。自提方式不可修改邮费。不提交该参数表示不修改邮费。
        /// </summary>
        public Nullable<long> NewPostFee { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.dealer.requisitionorder.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dealer_order_id", this.DealerOrderId);
            parameters.Add("delete_detail_ids", this.DeleteDetailIds);
            parameters.Add("detail_id_prices", this.DetailIdPrices);
            parameters.Add("detail_id_quantities", this.DetailIdQuantities);
            parameters.Add("new_post_fee", this.NewPostFee);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("dealer_order_id", this.DealerOrderId);
            RequestValidator.ValidateMaxListSize("delete_detail_ids", this.DeleteDetailIds, 50);
            RequestValidator.ValidateMaxListSize("detail_id_prices", this.DetailIdPrices, 50);
            RequestValidator.ValidateMaxListSize("detail_id_quantities", this.DetailIdQuantities, 50);
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
