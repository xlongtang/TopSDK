using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ebook.file.upload.chunk
    /// </summary>
    public class EbookFileUploadChunkRequest : ITopUploadRequest<EbookFileUploadChunkResponse>
    {
        /// <summary>
        /// 文件块总数
        /// </summary>
        public Nullable<long> ChunkCount { get; set; }

        /// <summary>
        /// 传输文件块，除最后一块外每块的大小 必须为 4MB
        /// </summary>
        public FileItem ChunkData { get; set; }

        /// <summary>
        /// 文件块的MD5
        /// </summary>
        public string ChunkMd5 { get; set; }

        /// <summary>
        /// 文件的ID，上传第一个文件块生成放回，在上传后续文件块时此参数必选
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小（非文件块大小）
        /// </summary>
        public Nullable<long> FileSize { get; set; }

        /// <summary>
        /// 文件块序号
        /// </summary>
        public Nullable<long> Sequence { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ebook.file.upload.chunk";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chunk_count", this.ChunkCount);
            parameters.Add("chunk_md5", this.ChunkMd5);
            parameters.Add("file_id", this.FileId);
            parameters.Add("file_name", this.FileName);
            parameters.Add("file_size", this.FileSize);
            parameters.Add("sequence", this.Sequence);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("chunk_count", this.ChunkCount);
            RequestValidator.ValidateRequired("chunk_data", this.ChunkData);
            RequestValidator.ValidateRequired("chunk_md5", this.ChunkMd5);
            RequestValidator.ValidateRequired("file_name", this.FileName);
            RequestValidator.ValidateRequired("file_size", this.FileSize);
            RequestValidator.ValidateRequired("sequence", this.Sequence);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("chunk_data", this.ChunkData);
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
