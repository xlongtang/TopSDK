using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.category.add
    /// </summary>
    public class PictureCategoryAddRequest : ITopRequest<PictureCategoryAddResponse>
    {
        /// <summary>
        /// 图片分类的父分类,一级分类的parent_id为0,二级分类的则为其父分类的picture_category_id
        /// </summary>
        public Nullable<long> ParentId { get; set; }

        /// <summary>
        /// 图片分类名称，最大长度20字符，中英文都算一字符，不能为空
        /// </summary>
        public string PictureCategoryName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.category.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("parent_id", this.ParentId);
            parameters.Add("picture_category_name", this.PictureCategoryName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("picture_category_name", this.PictureCategoryName);
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
