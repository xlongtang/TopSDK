using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.vas.order.search
    /// </summary>
    public class VasOrderSearchRequest : ITopRequest<VasOrderSearchResponse>
    {
        /// <summary>
        /// 应用收费代码，从合作伙伴后台（my.open.taobao.com）-收费管理-收费项目列表 能够获得该应用的收费代码
        /// </summary>
        public string ArticleCode { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public Nullable<long> BizOrderId { get; set; }

        /// <summary>
        /// 订单类型，1=新订 2=续订 3=升级 4=后台赠送 5=后台自动续订 6=订单审核后生成订购关系（暂时用不到） 空=全部
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 订单创建时间（订购时间）结束值
        /// </summary>
        public Nullable<DateTime> EndCreated { get; set; }

        /// <summary>
        /// 收费项目代码，从合作伙伴后台（my.open.taobao.com）-收费管理-收费项目列表 能够获得收费项目代码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 淘宝会员名
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 一页包含的记录数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 订单创建时间（订购时间）起始值（当start_created和end_created都不填写时，默认返回最近90天的数据）
        /// </summary>
        public Nullable<DateTime> StartCreated { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.vas.order.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("article_code", this.ArticleCode);
            parameters.Add("biz_order_id", this.BizOrderId);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("item_code", this.ItemCode);
            parameters.Add("nick", this.Nick);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_created", this.StartCreated);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("article_code", this.ArticleCode);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 200);
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
