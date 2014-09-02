using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.subuser.employee.update
    /// </summary>
    public class SubuserEmployeeUpdateRequest : ITopRequest<SubuserEmployeeUpdateResponse>
    {
        /// <summary>
        /// 当前员工所属部门ID
        /// </summary>
        public Nullable<long> DepartmentId { get; set; }

        /// <summary>
        /// 当前员工担任职务ID(若需要将该字段的值置为空，请传入-1）
        /// </summary>
        public Nullable<long> DutyId { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工花名(若需要将该字段的值置为空，请传入“-1”）
        /// </summary>
        public string EmployeeNickname { get; set; }

        /// <summary>
        /// 员工工号(卖家自定义)(若需要将该字段的值置为空，请传入“-1”）
        /// </summary>
        public string EmployeeNum { get; set; }

        /// <summary>
        /// 登记员工离职  true:登记员工离职
        /// </summary>
        public Nullable<bool> EmployeeTurnover { get; set; }

        /// <summary>
        /// 员工入职时间(若需要将该字段的值置为空，请传入1900-01-01 00:00:00）
        /// </summary>
        public Nullable<DateTime> EntryDate { get; set; }

        /// <summary>
        /// 员工身份证号码(若需要将该字段的值置为空，请传入“-1”）
        /// </summary>
        public string IdCardNum { get; set; }

        /// <summary>
        /// 直接上级的员工ID(若需要将该字段的值置为空，请传入-1）
        /// </summary>
        public Nullable<long> LeaderId { get; set; }

        /// <summary>
        /// 办公电话(若需要将该字段的值置为空，请传入“-1”）
        /// </summary>
        public string OfficePhone { get; set; }

        /// <summary>
        /// 员工私人邮箱(若需要将该字段的值置为空，请传入“-1”）
        /// </summary>
        public string PersonalEmail { get; set; }

        /// <summary>
        /// 员工手机号码(若需要将该字段的值置为空，请传入“-1”）
        /// </summary>
        public string PersonalMobile { get; set; }

        /// <summary>
        /// 员工性别  1：男;  2:女
        /// </summary>
        public Nullable<long> Sex { get; set; }

        /// <summary>
        /// 子账号ID
        /// </summary>
        public Nullable<long> SubId { get; set; }

        /// <summary>
        /// 杭州大厦(若需要将该字段的值置为空，请传入“-1”）
        /// </summary>
        public string WorkLocation { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.subuser.employee.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("department_id", this.DepartmentId);
            parameters.Add("duty_id", this.DutyId);
            parameters.Add("employee_name", this.EmployeeName);
            parameters.Add("employee_nickname", this.EmployeeNickname);
            parameters.Add("employee_num", this.EmployeeNum);
            parameters.Add("employee_turnover", this.EmployeeTurnover);
            parameters.Add("entry_date", this.EntryDate);
            parameters.Add("id_card_num", this.IdCardNum);
            parameters.Add("leader_id", this.LeaderId);
            parameters.Add("office_phone", this.OfficePhone);
            parameters.Add("personal_email", this.PersonalEmail);
            parameters.Add("personal_mobile", this.PersonalMobile);
            parameters.Add("sex", this.Sex);
            parameters.Add("sub_id", this.SubId);
            parameters.Add("work_location", this.WorkLocation);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sub_id", this.SubId);
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
