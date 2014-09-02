using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.room.add
    /// </summary>
    public class HotelRoomAddRequest : ITopUploadRequest<HotelRoomAddResponse>
    {
        /// <summary>
        /// 面积。可选值：A,B,C,D。分别代表：  A：15平米以下，B：16－30平米，C：31－50平米，D：50平米以上<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 宽带服务。A,B,C,D。分别代表：  A：无宽带，B：免费宽带，C：收费宽带，D：部分收费宽带<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string Bbn { get; set; }

        /// <summary>
        /// 床型。可选值：A,B,C,D,E,F,G,H,I。分别代表：A：单人床，B：大床，C：双床，D：双床/大床，E：子母床，F：上下床，G：圆形床，H：多床，I：其他床型<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string BedType { get; set; }

        /// <summary>
        /// 早餐。A,B,C,D,E。分别代表：  A：无早，B：单早，C：双早，D：三早，E：多早<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string Breakfast { get; set; }

        /// <summary>
        /// 订金。0～99999900的正整数。在payment_type为订金时必须输入，存储的单位是分。不能带角分。<br /> 支持最大值为：99999900<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> Deposit { get; set; }

        /// <summary>
        /// 商品描述。不能超过25000个汉字（50000个字符）。<br /> 支持最大长度为：50000<br /> 支持的最大列表长度为：50000
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 手续费。0～99999900的正整数。在payment_type为手续费或手续费/间夜时必须输入，存储的单位是分。不能带角分。<br /> 支持最大值为：99999900<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> Fee { get; set; }

        /// <summary>
        /// 购买须知。不能超过300个字。<br /> 支持最大长度为：300<br /> 支持的最大列表长度为：300
        /// </summary>
        public string Guide { get; set; }

        /// <summary>
        /// 酒店商品是否提供发票
        /// </summary>
        public Nullable<bool> HasReceipt { get; set; }

        /// <summary>
        /// 酒店id。必须为数字。
        /// </summary>
        public Nullable<long> Hid { get; set; }

        /// <summary>
        /// 为到店支付卖家特殊使用，代表多种支付类型的房态。room_quotas可选，如果有值，也会处理。
        /// </summary>
        public string MultiRoomQuotas { get; set; }

        /// <summary>
        /// 支付类型。可选值：A,B,C,D,E。分别代表：  A：全额支付，B：手续费，C：订金，D：手续费/间夜，E：前台面付<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// 酒店商品图片。类型:JPG,GIF;最大长度:500K。支持的文件类型：gif,jpg,jpeg,png。发布的时候只能发布一张图片。如需再发图片，需要调用商品图片上传接口，1个商品最多5张图片。<br /> 支持的文件类型为：jpg,png,gif<br /> 支持的最大列表长度为：512000
        /// </summary>
        public FileItem Pic { get; set; }

        /// <summary>
        /// 商品主图需要关联的图片空间的相对url。这个url所对应的图片必须要属于当前用户。pic_path和image只需要传入一个,如果两个都传，默认选择pic_path
        /// </summary>
        public string PicPath { get; set; }

        /// <summary>
        /// 价格类型。可选值：A,B。分别代表：A：参考预订价，B实时预订价 。未选该参数默认为参考预订价。选择实时预订价的情况下，支付类型必须选择为A(全额支付)<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string PriceType { get; set; }

        /// <summary>
        /// 发票说明，不能超过100个汉字,200个字符。
        /// </summary>
        public string ReceiptInfo { get; set; }

        /// <summary>
        /// 发票类型为其他时的发票描述,不能超过30个汉字，60个字符。
        /// </summary>
        public string ReceiptOtherTypeDesc { get; set; }

        /// <summary>
        /// 发票类型。A,B。分别代表： A:酒店住宿发票,B:其他
        /// </summary>
        public string ReceiptType { get; set; }

        /// <summary>
        /// 1. 全额支付类型必填  2. t代表类别(1表示任意退;2表示不能退;3表示阶梯退)，p代表退款规则（数组）， d代表天数，r代表扣除手续费比率。示例代表的意思就是"阶梯退:提前3天内退订，收取订单总额10%的违约金;提前2天内退订，收取订单总额20%的违约金，提前1天内退订，收取订单总额30%的违约金"。  3. 任意退、不能退不能指定退款规则;阶梯退不能没有退款规则;阶梯退规则最多10条,且每条规则天数、费率不能相同;阶梯退遵循天数越短,违约金越大的业务规则;天数需为整数,且90>天数>=0;费率需为整数且100<=费率<=0;阶梯退规则只有一条时,费率不能设置为100%;阶梯退规则只有一条时,不能设定0天收取0%;
        /// </summary>
        public string RefundPolicyInfo { get; set; }

        /// <summary>
        /// 房型id。必须为数字。
        /// </summary>
        public Nullable<long> Rid { get; set; }

        /// <summary>
        /// 房态信息。可以传今天开始90天内的房态信息。日期必须连续。JSON格式传递。  date：代表房态日期，格式为YYYY-MM-DD，  price：代表当天房价，0～99999999，存储的单位是分，  num：代表当天可售间数，0～999。  如：  [{"date":2011-01-28,"price":10000, "num":10},{"date":2011-01-29,"price":12000,"num":10}]
        /// </summary>
        public string RoomQuotas { get; set; }

        /// <summary>
        /// 设施服务。JSON格式。  value值true有此服务，false没有。  bar：吧台，catv：有线电视，ddd：国内长途电话，idd：国际长途电话，toilet：独立卫生间，pubtoliet：公共卫生间。  如：  {"bar":false,"catv":false,"ddd":false,"idd":false,"pubtoilet":false,"toilet":false}
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// 接入卖家数据主键<br /> 支持最大长度为：100<br /> 支持的最大列表长度为：100
        /// </summary>
        public string SiteParam { get; set; }

        /// <summary>
        /// 床宽。可选值：A,B,C,D,E,F,G,H。分别代表：A：1米及以下，B：1.1米，C：1.2米，D：1.35米，E：1.5米，F：1.8米，G：2米，H：2.2米及以上<br /> 支持最大长度为：1<br /> 支持的最大列表长度为：1
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 楼层。长度不超过8<br /> 支持最大长度为：8<br /> 支持的最大列表长度为：8
        /// </summary>
        public string Storey { get; set; }

        /// <summary>
        /// 酒店商品名称。不能超过60字节<br /> 支持最大长度为：90<br /> 支持的最大列表长度为：90
        /// </summary>
        public string Title { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.room.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("area", this.Area);
            parameters.Add("bbn", this.Bbn);
            parameters.Add("bed_type", this.BedType);
            parameters.Add("breakfast", this.Breakfast);
            parameters.Add("deposit", this.Deposit);
            parameters.Add("desc", this.Desc);
            parameters.Add("fee", this.Fee);
            parameters.Add("guide", this.Guide);
            parameters.Add("has_receipt", this.HasReceipt);
            parameters.Add("hid", this.Hid);
            parameters.Add("multi_room_quotas", this.MultiRoomQuotas);
            parameters.Add("payment_type", this.PaymentType);
            parameters.Add("pic_path", this.PicPath);
            parameters.Add("price_type", this.PriceType);
            parameters.Add("receipt_info", this.ReceiptInfo);
            parameters.Add("receipt_other_type_desc", this.ReceiptOtherTypeDesc);
            parameters.Add("receipt_type", this.ReceiptType);
            parameters.Add("refund_policy_info", this.RefundPolicyInfo);
            parameters.Add("rid", this.Rid);
            parameters.Add("room_quotas", this.RoomQuotas);
            parameters.Add("service", this.Service);
            parameters.Add("site_param", this.SiteParam);
            parameters.Add("size", this.Size);
            parameters.Add("storey", this.Storey);
            parameters.Add("title", this.Title);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("area", this.Area, 1);
            RequestValidator.ValidateMaxLength("bbn", this.Bbn, 1);
            RequestValidator.ValidateRequired("bed_type", this.BedType);
            RequestValidator.ValidateMaxLength("bed_type", this.BedType, 1);
            RequestValidator.ValidateRequired("breakfast", this.Breakfast);
            RequestValidator.ValidateMaxLength("breakfast", this.Breakfast, 1);
            RequestValidator.ValidateMaxValue("deposit", this.Deposit, 99999900);
            RequestValidator.ValidateMinValue("deposit", this.Deposit, 0);
            RequestValidator.ValidateRequired("desc", this.Desc);
            RequestValidator.ValidateMaxLength("desc", this.Desc, 50000);
            RequestValidator.ValidateMaxValue("fee", this.Fee, 99999900);
            RequestValidator.ValidateMinValue("fee", this.Fee, 0);
            RequestValidator.ValidateMaxLength("guide", this.Guide, 300);
            RequestValidator.ValidateRequired("hid", this.Hid);
            RequestValidator.ValidateRequired("payment_type", this.PaymentType);
            RequestValidator.ValidateMaxLength("payment_type", this.PaymentType, 1);
            RequestValidator.ValidateMaxLength("pic", this.Pic, 512000);
            RequestValidator.ValidateMaxLength("price_type", this.PriceType, 1);
            RequestValidator.ValidateRequired("rid", this.Rid);
            RequestValidator.ValidateMaxLength("site_param", this.SiteParam, 100);
            RequestValidator.ValidateMaxLength("size", this.Size, 1);
            RequestValidator.ValidateMaxLength("storey", this.Storey, 8);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 90);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("pic", this.Pic);
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
