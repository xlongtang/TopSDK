using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.members.search
    /// </summary>
    public class CrmMembersSearchRequest : ITopRequest<CrmMembersSearchResponse>
    {
        /// <summary>
        /// 买家昵称<br /> 支持最大长度为：1000<br /> 支持的最大列表长度为：1000
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 城市.  请注意:该字段从2014-4-23之后不再支持作为搜索条件检索.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 显示第几页的会员，如果输入的页码大于总共的页码数，例如总共10页，但是current_page的值为11，则返回空白页，最小页数为1.最大1000页<br /> 支持最大值为：1000<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 会员等级，0：店铺客户，1：普通客户，2：高级会员，3：VIP会员, 4：至尊VIP会员<br /> 支持最大值为：4<br /> 支持最小值为：-1<br /> 支持的最大列表长度为：32
        /// </summary>
        public Nullable<long> Grade { get; set; }

        /// <summary>
        /// 分组id<br /> 支持的最大列表长度为：19
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        /// <summary>
        /// 最大平均客单价，单位为元.  请注意:该字段从2014-4-23之后不再支持作为搜索条件检索.
        /// </summary>
        public string MaxAvgPrice { get; set; }

        /// <summary>
        /// 最大交易关闭笔数.  请注意:该字段从2014-4-23之后不再支持作为搜索条件检索.<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> MaxCloseTradeNum { get; set; }

        /// <summary>
        /// 最大交易宝贝件数<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> MaxItemNum { get; set; }

        /// <summary>
        /// 最迟上次交易时间
        /// </summary>
        public Nullable<DateTime> MaxLastTradeTime { get; set; }

        /// <summary>
        /// 最大交易额，单位为元
        /// </summary>
        public string MaxTradeAmount { get; set; }

        /// <summary>
        /// 最大交易量<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> MaxTradeCount { get; set; }

        /// <summary>
        /// 最少平均客单价，单位为元.  请注意:该字段从2014-4-23之后不再支持作为搜索条件检索.
        /// </summary>
        public string MinAvgPrice { get; set; }

        /// <summary>
        /// 最小交易关闭的笔数.  请注意:该字段从2014-4-23之后不再支持作为搜索条件检索.<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> MinCloseTradeNum { get; set; }

        /// <summary>
        /// 最小交易宝贝件数<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> MinItemNum { get; set; }

        /// <summary>
        /// 最早上次交易时间
        /// </summary>
        public Nullable<DateTime> MinLastTradeTime { get; set; }

        /// <summary>
        /// 最小交易额，单位为元
        /// </summary>
        public string MinTradeAmount { get; set; }

        /// <summary>
        /// 最小交易量<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> MinTradeCount { get; set; }

        /// <summary>
        /// 每页显示的会员数量，page_size的最大值不能超过100，最小值不能小于1<br /> 支持最大值为：100<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 北京=1,天津=2,河北省=3,山西省=4,内蒙古自治区=5,辽宁省=6,吉林省=7,黑龙江省=8,上海=9,江苏省=10,浙江省=11,安徽省=12,福建省=13,江西省=14,山东省=15,河南省=16,湖北省=17,湖南省=18, 广东省=19,广西壮族自治区=20,海南省=21,重庆=22,四川省=23,贵州省=24,云南省=25,西藏自治区26,陕西省=27,甘肃省=28,青海省=29,宁夏回族自治区=30,新疆维吾尔自治区=31,台湾省=32,香港特别行政区=33,澳门特别行政区=34,海外=35.  注:请注意:从2014.4.23之后,省市将采用地区标准码,请通过物流API taobao.areas.get接口获取,参考:http://api.taobao.com/apidoc/api.htm?spm=0.0.0.0.nOOF9g&path=cid:7-apiId:59.API对于老的省市代码兼容会逐步下线.<br /> 支持最大值为：1000000<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> Province { get; set; }

        /// <summary>
        /// 关系来源，1交易成功，2未成交，3卖家手动吸纳<br /> 支持最大值为：3<br /> 支持最小值为：1<br /> 支持的最大列表长度为：32
        /// </summary>
        public Nullable<long> RelationSource { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.members.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("city", this.City);
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("grade", this.Grade);
            parameters.Add("group_id", this.GroupId);
            parameters.Add("max_avg_price", this.MaxAvgPrice);
            parameters.Add("max_close_trade_num", this.MaxCloseTradeNum);
            parameters.Add("max_item_num", this.MaxItemNum);
            parameters.Add("max_last_trade_time", this.MaxLastTradeTime);
            parameters.Add("max_trade_amount", this.MaxTradeAmount);
            parameters.Add("max_trade_count", this.MaxTradeCount);
            parameters.Add("min_avg_price", this.MinAvgPrice);
            parameters.Add("min_close_trade_num", this.MinCloseTradeNum);
            parameters.Add("min_item_num", this.MinItemNum);
            parameters.Add("min_last_trade_time", this.MinLastTradeTime);
            parameters.Add("min_trade_amount", this.MinTradeAmount);
            parameters.Add("min_trade_count", this.MinTradeCount);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("province", this.Province);
            parameters.Add("relation_source", this.RelationSource);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("buyer_nick", this.BuyerNick, 1000);
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
            RequestValidator.ValidateMaxValue("current_page", this.CurrentPage, 1000);
            RequestValidator.ValidateMinValue("current_page", this.CurrentPage, 1);
            RequestValidator.ValidateMaxValue("grade", this.Grade, 4);
            RequestValidator.ValidateMinValue("grade", this.Grade, -1);
            RequestValidator.ValidateMinValue("max_close_trade_num", this.MaxCloseTradeNum, 0);
            RequestValidator.ValidateMinValue("max_item_num", this.MaxItemNum, 0);
            RequestValidator.ValidateMinValue("max_trade_count", this.MaxTradeCount, 0);
            RequestValidator.ValidateMinValue("min_close_trade_num", this.MinCloseTradeNum, 0);
            RequestValidator.ValidateMinValue("min_item_num", this.MinItemNum, 0);
            RequestValidator.ValidateMinValue("min_trade_count", this.MinTradeCount, 0);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateMaxValue("province", this.Province, 1000000);
            RequestValidator.ValidateMinValue("province", this.Province, 1);
            RequestValidator.ValidateMaxValue("relation_source", this.RelationSource, 3);
            RequestValidator.ValidateMinValue("relation_source", this.RelationSource, 1);
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
