using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.cooperation.productcat.add
    /// </summary>
    public class FenxiaoCooperationProductcatAddRequest : ITopRequest<FenxiaoCooperationProductcatAddResponse>
    {
        /// <summary>
        /// 合作关系id
        /// </summary>
        public Nullable<long> CooperateId { get; set; }

        /// <summary>
        /// 等级ID（为空则不修改）
        /// </summary>
        public Nullable<long> GradeId { get; set; }

        /// <summary>
        /// 产品线id列表，若有多个，以逗号分隔
        /// </summary>
        public string ProductLineList { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.cooperation.productcat.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cooperate_id", this.CooperateId);
            parameters.Add("grade_id", this.GradeId);
            parameters.Add("product_line_list", this.ProductLineList);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cooperate_id", this.CooperateId);
            RequestValidator.ValidateRequired("product_line_list", this.ProductLineList);
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
