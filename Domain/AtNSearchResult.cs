using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// AtNSearchResult Data Structure.
    /// </summary>
    [Serializable]
    public class AtNSearchResult : TopObject
    {
        /// <summary>
        /// json串，描述活动信息。type：1普通直减、2后返、3多人同行
        /// </summary>
        [XmlElement("activity_map_json")]
        public string ActivityMapJson { get; set; }

        /// <summary>
        /// json格式字符串：描述代理商的基本信息结构；注意：仅在指定航班号查询的时候有输出。得分项可能有三个Key（不一定全部输出）: normalProdcutScore,specialProductScore,speedIssueProductScore，分别表示普通产品得分，特殊产品（申请票）得分，极速出票产品得分。  supplyType: 1 ：航空公司代理商， 2： 普通机票代理商
        /// </summary>
        [XmlElement("agent_info_map")]
        public string AgentInfoMap { get; set; }

        /// <summary>
        /// JSON串，描述航空公司二字码与中文名称的关系
        /// </summary>
        [XmlElement("airline_info_map")]
        public string AirlineInfoMap { get; set; }

        /// <summary>
        /// JSON串，描述机场三字码和中文名称的对应关系
        /// </summary>
        [XmlElement("airport_info_map")]
        public string AirportInfoMap { get; set; }

        /// <summary>
        /// JSON串，描述舱位信息，key：航司+舱位代码，如“CA-Y”
        /// </summary>
        [XmlElement("cabin_info_map")]
        public string CabinInfoMap { get; set; }

        /// <summary>
        /// json格式字符串：描述出发/到达城市基本信息
        /// </summary>
        [XmlElement("city_info_map")]
        public string CityInfoMap { get; set; }

        /// <summary>
        /// JSON串，表示航班具体信息,key为出发+达到+航班号，如："BJSSHAMU5162"。示例值：{“BJSSHAMU5102":{"depTime":1403178600000,"flightType":"333","depAirportCode":"PEK","fees":5000,"depTerm":"T2","flight":"MU5102","stops":0,"airlineCode":"MU","meals":1,"arrTerm":"T2","arrTime":1403178600000,"carrier":"","arrAirportCode":"SHA","taxes":14000}}
        /// </summary>
        [XmlElement("flight_info_map")]
        public string FlightInfoMap { get; set; }

        /// <summary>
        /// json格式字符串：描述当前搜索结果中航班机型信息， small表示小型机；middle表示中型机；large表示大型机
        /// </summary>
        [XmlElement("flight_type_info_map")]
        public string FlightTypeInfoMap { get; set; }

        /// <summary>
        /// 保险分润扣钱规则说明（单位元）。{"insurePrice":20,//保险总价格  "insureAdultPrice":15,//保险成人分润价格  "insureChildPrice":0,//保险儿童分润价格  "insure9cPrice":20//春秋航空保险分润金额  }
        /// </summary>
        [XmlElement("insure_promotion_info_map_json")]
        public string InsurePromotionInfoMapJson { get; set; }

        /// <summary>
        /// 机票商品列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("at_n_search_item_v_o")]
        public List<AtNSearchItemVO> Items { get; set; }
    }
}
