using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.eai.order.refund.refuse
    /// </summary>
    public class TmallEaiOrderRefundRefuseRequest : ITopUploadRequest<TmallEaiOrderRefundRefuseResponse>
    {
        /// <summary>
        /// 退款单编号
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        /// <summary>
        /// 售中：onsale  售后：aftersale
        /// </summary>
        public string RefundPhase { get; set; }

        /// <summary>
        /// 退款版本号
        /// </summary>
        public Nullable<long> RefundVersion { get; set; }

        /// <summary>
        /// 拒绝退款原因留言
        /// </summary>
        public string RefuseMessage { get; set; }

        /// <summary>
        /// 拒绝退款举证上传
        /// </summary>
        public FileItem RefuseProof { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.eai.order.refund.refuse";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("refund_id", this.RefundId);
            parameters.Add("refund_phase", this.RefundPhase);
            parameters.Add("refund_version", this.RefundVersion);
            parameters.Add("refuse_message", this.RefuseMessage);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
            RequestValidator.ValidateRequired("refund_phase", this.RefundPhase);
            RequestValidator.ValidateRequired("refund_version", this.RefundVersion);
            RequestValidator.ValidateRequired("refuse_message", this.RefuseMessage);
            RequestValidator.ValidateRequired("refuse_proof", this.RefuseProof);
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
