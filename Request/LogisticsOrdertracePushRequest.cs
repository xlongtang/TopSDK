using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.ordertrace.push
    /// </summary>
    public class LogisticsOrdertracePushRequest : ITopRequest<LogisticsOrdertracePushResponse>
    {
        /// <summary>
        /// 物流公司名称
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 流转节点的当前城市
        /// </summary>
        public string CurrentCity { get; set; }

        /// <summary>
        /// 网点名称
        /// </summary>
        public string FacilityName { get; set; }

        /// <summary>
        /// 快递单号。各个快递公司的运单号格式不同。
        /// </summary>
        public string MailNo { get; set; }

        /// <summary>
        /// 流转节点的下一个城市
        /// </summary>
        public string NextCity { get; set; }

        /// <summary>
        /// 描述当前节点的操作，操作是“揽收”、“派送”或“签收”。
        /// </summary>
        public string NodeDescription { get; set; }

        /// <summary>
        /// 流转节点发生时间
        /// </summary>
        public Nullable<DateTime> OccureTime { get; set; }

        /// <summary>
        /// 流转节点的详细地址及操作描述
        /// </summary>
        public string OperateDetail { get; set; }

        /// <summary>
        /// 快递业务员联系方式，手机号码或电话。
        /// </summary>
        public string OperatorContact { get; set; }

        /// <summary>
        /// 快递业务员名称
        /// </summary>
        public string OperatorName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.ordertrace.push";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("company_name", this.CompanyName);
            parameters.Add("current_city", this.CurrentCity);
            parameters.Add("facility_name", this.FacilityName);
            parameters.Add("mail_no", this.MailNo);
            parameters.Add("next_city", this.NextCity);
            parameters.Add("node_description", this.NodeDescription);
            parameters.Add("occure_time", this.OccureTime);
            parameters.Add("operate_detail", this.OperateDetail);
            parameters.Add("operator_contact", this.OperatorContact);
            parameters.Add("operator_name", this.OperatorName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("company_name", this.CompanyName);
            RequestValidator.ValidateMaxLength("company_name", this.CompanyName, 20);
            RequestValidator.ValidateMaxLength("current_city", this.CurrentCity, 20);
            RequestValidator.ValidateMaxLength("facility_name", this.FacilityName, 100);
            RequestValidator.ValidateRequired("mail_no", this.MailNo);
            RequestValidator.ValidateMaxLength("next_city", this.NextCity, 20);
            RequestValidator.ValidateMaxLength("node_description", this.NodeDescription, 20);
            RequestValidator.ValidateRequired("occure_time", this.OccureTime);
            RequestValidator.ValidateRequired("operate_detail", this.OperateDetail);
            RequestValidator.ValidateMaxLength("operate_detail", this.OperateDetail, 200);
            RequestValidator.ValidateMaxLength("operator_contact", this.OperatorContact, 20);
            RequestValidator.ValidateMaxLength("operator_name", this.OperatorName, 20);
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
