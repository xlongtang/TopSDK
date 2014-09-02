using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.crm.equity.set
    /// </summary>
    public class TmallCrmEquitySetRequest : ITopRequest<TmallCrmEquitySetResponse>
    {
        /// <summary>
        /// 不免邮区域，只在包邮条件设置的时候生效。要和等级一一对应。包邮条件为false的时候不起作用。
        /// </summary>
        public string ExcludeArea { get; set; }

        /// <summary>
        /// 会员等级，用逗号分隔。买家会员级别0：店铺客户 1：普通会员 2 ：高级会员 3：VIP会员 4：至尊VIP
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// 返几倍天猫积分，可以不设置。如果设置则要和等级一一对应。不设置代表清空。
        /// </summary>
        public string Point { get; set; }

        /// <summary>
        /// 是否包邮，可以不设置，如果设置则要和等级一一对应。不设置代表清空
        /// </summary>
        public string Postage { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.crm.equity.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("exclude_area", this.ExcludeArea);
            parameters.Add("grade", this.Grade);
            parameters.Add("point", this.Point);
            parameters.Add("postage", this.Postage);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("exclude_area", this.ExcludeArea, 4);
            RequestValidator.ValidateRequired("grade", this.Grade);
            RequestValidator.ValidateMaxListSize("grade", this.Grade, 4);
            RequestValidator.ValidateMaxListSize("point", this.Point, 4);
            RequestValidator.ValidateMaxListSize("postage", this.Postage, 4);
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
