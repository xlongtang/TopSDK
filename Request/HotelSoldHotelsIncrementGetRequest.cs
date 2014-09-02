using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.sold.hotels.increment.get
    /// </summary>
    public class HotelSoldHotelsIncrementGetRequest : ITopRequest<HotelSoldHotelsIncrementGetResponse>
    {
        /// <summary>
        /// 【不推荐使用，现在总是返回从修改开始时间到目前为止的所有记录，与修改结束时间不再相关】查询修改结束时间，必须大于修改开始时间（修改时间跨度不能大于1天）。格式：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        public Nullable<DateTime> EndModified { get; set; }

        /// <summary>
        /// 分页页码。取值范围，大于零的整数，默认值1，即返回第一页的数据
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 页面大小，取值范围1-100，默认大小20
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询修改开始时间（修改时间跨度不能大于1天）。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public Nullable<DateTime> StartModified { get; set; }

        /// <summary>
        /// 【不推荐使用，现在返回结果总会包含总记录数和是否存在下一页】是否使用has_next的分页方式，如果指定true，则返回的结果中不包含总记录数，但是会新增一个是否存在下一页的字段，效率比总记录数高
        /// </summary>
        public Nullable<bool> UseHasNext { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.sold.hotels.increment.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("use_has_next", this.UseHasNext);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("start_modified", this.StartModified);
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
