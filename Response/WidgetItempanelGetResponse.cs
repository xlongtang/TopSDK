using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WidgetItempanelGetResponse.
    /// </summary>
    public class WidgetItempanelGetResponse : TopResponse
    {
        /// <summary>
        /// 服务端签名后的添加链接，isv在使用的时候前面加上“http://gw.api.taobao.com/widget?”后面加上用户选择的sku_id和购买的quantity即可生成完整的购买链接。
        /// </summary>
        [XmlElement("add_url")]
        public string AddUrl { get; set; }

        /// <summary>
        /// 取得的商品相关信息，如果不指定fields返回所有字段，如果指定了fields但是都是无效字段，返回的item结构体中字段为空
        /// </summary>
        [XmlElement("item")]
        public WidgetItem Item { get; set; }
    }
}
