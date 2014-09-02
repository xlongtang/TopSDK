using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TopFee Data Structure.
    /// </summary>
    [Serializable]
    public class TopFee : TopObject
    {
        /// <summary>
        /// 增费：输入0.00-999.99（最多包含两位小数） 不能为空不输入运费时必须输入0
        /// </summary>
        [XmlElement("add_fee")]
        public string AddFee { get; set; }

        /// <summary>
        /// 增费标准：当valuation(记价方式)为0时输入1-9999范围内的整数
        /// </summary>
        [XmlElement("add_standard")]
        public string AddStandard { get; set; }

        /// <summary>
        /// 邮费子项涉及的地区,多个地区用逗号连接数量串;可以用taobao.areas.get接口获取.或者参考:http://www.stats.gov.cn/tjbz/xzqhdm/t20080215_402462675.htm 例 (110000,310000,320000,330000).就代表邮费子项涉 及(北京,上海,江苏,浙江)四个地区.填写时要注意对照地区代码值,如果填入错误地区代码,将会出现错误信息.
        /// </summary>
        [XmlElement("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 可选值：post:平邮; cod:货到付款; ems:EMS; express:快递公司
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 首费：输入0.01-999.99（最多包含两位小数） 不能为空也不能为0
        /// </summary>
        [XmlElement("start_fee")]
        public string StartFee { get; set; }

        /// <summary>
        /// 首费标准：当valuation(记价方式)为0时输入1-9999范围内的整数
        /// </summary>
        [XmlElement("start_standard")]
        public string StartStandard { get; set; }
    }
}
