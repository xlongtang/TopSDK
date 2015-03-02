using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.dealer.requisitionorder.create
    /// </summary>
    public class FenxiaoDealerRequisitionorderCreateRequest : ITopRequest<FenxiaoDealerRequisitionorderCreateResponse>
    {
        /// <summary>
        /// 收货人所在街道地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 买家姓名（自提方式填写提货人姓名）
        /// </summary>
        public string BuyerName { get; set; }

        /// <summary>
        /// 收货人所在市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 收货人所在区
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// 身份证号（自提方式必填，填写提货人身份证号码，提货时用于确认提货人身份）
        /// </summary>
        public string IdCardNumber { get; set; }

        /// <summary>
        /// 配送方式。SELF_PICKUP：自提；LOGISTICS：仓库发货
        /// </summary>
        public string LogisticsType { get; set; }

        /// <summary>
        /// 买家的手机号码（1、此字段与phone字段至少填写一个。2、自提方式下此字段必填，保存提货人联系电话）
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 采购清单，存放多个采购明细，每个采购明细内部以‘:’隔开，多个采购明细之间以‘,’隔开. 例(分销产品id:skuid:购买数量:申请单价,分销产品id:skuid:购买数量:申请单价)，申请单价的单位为分。不存在sku请留空skuid，如（分销产品id::购买数量:申请单价）
        /// </summary>
        public string OrderDetail { get; set; }

        /// <summary>
        /// 买家联系电话（此字段和mobile字段至少填写一个）
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 收货人所在地区邮政编码
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// 收货人所在省份
        /// </summary>
        public string Province { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.dealer.requisitionorder.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("address", this.Address);
            parameters.Add("buyer_name", this.BuyerName);
            parameters.Add("city", this.City);
            parameters.Add("district", this.District);
            parameters.Add("id_card_number", this.IdCardNumber);
            parameters.Add("logistics_type", this.LogisticsType);
            parameters.Add("mobile", this.Mobile);
            parameters.Add("order_detail", this.OrderDetail);
            parameters.Add("phone", this.Phone);
            parameters.Add("post_code", this.PostCode);
            parameters.Add("province", this.Province);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("address", this.Address);
            RequestValidator.ValidateRequired("buyer_name", this.BuyerName);
            RequestValidator.ValidateRequired("logistics_type", this.LogisticsType);
            RequestValidator.ValidateRequired("order_detail", this.OrderDetail);
            RequestValidator.ValidateMaxListSize("order_detail", this.OrderDetail, 50);
            RequestValidator.ValidateRequired("province", this.Province);
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
