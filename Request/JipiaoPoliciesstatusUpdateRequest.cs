using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jipiao.policiesstatus.update
    /// </summary>
    public class JipiaoPoliciesstatusUpdateRequest : ITopRequest<JipiaoPoliciesstatusUpdateResponse>
    {
        /// <summary>
        /// 航空公司二字码
        /// </summary>
        public string Airline { get; set; }

        /// <summary>
        /// 到达机场三字码,此项必需与出发机场同时为空或不为空
        /// </summary>
        public string ArrAirport { get; set; }

        /// <summary>
        /// 出发机场三字码,此项必需与到达机场同时为空或不为空
        /// </summary>
        public string DepAirport { get; set; }

        /// <summary>
        /// 外部产品id集,最多支持1000个,后续调大,其中的out_product_id含有空格将不会处理
        /// </summary>
        public string OutProductIds { get; set; }

        /// <summary>
        /// 产品id集,最多支持1000个，后续调大，其中单个的policy_id含有留空格或不是数字将会忽略不处理
        /// </summary>
        public string PolicyIds { get; set; }

        /// <summary>
        /// 发布日期
        /// </summary>
        public string PublishDate { get; set; }

        /// <summary>
        /// 发布来源, 通过接口taobao.jipiao.policy.process添加的政策会自动加上source为TOP,代理商后台页面录入的source为PC,excel上传的source为UPLOAD,通过接口taobao.jipiao.policies.fulladd,taobao.jipiao.policies.add的自定义source也可以
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 0：按policy_ids更新；1：按out_product_ids更新；2:按其它条件更新
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jipiao.policiesstatus.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("airline", this.Airline);
            parameters.Add("arr_airport", this.ArrAirport);
            parameters.Add("dep_airport", this.DepAirport);
            parameters.Add("out_product_ids", this.OutProductIds);
            parameters.Add("policy_ids", this.PolicyIds);
            parameters.Add("publish_date", this.PublishDate);
            parameters.Add("source", this.Source);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("airline", this.Airline, 5);
            RequestValidator.ValidateMaxLength("arr_airport", this.ArrAirport, 3);
            RequestValidator.ValidateMaxLength("dep_airport", this.DepAirport, 3);
            RequestValidator.ValidateMaxLength("source", this.Source, 20);
            RequestValidator.ValidateRequired("type", this.Type);
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
