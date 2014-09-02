using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGradeGetResponse.
    /// </summary>
    public class CrmGradeGetResponse : TopResponse
    {
        /// <summary>
        /// 等级信息集合
        /// </summary>
        [XmlArray("grade_promotions")]
        [XmlArrayItem("grade_promotion")]
        public List<GradePromotion> GradePromotions { get; set; }
    }
}
