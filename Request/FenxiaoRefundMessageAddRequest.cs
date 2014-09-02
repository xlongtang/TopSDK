using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.refund.message.add
    /// </summary>
    public class FenxiaoRefundMessageAddRequest : ITopUploadRequest<FenxiaoRefundMessageAddResponse>
    {
        /// <summary>
        /// 留言凭证
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 留言内容
        /// </summary>
        public string MessageContent { get; set; }

        /// <summary>
        /// 发生退款的子采购单id
        /// </summary>
        public Nullable<long> SubOrderId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.refund.message.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("message_content", this.MessageContent);
            parameters.Add("sub_order_id", this.SubOrderId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("message_content", this.MessageContent);
            RequestValidator.ValidateRequired("sub_order_id", this.SubOrderId);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image", this.Image);
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
