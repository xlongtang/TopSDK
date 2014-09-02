using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.rpt.adgroupnonsearcheffect.get
    /// </summary>
    public class SimbaRptAdgroupnonsearcheffectGetRequest : ITopRequest<SimbaRptAdgroupnonsearcheffectGetResponse>
    {
        /// <summary>
        /// 推广组id
        /// </summary>
        public Nullable<long> AdgroupId { get; set; }

        /// <summary>
        /// 推广计划id
        /// </summary>
        public Nullable<long> CampaignId { get; set; }

        /// <summary>
        /// 结束时间,格式为：yyyy-mm-dd
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 开始时间,格式为：yyyy-mm-dd
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 权限校验参数
        /// </summary>
        public string SubwayToken { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.rpt.adgroupnonsearcheffect.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adgroup_id", this.AdgroupId);
            parameters.Add("campaign_id", this.CampaignId);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("nick", this.Nick);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("subway_token", this.SubwayToken);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
            RequestValidator.ValidateRequired("subway_token", this.SubwayToken);
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
