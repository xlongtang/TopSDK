using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refund.refuse
    /// </summary>
    public class RefundRefuseRequest : ITopUploadRequest<RefundRefuseResponse>
    {
        /// <summary>
        /// 退款记录对应的交易子订单号
        /// </summary>
        public Nullable<long> Oid { get; set; }

        /// <summary>
        /// 退款单号
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        /// <summary>
        /// 拒绝退款时的说明信息，长度2-200
        /// </summary>
        public string RefuseMessage { get; set; }

        /// <summary>
        /// 拒绝退款时的退款凭证，一般是卖家拒绝退款时使用的发货凭证，最大长度130000字节，支持的图片格式：GIF, JPG, PNG
        /// </summary>
        public FileItem RefuseProof { get; set; }

        /// <summary>
        /// 退款记录对应的交易订单号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refund.refuse";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("oid", this.Oid);
            parameters.Add("refund_id", this.RefundId);
            parameters.Add("refuse_message", this.RefuseMessage);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
            RequestValidator.ValidateRequired("refuse_message", this.RefuseMessage);
            RequestValidator.ValidateMaxLength("refuse_message", this.RefuseMessage, 200);
            RequestValidator.ValidateMaxLength("refuse_proof", this.RefuseProof, 130000);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("refuse_proof", this.RefuseProof);
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
