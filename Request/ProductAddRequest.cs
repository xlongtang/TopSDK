using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.add
    /// </summary>
    public class ProductAddRequest : ITopUploadRequest<ProductAddResponse>
    {
        /// <summary>
        /// 非关键属性结构:pid:vid;pid:vid.<br> 非关键属性<font color=red>不包含</font>关键属性、销售属性、用户自定义属性、商品属性; <br>调用taobao.itemprops.get获取pid,调用taobao.itempropvalues.get获取vid.<br><font color=red>注:支持最大长度为512字节</font>
        /// </summary>
        public string Binds { get; set; }

        /// <summary>
        /// 商品类目ID.调用taobao.itemcats.get获取;注意:必须是叶子类目 id.
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 用户自定义属性,结构：pid1:value1;pid2:value2，如果有型号，系列等子属性用: 隔开 例如：“20000:优衣库:型号:001;632501:1234”，表示“品牌:优衣库:型号:001;货号:1234” <br><font color=red>注：包含所有自定义属性的传入</font>
        /// </summary>
        public string CustomerProps { get; set; }

        /// <summary>
        /// 产品描述.最大不超过25000个字符
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 存放产品扩展信息，由List(ProductExtraInfo)转化成jsonArray存入.
        /// </summary>
        public string ExtraInfo { get; set; }

        /// <summary>
        /// 产品主图片.最大1M,目前仅支持GIF,JPG.
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 是不是主图
        /// </summary>
        public Nullable<bool> Major { get; set; }

        /// <summary>
        /// 市场ID，1为新增C2C市场的产品信息， 2为新增B2C市场的产品信息。  不填写此值则C用户新增B2C市场的产品信息，B用户新增B2C市场的产品信息。
        /// </summary>
        public string MarketId { get; set; }

        /// <summary>
        /// 上市时间。目前只支持鞋城类目传入此参数
        /// </summary>
        public Nullable<DateTime> MarketTime { get; set; }

        /// <summary>
        /// 产品名称,最大30个字符.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 外部产品ID
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 包装清单。注意，在管控类目下，包装清单不能为空，同时保证清单的格式为：  名称:数字;名称:数字;  其中，名称不能违禁、不能超过60字符，数字不能超过999
        /// </summary>
        public string PackingList { get; set; }

        /// <summary>
        /// 产品市场价.精确到2位小数;单位为元.如：200.07
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 销售属性值别名。格式为pid1:vid1:alias1;pid1:vid2:alia2。只有少数销售属性值支持传入别名，比如颜色和尺寸
        /// </summary>
        public string PropertyAlias { get; set; }

        /// <summary>
        /// 关键属性 结构:pid:vid;pid:vid.调用taobao.itemprops.get获取pid,调用taobao.itempropvalues.get获取vid;如果碰到用户自定义属性,请用customer_props.
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 销售属性结构:pid:vid;pid:vid.调用taobao.itemprops.get获取is_sale_prop＝true的pid,调用taobao.itempropvalues.get获取vid.
        /// </summary>
        public string SaleProps { get; set; }

        /// <summary>
        /// 商品卖点描述，长度限制为20个汉字
        /// </summary>
        public string SellPt { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("binds", this.Binds);
            parameters.Add("cid", this.Cid);
            parameters.Add("customer_props", this.CustomerProps);
            parameters.Add("desc", this.Desc);
            parameters.Add("extra_info", this.ExtraInfo);
            parameters.Add("major", this.Major);
            parameters.Add("market_id", this.MarketId);
            parameters.Add("market_time", this.MarketTime);
            parameters.Add("name", this.Name);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("packing_list", this.PackingList);
            parameters.Add("price", this.Price);
            parameters.Add("property_alias", this.PropertyAlias);
            parameters.Add("props", this.Props);
            parameters.Add("sale_props", this.SaleProps);
            parameters.Add("sell_pt", this.SellPt);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("binds", this.Binds, 512);
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateMaxLength("extra_info", this.ExtraInfo, 25000);
            RequestValidator.ValidateRequired("image", this.Image);
            RequestValidator.ValidateMaxLength("image", this.Image, 1048576);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image", this.Image);
            return parameters;
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
