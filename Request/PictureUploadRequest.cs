using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.upload
    /// </summary>
    public class PictureUploadRequest : ITopUploadRequest<PictureUploadResponse>
    {
        /// <summary>
        /// 包括后缀名的图片标题,不能为空，如Bule.jpg,有些卖家希望图片上传后取图片文件的默认名
        /// </summary>
        public string ImageInputTitle { get; set; }

        /// <summary>
        /// 图片二进制文件流,不能为空,允许png、jpg、gif图片格式,2M以内。
        /// </summary>
        public FileItem Img { get; set; }

        /// <summary>
        /// 图片分类ID，设置具体某个分类ID或设置0上传到默认分类，只能传入一个分类
        /// </summary>
        public Nullable<long> PictureCategoryId { get; set; }

        /// <summary>
        /// 图片标题,如果为空,传的图片标题就取去掉后缀名的image_input_title,超过50字符长度会截取50字符,重名会在标题末尾加"(1)";标题末尾已经有"(数字)"了，则数字加1
        /// </summary>
        public string Title { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("image_input_title", this.ImageInputTitle);
            parameters.Add("picture_category_id", this.PictureCategoryId);
            parameters.Add("title", this.Title);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("image_input_title", this.ImageInputTitle);
            RequestValidator.ValidateRequired("img", this.Img);
            RequestValidator.ValidateRequired("picture_category_id", this.PictureCategoryId);
            RequestValidator.ValidateMaxValue("picture_category_id", this.PictureCategoryId, 9223372036854775807);
            RequestValidator.ValidateMinValue("picture_category_id", this.PictureCategoryId, 0);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("img", this.Img);
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
