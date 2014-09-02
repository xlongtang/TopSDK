using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.refund.message.add
    /// </summary>
    public class RefundMessageAddRequest : ITopUploadRequest<RefundMessageAddResponse>
    {
        /// <summary>
        /// 留言内容。最大长度: 400个字节
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 图片（凭证）。类型: JPG,GIF,PNG;最大为: 500K
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 退款编号。
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.refund.message.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("content", this.Content);
            parameters.Add("refund_id", this.RefundId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", this.Content);
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
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
