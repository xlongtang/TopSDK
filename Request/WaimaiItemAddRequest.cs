using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.waimai.item.add
    /// </summary>
    public class WaimaiItemAddRequest : ITopRequest<WaimaiItemAddResponse>
    {
        /// <summary>
        /// 商品描述，至少输入5个字
        /// </summary>
        public string Auctiondesc { get; set; }

        /// <summary>
        /// 商品状态(0立即出售,-2放入仓库)
        /// </summary>
        public Nullable<long> Auctionstatus { get; set; }

        /// <summary>
        /// 宝贝所属后台类目
        /// </summary>
        public Nullable<long> Categoryid { get; set; }

        /// <summary>
        /// 自定义类目,一个商品对应一个自定义类目
        /// </summary>
        public string Categoryids { get; set; }

        /// <summary>
        /// 商品外部编码，没有则为空
        /// </summary>
        public string Goodsno { get; set; }

        /// <summary>
        /// 限购数量,不输入则表示该宝贝无限购数
        /// </summary>
        public Nullable<long> Limitbuy { get; set; }

        /// <summary>
        /// 宝贝原价，最多两位小数
        /// </summary>
        public string Oriprice { get; set; }

        /// <summary>
        /// 宝贝图片
        /// </summary>
        public string Picurl { get; set; }

        /// <summary>
        /// 宝贝现在价格,最多两位小数<br /> 支持最大长度为：8<br /> 支持的最大列表长度为：8
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 菜品库存(范围1-999999)<br /> 支持的最大列表长度为：6
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        /// <summary>
        /// 商品规则ID
        /// </summary>
        public Nullable<long> RuleId { get; set; }

        /// <summary>
        /// 外卖店铺id，多个以英文逗号分隔
        /// </summary>
        public string Shopids { get; set; }

        /// <summary>
        /// [{"pv":[{"pText":"颜色","vText":"红色"},{"pText":"尺寸","vText":"8寸"},{"pText":"辣度","vText":"重辣"}],         "quantity":"10","price":"100.00","outSkuId":"XXXXXID"}]
        /// </summary>
        public string SkuInfo { get; set; }

        /// <summary>
        /// 菜名<br /> 支持最大长度为：30<br /> 支持的最大列表长度为：30
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 宝贝副图，最多可上传4张
        /// </summary>
        public string Viceimage { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.waimai.item.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auctiondesc", this.Auctiondesc);
            parameters.Add("auctionstatus", this.Auctionstatus);
            parameters.Add("categoryid", this.Categoryid);
            parameters.Add("categoryids", this.Categoryids);
            parameters.Add("goodsno", this.Goodsno);
            parameters.Add("limitbuy", this.Limitbuy);
            parameters.Add("oriprice", this.Oriprice);
            parameters.Add("picurl", this.Picurl);
            parameters.Add("price", this.Price);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("rule_id", this.RuleId);
            parameters.Add("shopids", this.Shopids);
            parameters.Add("sku_info", this.SkuInfo);
            parameters.Add("title", this.Title);
            parameters.Add("viceimage", this.Viceimage);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("auctiondesc", this.Auctiondesc);
            RequestValidator.ValidateRequired("auctionstatus", this.Auctionstatus);
            RequestValidator.ValidateRequired("categoryid", this.Categoryid);
            RequestValidator.ValidateRequired("picurl", this.Picurl);
            RequestValidator.ValidateRequired("price", this.Price);
            RequestValidator.ValidateMaxLength("price", this.Price, 8);
            RequestValidator.ValidateRequired("quantity", this.Quantity);
            RequestValidator.ValidateRequired("shopids", this.Shopids);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 30);
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
