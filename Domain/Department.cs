using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Department Data Structure.
    /// </summary>
    [Serializable]
    public class Department : TopObject
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        [XmlElement("department_id")]
        public long DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 当前部门的父部门ID
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }
    }
}
