using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.update
    /// </summary>
    public class FenxiaoProductUpdateRequest : ITopUploadRequest<FenxiaoProductUpdateResponse>
    {
        /// <summary>
        /// 警戒库存必须是0到29999。
        /// </summary>
        public Nullable<long> AlarmNumber { get; set; }

        /// <summary>
        /// 所属类目id，参考Taobao.itemcats.get，不支持成人等类目，输入成人类目id保存提示类目属性错误。
        /// </summary>
        public Nullable<long> CategoryId { get; set; }

        /// <summary>
        /// 所在地：市，例：“杭州”
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 代销采购价格，单位：元。例：“10.56”。必须在0.01元到10000000元之间。
        /// </summary>
        public string CostPrice { get; set; }

        /// <summary>
        /// 经销采购价，单位：元。例：“10.56”。必须在0.01元到10000000元之间。
        /// </summary>
        public string DealerCostPrice { get; set; }

        /// <summary>
        /// 产品描述，长度为5到25000字符。
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 折扣ID
        /// </summary>
        public Nullable<long> DiscountId { get; set; }

        /// <summary>
        /// 是否有保修，可选值：false（否）、true（是），默认false。
        /// </summary>
        public string HaveGuarantee { get; set; }

        /// <summary>
        /// 是否有发票，可选值：false（否）、true（是），默认false。
        /// </summary>
        public string HaveInvoice { get; set; }

        /// <summary>
        /// 主图图片，如果pic_path参数不空，则优先使用pic_path，忽略该参数
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 自定义属性。格式为pid:value;pid:value
        /// </summary>
        public string InputProperties { get; set; }

        /// <summary>
        /// 产品是否需要授权isAuthz:yes|no   yes:需要授权   no:不需要授权
        /// </summary>
        public string IsAuthz { get; set; }

        /// <summary>
        /// 产品名称，长度不超过60个字节。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商家编码，长度不能超过60个字节。
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 产品主图图片空间相对路径或绝对路径
        /// </summary>
        public string PicPath { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> Pid { get; set; }

        /// <summary>
        /// ems费用，单位：元。例：“10.56”。大小为0.01元到999999元之间。更新时必须指定运费类型为buyer，否则不更新。
        /// </summary>
        public string PostageEms { get; set; }

        /// <summary>
        /// 快递费用，单位：元。例：“10.56”。大小为0.01元到999999元之间。更新时必须指定运费类型为buyer，否则不更新。
        /// </summary>
        public string PostageFast { get; set; }

        /// <summary>
        /// 运费模板ID，参考taobao.postages.get。更新时必须指定运费类型为 buyer，否则不更新。
        /// </summary>
        public Nullable<long> PostageId { get; set; }

        /// <summary>
        /// 平邮费用，单位：元。例：“10.56”。大小为0.01元到999999元之间。更新时必须指定运费类型为buyer，否则不更新。
        /// </summary>
        public string PostageOrdinary { get; set; }

        /// <summary>
        /// 运费类型，可选值：seller（供应商承担运费）、buyer（分销商承担运费）。
        /// </summary>
        public string PostageType { get; set; }

        /// <summary>
        /// 产品属性
        /// </summary>
        public string Properties { get; set; }

        /// <summary>
        /// 属性别名
        /// </summary>
        public string PropertyAlias { get; set; }

        /// <summary>
        /// 所在地：省，例：“浙江”
        /// </summary>
        public string Prov { get; set; }

        /// <summary>
        /// 产品库存必须是1到999999。
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        /// <summary>
        /// 最高零售价，单位：元。例：“10.56”。必须在0.01元到10000000元之间，最高零售价必须大于最低零售价。
        /// </summary>
        public string RetailPriceHigh { get; set; }

        /// <summary>
        /// 最低零售价，单位：元。例：“10.56”。必须在0.01元到10000000元之间。
        /// </summary>
        public string RetailPriceLow { get; set; }

        /// <summary>
        /// sku采购价格，单位元，例："10.50,11.00,20.50"，字段必须和上面的sku_ids或sku_properties保持一致。
        /// </summary>
        public string SkuCostPrices { get; set; }

        /// <summary>
        /// sku的经销采购价。如果多个，用逗号分隔，并与其他sku信息保持相同顺序。其中每个值的单位：元。例：“10.56,12.3”。必须在0.01元到10000000元之间。
        /// </summary>
        public string SkuDealerCostPrices { get; set; }

        /// <summary>
        /// sku id列表，例：1001,1002,1003。如果传入sku_properties将忽略此参数。
        /// </summary>
        public string SkuIds { get; set; }

        /// <summary>
        /// sku商家编码 ，单位元，例："S1000,S1002,S1003"，字段必须和上面的id或sku_properties保持一致，如果没有可以写成",,"
        /// </summary>
        public string SkuOuterIds { get; set; }

        /// <summary>
        /// sku属性。格式:pid:vid;pid:vid,表示一组属性如:1627207:3232483;1630696:3284570,表示一组:机身颜色:军绿色;手机套餐:一电一充。多组之间用逗号“,”区分。(属性的pid调用taobao.itemprops.get取得，属性值的vid用taobao.itempropvalues.get取得vid)  通过此字段可新增和更新sku。若传入此值将忽略sku_ids字段。sku其他字段与此值保持一致。
        /// </summary>
        public string SkuProperties { get; set; }

        /// <summary>
        /// 根据sku属性删除sku信息。需要按组删除属性。
        /// </summary>
        public string SkuPropertiesDel { get; set; }

        /// <summary>
        /// sku库存，单位元，例："10,20,30"，字段必须和sku_ids或sku_properties保持一致。
        /// </summary>
        public string SkuQuantitys { get; set; }

        /// <summary>
        /// sku采购基准价，单位元，例："10.50,11.00,20.50"，字段必须和上面的sku_ids或sku_properties保持一致。
        /// </summary>
        public string SkuStandardPrices { get; set; }

        /// <summary>
        /// 采购基准价，单位：元。例：“10.56”。必须在0.01元到10000000元之间。
        /// </summary>
        public string StandardPrice { get; set; }

        /// <summary>
        /// 零售基准价，单位：元。例：“10.56”。必须在0.01元到10000000元之间。
        /// </summary>
        public string StandardRetailPrice { get; set; }

        /// <summary>
        /// 发布状态，可选值：up（上架）、down（下架）、delete（删除），输入非法字符则忽略。
        /// </summary>
        public string Status { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.product.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("alarm_number", this.AlarmNumber);
            parameters.Add("category_id", this.CategoryId);
            parameters.Add("city", this.City);
            parameters.Add("cost_price", this.CostPrice);
            parameters.Add("dealer_cost_price", this.DealerCostPrice);
            parameters.Add("desc", this.Desc);
            parameters.Add("discount_id", this.DiscountId);
            parameters.Add("have_guarantee", this.HaveGuarantee);
            parameters.Add("have_invoice", this.HaveInvoice);
            parameters.Add("input_properties", this.InputProperties);
            parameters.Add("is_authz", this.IsAuthz);
            parameters.Add("name", this.Name);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("pic_path", this.PicPath);
            parameters.Add("pid", this.Pid);
            parameters.Add("postage_ems", this.PostageEms);
            parameters.Add("postage_fast", this.PostageFast);
            parameters.Add("postage_id", this.PostageId);
            parameters.Add("postage_ordinary", this.PostageOrdinary);
            parameters.Add("postage_type", this.PostageType);
            parameters.Add("properties", this.Properties);
            parameters.Add("property_alias", this.PropertyAlias);
            parameters.Add("prov", this.Prov);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("retail_price_high", this.RetailPriceHigh);
            parameters.Add("retail_price_low", this.RetailPriceLow);
            parameters.Add("sku_cost_prices", this.SkuCostPrices);
            parameters.Add("sku_dealer_cost_prices", this.SkuDealerCostPrices);
            parameters.Add("sku_ids", this.SkuIds);
            parameters.Add("sku_outer_ids", this.SkuOuterIds);
            parameters.Add("sku_properties", this.SkuProperties);
            parameters.Add("sku_properties_del", this.SkuPropertiesDel);
            parameters.Add("sku_quantitys", this.SkuQuantitys);
            parameters.Add("sku_standard_prices", this.SkuStandardPrices);
            parameters.Add("standard_price", this.StandardPrice);
            parameters.Add("standard_retail_price", this.StandardRetailPrice);
            parameters.Add("status", this.Status);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("image", this.Image, 512000);
            RequestValidator.ValidateRequired("pid", this.Pid);
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
