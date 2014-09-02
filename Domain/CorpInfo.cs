using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CorpInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CorpInfo : TopObject
    {
        /// <summary>
        /// 申请人姓名
        /// </summary>
        [XmlElement("apply_name")]
        public string ApplyName { get; set; }

        /// <summary>
        /// 申请人工号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 集团id
        /// </summary>
        [XmlElement("corpration_id")]
        public string CorprationId { get; set; }

        /// <summary>
        /// 成本中心
        /// </summary>
        [XmlElement("cost_center")]
        public string CostCenter { get; set; }

        /// <summary>
        /// 成本中心代码
        /// </summary>
        [XmlElement("cost_center_code")]
        public string CostCenterCode { get; set; }

        /// <summary>
        /// 费用归属OU的CODE
        /// </summary>
        [XmlElement("cost_ou")]
        public string CostOu { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// BPM的fromNO
        /// </summary>
        [XmlElement("form_no")]
        public string FormNo { get; set; }

        /// <summary>
        /// 单据状态代码
        /// </summary>
        [XmlElement("form_status")]
        public string FormStatus { get; set; }

        /// <summary>
        /// 单据状态描述
        /// </summary>
        [XmlElement("receipts_status")]
        public string ReceiptsStatus { get; set; }

        /// <summary>
        /// 出差人姓名
        /// </summary>
        [XmlElement("trip_person_name")]
        public string TripPersonName { get; set; }

        /// <summary>
        /// 出差人工号
        /// </summary>
        [XmlElement("trip_person_no")]
        public string TripPersonNo { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        [XmlElement("work_space")]
        public string WorkSpace { get; set; }
    }
}
