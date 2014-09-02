using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SubUserFullInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubUserFullInfo : TopObject
    {
        /// <summary>
        /// 部门Id
        /// </summary>
        [XmlElement("department_id")]
        public long DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 职务Id
        /// </summary>
        [XmlElement("duty_id")]
        public long DutyId { get; set; }

        /// <summary>
        /// 职务等级
        /// </summary>
        [XmlElement("duty_level")]
        public long DutyLevel { get; set; }

        /// <summary>
        /// 职务名称
        /// </summary>
        [XmlElement("duty_name")]
        public string DutyName { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [XmlElement("employee_id")]
        public long EmployeeId { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("employee_name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工花名
        /// </summary>
        [XmlElement("employee_nickname")]
        public string EmployeeNickname { get; set; }

        /// <summary>
        /// 入职员工工号
        /// </summary>
        [XmlElement("employee_num")]
        public string EmployeeNum { get; set; }

        /// <summary>
        /// 员工入职时间
        /// </summary>
        [XmlElement("entry_date")]
        public string EntryDate { get; set; }

        /// <summary>
        /// 直接上级的员工ID
        /// </summary>
        [XmlElement("leader_id")]
        public long LeaderId { get; set; }

        /// <summary>
        /// 办公电话
        /// </summary>
        [XmlElement("office_phone")]
        public string OfficePhone { get; set; }

        /// <summary>
        /// 父部门Id
        /// </summary>
        [XmlElement("parent_department")]
        public long ParentDepartment { get; set; }

        /// <summary>
        /// 员工性别  1:男;  2:女
        /// </summary>
        [XmlElement("sex")]
        public long Sex { get; set; }

        /// <summary>
        /// 子账号是否参与分流 true:参与分流 false:未参与分流
        /// </summary>
        [XmlElement("sub_dispatch_status")]
        public bool SubDispatchStatus { get; set; }

        /// <summary>
        /// 子账号Id
        /// </summary>
        [XmlElement("sub_id")]
        public long SubId { get; set; }

        /// <summary>
        /// 子账号用户名
        /// </summary>
        [XmlElement("sub_nick")]
        public string SubNick { get; set; }

        /// <summary>
        /// 子账号是否已欠费 true:已欠费 false:未欠费
        /// </summary>
        [XmlElement("sub_owed_status")]
        public bool SubOwedStatus { get; set; }

        /// <summary>
        /// 子账号当前状态：1正常，2卖家停用，3处罚冻结
        /// </summary>
        [XmlElement("sub_status")]
        public long SubStatus { get; set; }

        /// <summary>
        /// 子账号企业邮箱
        /// </summary>
        [XmlElement("subuser_email")]
        public string SubuserEmail { get; set; }

        /// <summary>
        /// 主账号企业邮箱
        /// </summary>
        [XmlElement("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// 主账号Id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 主账号用户名
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        [XmlElement("work_location")]
        public string WorkLocation { get; set; }
    }
}
