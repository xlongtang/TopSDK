using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// User Data Structure.
    /// </summary>
    [Serializable]
    public class User : TopObject
    {
        /// <summary>
        /// 有无绑定。可选值:bind(绑定),notbind(未绑定)
        /// </summary>
        [XmlElement("alipay_bind")]
        public string AlipayBind { get; set; }

        /// <summary>
        /// 是否受限制。可选值:limited(受限制),unlimited(不受限)
        /// </summary>
        [XmlElement("auto_repost")]
        public string AutoRepost { get; set; }

        /// <summary>
        /// 用户头像地址
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 买家信用
        /// </summary>
        [XmlElement("buyer_credit")]
        public UserCredit BuyerCredit { get; set; }

        /// <summary>
        /// 是否参加消保
        /// </summary>
        [XmlElement("consumer_protection")]
        public bool ConsumerProtection { get; set; }

        /// <summary>
        /// 用户注册时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 联系人email
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 是否购买多图服务。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("has_more_pic")]
        public bool HasMorePic { get; set; }

        /// <summary>
        /// 用户作为卖家是否开过店
        /// </summary>
        [XmlElement("has_shop")]
        public bool HasShop { get; set; }

        /// <summary>
        /// 表示用户是否具备修改商品减库存逻辑的权限（一共有拍下减库存和付款减库存两种逻辑）  值含义：  1）true：是  2）false：否。
        /// </summary>
        [XmlElement("has_sub_stock")]
        public bool HasSubStock { get; set; }

        /// <summary>
        /// 用户是否是金牌卖家
        /// </summary>
        [XmlElement("is_golden_seller")]
        public bool IsGoldenSeller { get; set; }

        /// <summary>
        /// 是否24小时闪电发货(实物类)
        /// </summary>
        [XmlElement("is_lightning_consignment")]
        public bool IsLightningConsignment { get; set; }

        /// <summary>
        /// 可上传商品图片数量
        /// </summary>
        [XmlElement("item_img_num")]
        public long ItemImgNum { get; set; }

        /// <summary>
        /// 单张商品图片最大容量(商品主图大小)。单位:k
        /// </summary>
        [XmlElement("item_img_size")]
        public long ItemImgSize { get; set; }

        /// <summary>
        /// 最近登陆时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("last_visit")]
        public string LastVisit { get; set; }

        /// <summary>
        /// 是否是无名良品用户，true or  false
        /// </summary>
        [XmlElement("liangpin")]
        public bool Liangpin { get; set; }

        /// <summary>
        /// 用户当前居住地公开信息。如：location.city获取其中的city数据
        /// </summary>
        [XmlElement("location")]
        public Location Location { get; set; }

        /// <summary>
        /// 是否订阅了淘宝天下杂志
        /// </summary>
        [XmlElement("magazine_subscribe")]
        public bool MagazineSubscribe { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 用户是否为网游用户，属于隐私信息，需要登陆才能查看自己的。  目前仅供taobao.user.get使用
        /// </summary>
        [XmlElement("online_gaming")]
        public bool OnlineGaming { get; set; }

        /// <summary>
        /// 有无实名认证。可选值:authentication(实名认证),not authentication(没有认证)
        /// </summary>
        [XmlElement("promoted_type")]
        public string PromotedType { get; set; }

        /// <summary>
        /// 可上传属性图片数量
        /// </summary>
        [XmlElement("prop_img_num")]
        public long PropImgNum { get; set; }

        /// <summary>
        /// 单张销售属性图片最大容量（非主图的商品图片和商品属性图片）。单位:k
        /// </summary>
        [XmlElement("prop_img_size")]
        public long PropImgSize { get; set; }

        /// <summary>
        /// 卖家信用
        /// </summary>
        [XmlElement("seller_credit")]
        public UserCredit SellerCredit { get; set; }

        /// <summary>
        /// 性别。可选值:m(男),f(女)
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 卖家是否签署食品卖家承诺协议
        /// </summary>
        [XmlElement("sign_food_seller_promise")]
        public bool SignFoodSellerPromise { get; set; }

        /// <summary>
        /// 状态。可选值:normal(正常),inactive(未激活),delete(删除),reeze(冻结),supervise(监管)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户类型。可选值:B(B商家),C(C商家)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户字符串ID
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 用户数字ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 用户参与垂直市场类型。shoes表示鞋城垂直市场用户，3C表示3C垂直市场用户。多个类型之间用","分隔。如：一个用户既是3C用户又是鞋城用户，那么这个字段返回就是"3C,shoes"。如果用户不是垂直市场用户，此字段返回为""。
        /// </summary>
        [XmlElement("vertical_market")]
        public string VerticalMarket { get; set; }

        /// <summary>
        /// 用户的全站vip信息，可取值如下：c(普通会员),asso_vip(荣誉会员)，vip1,vip2,vip3,vip4,vip5,vip6(六个等级的正式vip会员)，共8种取值，其中asso_vip是由vip会员衰退而成，与主站上的vip0对应。
        /// </summary>
        [XmlElement("vip_info")]
        public string VipInfo { get; set; }
    }
}
