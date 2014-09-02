using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.caipiao.present.win.items.get
    /// </summary>
    public class CaipiaoPresentWinItemsGetRequest : ITopRequest<CaipiaoPresentWinItemsGetResponse>
    {
        /// <summary>
        /// 查询日期，格式请严格遵守yyyy-MM-dd
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 查询个数，最大值为500.如果为空、0和负数，则取默认值500
        /// </summary>
        public Nullable<long> Num { get; set; }

        /// <summary>
        /// 查询页码，空，零，负的情况默认为1（注意每页数据量为50）
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 0：查询中奖订单，1：查询所有订单，默认为0，注意按列表数量查询只会查询中奖订单。
        /// </summary>
        public Nullable<long> SearchType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.caipiao.present.win.items.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("date", this.Date);
            parameters.Add("num", this.Num);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("search_type", this.SearchType);
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
