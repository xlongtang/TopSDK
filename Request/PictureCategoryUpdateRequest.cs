using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.category.update
    /// </summary>
    public class PictureCategoryUpdateRequest : ITopRequest<PictureCategoryUpdateResponse>
    {
        /// <summary>
        /// 要更新的图片分类的id
        /// </summary>
        public Nullable<long> CategoryId { get; set; }

        /// <summary>
        /// 图片分类的新名字，最大长度20字符，不能为空
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 图片分类的新父分类id
        /// </summary>
        public Nullable<long> ParentId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.category.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_id", this.CategoryId);
            parameters.Add("category_name", this.CategoryName);
            parameters.Add("parent_id", this.ParentId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("category_id", this.CategoryId);
            RequestValidator.ValidateMaxLength("category_name", this.CategoryName, 20);
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
