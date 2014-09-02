using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SRoomType Data Structure.
    /// </summary>
    [Serializable]
    public class SRoomType : TopObject
    {
        /// <summary>
        /// 面积
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 床型。json格式：[{"bedType":"大床","bedSize":"1.5m"},{"bedType":"双床","bedSize":"1.2m"}]
        /// </summary>
        [XmlElement("bed")]
        public string Bed { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// facility
        /// </summary>
        [XmlElement("facility")]
        public string Facility { get; set; }

        /// <summary>
        /// 楼层
        /// </summary>
        [XmlElement("floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 宽带服务  "0","有线上网(免费),  "1","有线上网(无)",  "2","有线上网(收费)",  "3","有线上网(部分有且免费)",  "4","有线上网(部分有且收费)"
        /// </summary>
        [XmlElement("internet")]
        public string Internet { get; set; }

        /// <summary>
        /// 最大入住人数
        /// </summary>
        [XmlElement("max_occupancy")]
        public long MaxOccupancy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 房型名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// pic_url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// shid
        /// </summary>
        [XmlElement("shid")]
        public long Shid { get; set; }

        /// <summary>
        /// 匹配的标准房型
        /// </summary>
        [XmlElement("srid")]
        public long Srid { get; set; }

        /// <summary>
        /// 状态。0:正常;-1:删除
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 窗型，枚举类型  0, 无窗,  1, 有窗;
        /// </summary>
        [XmlElement("window_type")]
        public string WindowType { get; set; }
    }
}
