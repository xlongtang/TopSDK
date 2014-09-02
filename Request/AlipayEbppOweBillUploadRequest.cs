using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.ebpp.owe.bill.upload
    /// </summary>
    public class AlipayEbppOweBillUploadRequest : ITopUploadRequest<AlipayEbppOweBillUploadResponse>
    {
        /// <summary>
        /// 支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。<br /> 支持最大长度为：80<br /> 支持的最大列表长度为：80
        /// </summary>
        public string ChargeInst { get; set; }

        /// <summary>
        /// 销账机构<br /> 支持最大长度为：30<br /> 支持的最大列表长度为：30
        /// </summary>
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 文件摘要，算法SHA
        /// </summary>
        public string DigestOweBill { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK<br /> 支持最大长度为：10<br /> 支持的最大列表长度为：10
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 文件内容<br /> 支持的文件类型为：zip,rar,csv,doc,docx,xls,xlsx<br /> 支持的最大列表长度为：52428800
        /// </summary>
        public FileItem OweBill { get; set; }

        /// <summary>
        /// 子业务类型是业务类型的下一级概念，例如：WATER表示JF下面的水费，ELECTRIC表示JF下面的电费，GAS表示JF下面的燃气费。<br /> 支持最大长度为：10<br /> 支持的最大列表长度为：10
        /// </summary>
        public string SubOrderType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.ebpp.owe.bill.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("charge_inst", this.ChargeInst);
            parameters.Add("chargeoff_inst", this.ChargeoffInst);
            parameters.Add("digest_owe_bill", this.DigestOweBill);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("sub_order_type", this.SubOrderType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("charge_inst", this.ChargeInst);
            RequestValidator.ValidateMaxLength("charge_inst", this.ChargeInst, 80);
            RequestValidator.ValidateMaxLength("chargeoff_inst", this.ChargeoffInst, 30);
            RequestValidator.ValidateRequired("order_type", this.OrderType);
            RequestValidator.ValidateMaxLength("order_type", this.OrderType, 10);
            RequestValidator.ValidateRequired("owe_bill", this.OweBill);
            RequestValidator.ValidateMaxLength("owe_bill", this.OweBill, 52428800);
            RequestValidator.ValidateRequired("sub_order_type", this.SubOrderType);
            RequestValidator.ValidateMaxLength("sub_order_type", this.SubOrderType, 10);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("owe_bill", this.OweBill);
            return parameters;
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
