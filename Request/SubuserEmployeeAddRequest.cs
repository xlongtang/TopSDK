using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.subuser.employee.add
    /// </summary>
    public class SubuserEmployeeAddRequest : ITopRequest<SubuserEmployeeAddResponse>
    {
        /// <summary>
        /// 当前员工所属部门ID
        /// </summary>
        public Nullable<long> DepartmentId { get; set; }

        /// <summary>
        /// 当前员工担任职务ID
        /// </summary>
        public Nullable<long> DutyId { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工花名
        /// </summary>
        public string EmployeeNickname { get; set; }

        /// <summary>
        /// 员工工号(可以用大小写英文字母和数字)
        /// </summary>
        public string EmployeeNum { get; set; }

        /// <summary>
        /// 员工入职时间
        /// </summary>
        public Nullable<DateTime> EntryDate { get; set; }

        /// <summary>
        /// 员工身份证号码
        /// </summary>
        public string IdCardNum { get; set; }

        /// <summary>
        /// 直接上级的员工ID
        /// </summary>
        public Nullable<long> LeaderId { get; set; }

        /// <summary>
        /// 办公电话
        /// </summary>
        public string OfficePhone { get; set; }

        /// <summary>
        /// 员工私人邮箱
        /// </summary>
        public string PersonalEmail { get; set; }

        /// <summary>
        /// 员工手机号码
        /// </summary>
        public string PersonalMobile { get; set; }

        /// <summary>
        /// 员工性别 1：男; 2:女
        /// </summary>
        public Nullable<long> Sex { get; set; }

        /// <summary>
        /// 子账号ID
        /// </summary>
        public Nullable<long> SubId { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        public string WorkLocation { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.subuser.employee.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("department_id", this.DepartmentId);
            parameters.Add("duty_id", this.DutyId);
            parameters.Add("employee_name", this.EmployeeName);
            parameters.Add("employee_nickname", this.EmployeeNickname);
            parameters.Add("employee_num", this.EmployeeNum);
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
            RequestValidator.ValidateRequired("department_id", this.DepartmentId);
            RequestValidator.ValidateRequired("employee_name", this.EmployeeName);
            RequestValidator.ValidateRequired("sex", this.Sex);
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
