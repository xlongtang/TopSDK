using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.delivery.template.get
    /// </summary>
    public class DeliveryTemplateGetRequest : ITopRequest<DeliveryTemplateGetResponse>
    {
        /// <summary>
        /// 需返回的字段列表。 <br/>   <B>  可选值:示例中的值;各字段之间用","隔开  </B>  <br/><br/>   <font color=blue>  template_id：查询模板ID <br/>   template_name:查询模板名称 <br/>   assumer：查询服务承担放 <br/>   valuation:查询计价规则 <br/>   supports:查询增值服务列表 <br/>   created:查询模板创建时间 <br/>   modified:查询修改时间<br/>   consign_area_id:运费模板上设置的卖家发货地址最小级别ID<br/>   address:卖家地址信息  </font>  <br/><br/>   <font color=bule>  query_cod:查询货到付款运费信息<br/>   query_post:查询平邮运费信息 <br/>   query_express:查询快递公司运费信息 <br/>   query_ems:查询EMS运费信息<br/>   query_bzsd:查询普通保障速递运费信息<br/>   query_wlb:查询物流宝保障速递运费信息<br/>   query_furniture:查询家装物流运费信息  <font color=blue>  <br/><br/>  <font color=red>不能有空格</font>
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 需要查询的运费模板ID列表
        /// </summary>
        public string TemplateIds { get; set; }

        /// <summary>
        /// 在没有登录的情况下根据淘宝用户昵称查询指定的模板
        /// </summary>
        public string UserNick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.delivery.template.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("template_ids", this.TemplateIds);
            parameters.Add("user_nick", this.UserNick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("template_ids", this.TemplateIds);
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
