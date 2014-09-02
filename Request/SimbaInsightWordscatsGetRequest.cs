using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.wordscats.get
    /// </summary>
    public class SimbaInsightWordscatsGetRequest : ITopRequest<SimbaInsightWordscatsGetResponse>
    {
        /// <summary>
        /// 结果过滤。PV：返回展现量；CLICK：返回点击量；AVGCPC：返回平均出价；COMPETITION ：返回竞争宝贝数;CTR 点击率。filter可由,组合
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 查询词和类目数组，最大长度200，每一个数组元素都是词+类目，以”^^”分割如下：  词^^类目
        /// </summary>
        public string WordCategories { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.wordscats.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("filter", this.Filter);
            parameters.Add("nick", this.Nick);
            parameters.Add("word_categories", this.WordCategories);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("filter", this.Filter);
            RequestValidator.ValidateRequired("word_categories", this.WordCategories);
            RequestValidator.ValidateMaxListSize("word_categories", this.WordCategories, 200);
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
