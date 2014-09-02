using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ebookmedia.resource.add
    /// </summary>
    public class EbookmediaResourceAddRequest : ITopRequest<EbookmediaResourceAddResponse>
    {
        /// <summary>
        /// 电子书商品数字ID
        /// </summary>
        public Nullable<long> AuctionId { get; set; }

        /// <summary>
        /// 电子书文件云盘ID
        /// </summary>
        public Nullable<long> FileId { get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        public string StrFileId { get; set; }

        /// <summary>
        /// 资源文件后缀名
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// 资源类型，（1：正文，0：试读)
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ebookmedia.resource.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auction_id", this.AuctionId);
            parameters.Add("file_id", this.FileId);
            parameters.Add("str_file_id", this.StrFileId);
            parameters.Add("suffix", this.Suffix);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("auction_id", this.AuctionId);
            RequestValidator.ValidateRequired("suffix", this.Suffix);
            RequestValidator.ValidateRequired("type", this.Type);
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
