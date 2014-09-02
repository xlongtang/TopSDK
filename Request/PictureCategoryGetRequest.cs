using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.picture.category.get
    /// </summary>
    public class PictureCategoryGetRequest : ITopRequest<PictureCategoryGetResponse>
    {
        /// <summary>
        /// 图片分类的修改时间点，格式:yyyy-MM-dd HH:mm:ss。查询此修改时间点之后到目前的图片分类。
        /// </summary>
        public Nullable<DateTime> ModifiedTime { get; set; }

        /// <summary>
        /// 取二级分类时设置为对应父分类id  取一级分类时父分类id设为0  取全部分类的时候不设或设为-1
        /// </summary>
        public Nullable<long> ParentId { get; set; }

        /// <summary>
        /// 图片分类ID
        /// </summary>
        public Nullable<long> PictureCategoryId { get; set; }

        /// <summary>
        /// 图片分类名，不支持模糊查询
        /// </summary>
        public string PictureCategoryName { get; set; }

        /// <summary>
        /// 分类类型,fixed代表店铺装修分类类别，auction代表宝贝分类类别，user-define代表用户自定义分类类别
        /// </summary>
        public string Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.picture.category.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("modified_time", this.ModifiedTime);
            parameters.Add("parent_id", this.ParentId);
            parameters.Add("picture_category_id", this.PictureCategoryId);
            parameters.Add("picture_category_name", this.PictureCategoryName);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
