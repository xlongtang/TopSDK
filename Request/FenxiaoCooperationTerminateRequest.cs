using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.cooperation.terminate
    /// </summary>
    public class FenxiaoCooperationTerminateRequest : ITopRequest<FenxiaoCooperationTerminateResponse>
    {
        /// <summary>
        /// 合作编号
        /// </summary>
        public Nullable<long> CooperateId { get; set; }

        /// <summary>
        /// 终止天数，可选1,2,3,5,7,15，在多少天数内终止
        /// </summary>
        public Nullable<long> EndRemainDays { get; set; }

        /// <summary>
        /// 终止说明（5-2000字）
        /// </summary>
        public string EndRemark { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.cooperation.terminate";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cooperate_id", this.CooperateId);
            parameters.Add("end_remain_days", this.EndRemainDays);
            parameters.Add("end_remark", this.EndRemark);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cooperate_id", this.CooperateId);
            RequestValidator.ValidateRequired("end_remain_days", this.EndRemainDays);
            RequestValidator.ValidateRequired("end_remark", this.EndRemark);
            RequestValidator.ValidateMaxLength("end_remark", this.EndRemark, 2000);
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
