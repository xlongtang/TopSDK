using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.grade.update
    /// </summary>
    public class FenxiaoGradeUpdateRequest : ITopRequest<FenxiaoGradeUpdateResponse>
    {
        /// <summary>
        /// 等级ID
        /// </summary>
        public Nullable<long> GradeId { get; set; }

        /// <summary>
        /// 等级名称，等级名称不可重复<br /> 支持最大长度为：20<br /> 支持的最大列表长度为：20
        /// </summary>
        public string Name { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.grade.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("grade_id", this.GradeId);
            parameters.Add("name", this.Name);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("grade_id", this.GradeId);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 20);
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
