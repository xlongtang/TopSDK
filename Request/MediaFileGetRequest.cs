using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.media.file.get
    /// </summary>
    public class MediaFileGetRequest : ITopRequest<MediaFileGetResponse>
    {
        /// <summary>
        /// 多媒体应用接入biz_code
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 分类id<br /> 支持最大值为：9223372036854775807
        /// </summary>
        public Nullable<long> DirId { get; set; }

        /// <summary>
        /// 查询上传结束时间点,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// 文件id<br /> 支持最大值为：9223372036854775807
        /// </summary>
        public Nullable<long> FileId { get; set; }

        /// <summary>
        /// 文件名称查询，like查询
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 图片查询结果排序,time:desc按上传时间从晚到早(默认), time:asc按上传时间从早到晚,sizes:desc按图片从大到小，sizes:asc按图片从小到大,默认time:desc
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 页码.传入值为1代表第一页,传入值为2代表第二页,依此类推,默认值为1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数.每页返回最多返回100条,默认值40
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询上传开始时间点,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        /// <summary>
        /// 图片url查询接口
        /// </summary>
        public string Urls { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.media.file.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("dir_id", this.DirId);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("file_id", this.FileId);
            parameters.Add("name", this.Name);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("urls", this.Urls);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateMaxValue("dir_id", this.DirId, 9223372036854775807);
            RequestValidator.ValidateMaxValue("file_id", this.FileId, 9223372036854775807);
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
