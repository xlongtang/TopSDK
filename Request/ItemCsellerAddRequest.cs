using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.cseller.add
    /// </summary>
    public class ItemCsellerAddRequest : ITopRequest<ItemCsellerAddResponse>
    {
        /// <summary>
        /// 售后服务说明模板id
        /// </summary>
        public Nullable<long> AfterSaleId { get; set; }

        /// <summary>
        /// 商品上传后的状态。可选值:onsale(出售中),instock(仓库中);默认值:onsale
        /// </summary>
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 代充商品类型。只有少数类目下的商品可以标记上此字段，具体哪些类目可以上传可以通过taobao.itemcat.features.get获得。在代充商品的类目下，不传表示不标记商品类型（交易搜索中就不能通过标记搜到相关的交易了）。可选类型：   *no_mark(不做类型标记)   *time_card(点卡软件代充)   *fee_card(话费软件代充)
        /// </summary>
        public string AutoFill { get; set; }

        /// <summary>
        /// 自动重发。可选值:true,false;默认值:false(不重发)
        /// </summary>
        public Nullable<bool> AutoRepost { get; set; }

        /// <summary>
        /// 叶子类目id
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 货到付款运费模板ID
        /// </summary>
        public Nullable<long> CodPostageId { get; set; }

        /// <summary>
        /// 宝贝描述。字数要大于5个字符，小于25000个字符，受违禁词控制
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// ems费用。取值范围:0-100000000;精确到2位小数;单位:元。如:25.07，表示:25元7分
        /// </summary>
        public string EmsFee { get; set; }

        /// <summary>
        /// 快递费用。取值范围:0.01-10000.00;精确到2位小数;单位:元。如:15.07，表示:15元7分
        /// </summary>
        public string ExpressFee { get; set; }

        /// <summary>
        /// 宝贝特征值，格式为：  【key1:value1;key2:value2;key3:value3;】，key和value用【:】分隔，key&value之间用【;】分隔，只有在Top支持的特征值才能保存到宝贝上，目前支持的Key列表为：mysize_tp
        /// </summary>
        public string Features { get; set; }

        /// <summary>
        /// 运费承担方式。可选值:seller（卖家承担）,buyer(买家承担);默认值:seller。卖家承担不用设置邮费和postage_id.买家承担的时候，必填邮费和postage_id   如果用户设置了运费模板会优先使用运费模板，否则要同步设置邮费（post_fee,express_fee,ems_fee
        /// </summary>
        public string FreightPayer { get; set; }

        /// <summary>
        /// 针对全球购卖家的库存类型业务，  有两种库存类型：现货和代购  参数值为1时代表现货，值为2时代表代购  如果传值为这两个值之外的值，会报错;  如果不是全球购卖家，这两个值即使设置也不会处理
        /// </summary>
        public string GlobalStockType { get; set; }

        /// <summary>
        /// 支持会员打折。可选值:true,false;默认值:false(不打折)
        /// </summary>
        public Nullable<bool> HasDiscount { get; set; }

        /// <summary>
        /// 是否有发票。可选值:true,false (商城卖家此字段必须为true);默认值:false(无发票)
        /// </summary>
        public Nullable<bool> HasInvoice { get; set; }

        /// <summary>
        /// 橱窗推荐。可选值:true,false;默认值:false(不推荐)
        /// </summary>
        public Nullable<bool> HasShowcase { get; set; }

        /// <summary>
        /// 是否有保修。可选值:true,false;默认值:false(不保修)
        /// </summary>
        public Nullable<bool> HasWarranty { get; set; }

        /// <summary>
        /// 加价幅度。如果为0，代表系统代理幅度
        /// </summary>
        public string Increment { get; set; }

        /// <summary>
        /// 用户的内店装修模板id。
        /// </summary>
        public Nullable<long> InnerShopAuctionTemplateId { get; set; }

        /// <summary>
        /// 用户自行输入的类目属性ID串。结构："pid1,pid2,pid3"，如："20000"（表示品牌） 注：通常一个类目下用户可输入的关键属性不超过1个。
        /// </summary>
        public string InputPids { get; set; }

        /// <summary>
        /// 用户自行输入的子属性名和属性值，结构:"父属性值;一级子属性名;一级子属性值;二级子属性名;自定义输入值,....",如：“耐克;耐克系列;科比系列;科比系列;2K5,Nike乔丹鞋;乔丹系列;乔丹鞋系列;乔丹鞋系列;json5”，多个自定义属性用','分割，input_str需要与input_pids一一对应，注：通常一个类目下用户可输入的关键属性不超过1个。所有属性别名加起来不能超过3999字节
        /// </summary>
        public string InputStr { get; set; }

        /// <summary>
        /// 是否是3D商品
        /// </summary>
        public Nullable<bool> Is3D { get; set; }

        /// <summary>
        /// 是否在外部网店显示
        /// </summary>
        public Nullable<bool> IsEx { get; set; }

        /// <summary>
        /// 实物闪电发货
        /// </summary>
        public Nullable<bool> IsLightningConsignment { get; set; }

        /// <summary>
        /// 是否在淘宝显示
        /// </summary>
        public Nullable<bool> IsTaobao { get; set; }

        /// <summary>
        /// 商品是否为新品。只有在当前类目开通新品,并且当前用户拥有该类目下发布新品权限时才能设置is_xinpin为true，否则设置true后会返回错误码:isv.invalid-permission:xinpin。同时只有一口价全新的宝贝才能设置为新品，否则会返回错误码：isv.invalid-parameter:xinpin。不设置该参数值或设置为false效果一致。
        /// </summary>
        public Nullable<bool> IsXinpin { get; set; }

        /// <summary>
        /// 表示商品的体积，如果需要使用按体积计费的运费模板，一定要设置这个值。该值的单位为立方米（m3），如果是其他单位，请转换成成立方米。 该值支持两种格式的设置：格式1：bulk:3,单位为立方米(m3),表示直接设置为商品的体积。格式2：length:10;breadth:10;height:10，单位为米（m）。体积和长宽高都支持小数类型。 在传入体积或长宽高时候，不能带单位。体积的单位默认为立方米（m3），长宽高的单位默认为米(m) 该值支持两种格式的设置：格式1：bulk:3,单位为立方米(m3),表示直接设置为商品的体积。格式2：length:10;breadth:10;height:10，单位为米（m）
        /// </summary>
        public string ItemSize { get; set; }

        /// <summary>
        /// 特定种类的商品约束，以key：value的形式传入，以分号间隔。如食品安全需要输入：food_security.prd_license_no：12345;food_security.design_code：444;...。这些key：value可参考taobao.item.add的对应输入参数。
        /// </summary>
        public string ItemSpecProp { get; set; }

        /// <summary>
        /// 商品的重量，用于按重量计费的运费模板。注意：单位为kg。 只能传入数值类型（包含小数），不能带单位，单位默认为kg。
        /// </summary>
        public string ItemWeight { get; set; }

        /// <summary>
        /// 商品文字的字符集。繁体传入"zh_HK"，简体传入"zh_CN"，不传默认为简体
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// 定时上架时间。(时间格式：yyyy-MM-dd HH:mm:ss)
        /// </summary>
        public Nullable<DateTime> ListTime { get; set; }

        /// <summary>
        /// 发布电子凭证宝贝时候表示是否使用邮寄 0: 代表不使用邮寄； 1：代表使用邮寄；如果不设置这个值，代表不使用邮寄
        /// </summary>
        public string LocalityLifeChooseLogis { get; set; }

        /// <summary>
        /// 本地生活电子交易凭证业务，目前此字段只涉及到的信息为有效期;  如果有效期为起止日期类型，此值为2012-08-06,2012-08-16  如果有效期为【购买成功日 至】类型则格式为2012-08-16  如果有效期为天数类型则格式为15
        /// </summary>
        public string LocalityLifeExpirydate { get; set; }

        /// <summary>
        /// 码商信息，格式为 码商id:nick
        /// </summary>
        public string LocalityLifeMerchant { get; set; }

        /// <summary>
        /// 网点ID
        /// </summary>
        public string LocalityLifeNetworkId { get; set; }

        /// <summary>
        /// 电子凭证售中自动退款比例，百分比%前的数字，介于1-100之间的整数
        /// </summary>
        public Nullable<long> LocalityLifeOnsaleAutoRefundRatio { get; set; }

        /// <summary>
        /// 退款比例，  百分比%前的数字,1-100的正整数值
        /// </summary>
        public Nullable<long> LocalityLifeRefundRatio { get; set; }

        /// <summary>
        /// 核销打款   1代表核销打款 0代表非核销打款
        /// </summary>
        public string LocalityLifeVerification { get; set; }

        /// <summary>
        /// 所在地城市。如杭州 。具体可以用taobao.areas.get取到
        /// </summary>
        public string LocationCity { get; set; }

        /// <summary>
        /// 所在地省份。如浙江，具体可以用taobao.areas.get取到
        /// </summary>
        public string LocationState { get; set; }

        /// <summary>
        /// 商品数量，取值范围:0-999999的整数。且需要等于Sku所有数量的和
        /// </summary>
        public Nullable<long> Num { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 用户的外店装修模板id
        /// </summary>
        public Nullable<long> OuterShopAuctionTemplateId { get; set; }

        /// <summary>
        /// 商品主图需要关联的图片空间的相对url。这个url所对应的图片必须要属于当前用户。pic_path和image只需要传入一个,如果两个都传，默认选择pic_path
        /// </summary>
        public string PicPath { get; set; }

        /// <summary>
        /// 平邮费用。取值范围:0.01-10000.00;精确到2位小数;单位:元。如:5.07，表示:5元7分. 注:post_fee,express_fee,ems_fee需要一起填写
        /// </summary>
        public string PostFee { get; set; }

        /// <summary>
        /// 宝贝所属的运费模板ID。取值范围：整数且必须是该卖家的运费模板的ID（可通过taobao.postages.get获得当前会话用户的所有邮费模板）
        /// </summary>
        public Nullable<long> PostageId { get; set; }

        /// <summary>
        /// 商品价格。取值范围:0-100000000;精确到2位小数;单位:元。如:200.07，表示:200元7分。需要在正确的价格区间内。
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 属性值别名。如pid:vid:别名;pid1:vid1:别名1 ，其中：pid是属性id vid是属性值id。总长度不超过511字节
        /// </summary>
        public string PropertyAlias { get; set; }

        /// <summary>
        /// 商品属性列表。格式:pid:vid;pid:vid。属性的pid调用taobao.itemprops.get取得，属性值的vid用taobao.itempropvalues.get取得vid。 如果该类目下面没有属性，可以不用填写。如果有属性，必选属性必填，其他非必选属性可以选择不填写.属性不能超过35对。所有属性加起来包括分割符不能超过549字节，单个属性没有限制。 如果有属性是可输入的话，则用字段input_str填入属性的值
        /// </summary>
        public string Props { get; set; }

        /// <summary>
        /// 秒杀商品类型。暂时不能使用。打上秒杀标记的商品，用户只能下架并不能再上架，其他任何编辑或删除操作都不能进行。如果用户想取消秒杀标记，需要联系小二进行操作。如果秒杀结束需要自由编辑请联系活动负责人（小二）去掉秒杀标记。可选类型  web_only(只能通过web网络秒杀)  wap_only(只能通过wap网络秒杀)  web_and_wap(既能通过web秒杀也能通过wap秒杀)
        /// </summary>
        public string SecondKill { get; set; }

        /// <summary>
        /// 是否承诺退换货服务!虚拟商品无须设置此项!
        /// </summary>
        public Nullable<bool> SellPromise { get; set; }

        /// <summary>
        /// 商品所属的店铺类目列表。按逗号分隔。结构:",cid1,cid2,...,"，如果店铺类目存在二级类目，必须传入子类目cids。
        /// </summary>
        public string SellerCids { get; set; }

        /// <summary>
        /// sku_properties, sku_quantities, sku_prices, sku_outer_ids在输入数据时要一一对应，如果没有sku_outer_ids可写成：“, ,”
        /// </summary>
        public string SkuOuterIds { get; set; }

        /// <summary>
        /// Sku的价格串，结构如：10.00,5.00,… 精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        public string SkuPrices { get; set; }

        /// <summary>
        /// 更新的Sku的属性串，调用taobao.itemprops.get获取类目属性，如果属性是销售属性，再用taobao.itempropvalues.get取得vid。格式:pid:vid;pid:vid,多个sku之间用逗号分隔。该字段内的销售属性(自定义的除外)也需要在props字段填写 . 规则：如果该SKU存在旧商品，则修改；否则新增Sku。如果更新时有对Sku进行操作，则Sku的properties一定要传入。如果存在自定义销售属性，则格式为pid:vid;pid2:vid2;$pText:vText，其中$pText:vText为自定义属性。限制：其中$pText的’$’前缀不能少，且pText和vText文本中不可以存在 冒号:和分号;以及逗号
        /// </summary>
        public string SkuProperties { get; set; }

        /// <summary>
        /// Sku的数量串，结构如：num1,num2,num3 如：2,3
        /// </summary>
        public string SkuQuantities { get; set; }

        /// <summary>
        /// 产品的规格信息。
        /// </summary>
        public string SkuSpecIds { get; set; }

        /// <summary>
        /// 新旧程度。可选值：new(新)，second(二手)，unused(闲置)。B商家不能发布二手商品。  如果是二手商品，特定类目下属性里面必填新旧成色属性
        /// </summary>
        public string StuffStatus { get; set; }

        /// <summary>
        /// 1~4个淘宝图片空间的图片相对url列表，“,”分隔，做为商品的副图
        /// </summary>
        public string SubPicPaths { get; set; }

        /// <summary>
        /// 商品是否支持拍下减库存:1支持;2取消支持;0(默认)不更改
        /// </summary>
        public Nullable<long> SubStock { get; set; }

        /// <summary>
        /// 宝贝标题。不能超过60字符，受违禁词控制
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 发布类型。可选值:fixed(一口价),auction(拍卖)。B商家不能发布拍卖商品，而且拍卖商品是没有SKU的
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 有效期。可选值:7,14;单位:天;默认值:14
        /// </summary>
        public Nullable<long> ValidThru { get; set; }

        /// <summary>
        /// 商品的重量(商超卖家专用字段)
        /// </summary>
        public Nullable<long> Weight { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.cseller.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("after_sale_id", this.AfterSaleId);
            parameters.Add("approve_status", this.ApproveStatus);
            parameters.Add("auto_fill", this.AutoFill);
            parameters.Add("auto_repost", this.AutoRepost);
            parameters.Add("cid", this.Cid);
            parameters.Add("cod_postage_id", this.CodPostageId);
            parameters.Add("desc", this.Desc);
            parameters.Add("ems_fee", this.EmsFee);
            parameters.Add("express_fee", this.ExpressFee);
            parameters.Add("features", this.Features);
            parameters.Add("freight_payer", this.FreightPayer);
            parameters.Add("global_stock_type", this.GlobalStockType);
            parameters.Add("has_discount", this.HasDiscount);
            parameters.Add("has_invoice", this.HasInvoice);
            parameters.Add("has_showcase", this.HasShowcase);
            parameters.Add("has_warranty", this.HasWarranty);
            parameters.Add("increment", this.Increment);
            parameters.Add("inner_shop_auction_template_id", this.InnerShopAuctionTemplateId);
            parameters.Add("input_pids", this.InputPids);
            parameters.Add("input_str", this.InputStr);
            parameters.Add("is_3D", this.Is3D);
            parameters.Add("is_ex", this.IsEx);
            parameters.Add("is_lightning_consignment", this.IsLightningConsignment);
            parameters.Add("is_taobao", this.IsTaobao);
            parameters.Add("is_xinpin", this.IsXinpin);
            parameters.Add("item_size", this.ItemSize);
            parameters.Add("item_spec_prop", this.ItemSpecProp);
            parameters.Add("item_weight", this.ItemWeight);
            parameters.Add("lang", this.Lang);
            parameters.Add("list_time", this.ListTime);
            parameters.Add("locality_life.choose_logis", this.LocalityLifeChooseLogis);
            parameters.Add("locality_life.expirydate", this.LocalityLifeExpirydate);
            parameters.Add("locality_life.merchant", this.LocalityLifeMerchant);
            parameters.Add("locality_life.network_id", this.LocalityLifeNetworkId);
            parameters.Add("locality_life.onsale_auto_refund_ratio", this.LocalityLifeOnsaleAutoRefundRatio);
            parameters.Add("locality_life.refund_ratio", this.LocalityLifeRefundRatio);
            parameters.Add("locality_life.verification", this.LocalityLifeVerification);
            parameters.Add("location.city", this.LocationCity);
            parameters.Add("location.state", this.LocationState);
            parameters.Add("num", this.Num);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("outer_shop_auction_template_id", this.OuterShopAuctionTemplateId);
            parameters.Add("pic_path", this.PicPath);
            parameters.Add("post_fee", this.PostFee);
            parameters.Add("postage_id", this.PostageId);
            parameters.Add("price", this.Price);
            parameters.Add("property_alias", this.PropertyAlias);
            parameters.Add("props", this.Props);
            parameters.Add("second_kill", this.SecondKill);
            parameters.Add("sell_promise", this.SellPromise);
            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("sku_outer_ids", this.SkuOuterIds);
            parameters.Add("sku_prices", this.SkuPrices);
            parameters.Add("sku_properties", this.SkuProperties);
            parameters.Add("sku_quantities", this.SkuQuantities);
            parameters.Add("sku_spec_ids", this.SkuSpecIds);
            parameters.Add("stuff_status", this.StuffStatus);
            parameters.Add("sub_pic_paths", this.SubPicPaths);
            parameters.Add("sub_stock", this.SubStock);
            parameters.Add("title", this.Title);
            parameters.Add("type", this.Type);
            parameters.Add("valid_thru", this.ValidThru);
            parameters.Add("weight", this.Weight);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateMinValue("cid", this.Cid, 0);
            RequestValidator.ValidateRequired("desc", this.Desc);
            RequestValidator.ValidateMaxLength("desc", this.Desc, 200000);
            RequestValidator.ValidateMaxLength("features", this.Features, 4000);
            RequestValidator.ValidateRequired("location.city", this.LocationCity);
            RequestValidator.ValidateRequired("location.state", this.LocationState);
            RequestValidator.ValidateRequired("num", this.Num);
            RequestValidator.ValidateMaxValue("num", this.Num, 999999);
            RequestValidator.ValidateMinValue("num", this.Num, 0);
            RequestValidator.ValidateRequired("price", this.Price);
            RequestValidator.ValidateMaxLength("property_alias", this.PropertyAlias, 511);
            RequestValidator.ValidateMaxListSize("seller_cids", this.SellerCids, 10);
            RequestValidator.ValidateMaxListSize("sku_prices", this.SkuPrices, 1000);
            RequestValidator.ValidateRequired("stuff_status", this.StuffStatus);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 60);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateMaxLength("type", this.Type, 100);
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
