using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.uic.weiboprofile.update
    /// </summary>
    public class UicWeiboprofileUpdateRequest : ITopRequest<UicWeiboprofileUpdateResponse>
    {
        /// <summary>
        /// 以map结构批量返回微博用户变更的属性。key:为新浪微博用户id,value:为该用户发生Profile变更的属性名，多个属性之间用逗号分隔，该接口一次最大接收条数不能超过100条。
        /// </summary>
        public string Map { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.uic.weiboprofile.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("map", this.Map);
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
