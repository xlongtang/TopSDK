using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.members.increment.get
    /// </summary>
    public class CrmMembersIncrementGetRequest : ITopRequest<CrmMembersIncrementGetResponse>
    {
        /// <summary>
        /// 显示第几页的会员，如果输入的页码大于总共的页码数，例如总共10页，但是current_page的值为11，则返回空白页，最小页数为1<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 卖家修改会员信息的时间终点.如果不填写此字段,默认为当前时间.
        /// </summary>
        public Nullable<DateTime> EndModify { get; set; }

        /// <summary>
        /// 会员等级，0：店铺客户，1：普通会员，2：高级会员，3：VIP会员， 4：至尊VIP会员<br /> 支持最大值为：4<br /> 支持最小值为：-1<br /> 支持的最大列表长度为：32
        /// </summary>
        public Nullable<long> Grade { get; set; }

        /// <summary>
        /// 每页显示的会员数，page_size的值不能超过100，最小值要大于1<br /> 支持最大值为：100<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 卖家修改会员信息的时间起点.
        /// </summary>
        public Nullable<DateTime> StartModify { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.members.increment.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("end_modify", this.EndModify);
            parameters.Add("grade", this.Grade);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_modify", this.StartModify);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
            RequestValidator.ValidateMinValue("current_page", this.CurrentPage, 1);
            RequestValidator.ValidateMaxValue("grade", this.Grade, 4);
            RequestValidator.ValidateMinValue("grade", this.Grade, -1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
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
