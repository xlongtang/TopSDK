using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.catsbase.get
    /// </summary>
    public class SimbaInsightCatsbaseGetRequest : ITopRequest<SimbaInsightCatsbaseGetResponse>
    {
        /// <summary>
        /// 查询类目id数组，最大长度200
        /// </summary>
        public string CategoryIds { get; set; }

        /// <summary>
        /// 结果过滤。PV：返回展现量；CLICK：返回点击量；AVGCPC：返回平均出价；COMPETITION ：返回竞争宝贝数;CTR 点击率。filter可由,组合
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 时间格式(DAY: 最近一天； WEEK：最近一周。MONTH：最近一个月。3MONTH：最近三个月)
        /// </summary>
        public string Time { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.catsbase.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_ids", this.CategoryIds);
            parameters.Add("filter", this.Filter);
            parameters.Add("nick", this.Nick);
            parameters.Add("time", this.Time);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("category_ids", this.CategoryIds);
            RequestValidator.ValidateMaxListSize("category_ids", this.CategoryIds, 200);
            RequestValidator.ValidateRequired("filter", this.Filter);
            RequestValidator.ValidateRequired("time", this.Time);
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
