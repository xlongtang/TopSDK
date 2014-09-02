using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.catsanalysis.get
    /// </summary>
    public class SimbaInsightCatsanalysisGetRequest : ITopRequest<SimbaInsightCatsanalysisGetResponse>
    {
        /// <summary>
        /// 查询类目id数组，最大长度200
        /// </summary>
        public string CategoryIds { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 结果过滤。  AREA：返回地域占比；  SOURCE：返回来源占比；  HPRICE：返回竞价分布。  stu只能是AREA、SOURCE或HPRICE中的一个
        /// </summary>
        public string Stu { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.catsanalysis.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_ids", this.CategoryIds);
            parameters.Add("nick", this.Nick);
            parameters.Add("stu", this.Stu);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("category_ids", this.CategoryIds);
            RequestValidator.ValidateMaxListSize("category_ids", this.CategoryIds, 200);
            RequestValidator.ValidateRequired("stu", this.Stu);
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
