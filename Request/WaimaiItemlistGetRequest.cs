using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.waimai.itemlist.get
    /// </summary>
    public class WaimaiItemlistGetRequest : ITopRequest<WaimaiItemlistGetResponse>
    {
        /// <summary>
        /// 外卖前台类目id<br /> 支持的最大列表长度为：11
        /// </summary>
        public Nullable<long> CategoryId { get; set; }

        /// <summary>
        /// 商品截止修改时间格式如(2013-10-25 00:00：00)
        /// </summary>
        public string EndModified { get; set; }

        /// <summary>
        /// 只返回对应的字段信息，可输入(itemid,title,price,oriprice,goods_no,auction_status,quantity,auction_desc,pic_url,category_id,limit_buy,viceImage,sku,recommend,create_time,modify_time)，多个以英文逗号分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 外卖宝贝标题关键字
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 格式为column:asc/desc ，column可选值:modify_time(修改时间),price(宝贝价格); 默认修改降序(即最新上架及修改的排在前面)。如按照上架时间降序排序方式为modify_time:desc
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 查询菜品的页码。1则为第一页<br /> 支持最大值为：500<br /> 支持最小值为：1<br /> 支持的最大列表长度为：3
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每一次查询返回的条数<br /> 支持最大值为：500<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 出售中宝贝1,仓库中宝贝2,所有宝贝0<br /> 支持最大值为：2<br /> 支持最小值为：0<br /> 支持的最大列表长度为：1
        /// </summary>
        public Nullable<long> SalesStatus { get; set; }

        /// <summary>
        /// 外卖数字型店铺id<br /> 支持的最大列表长度为：9
        /// </summary>
        public Nullable<long> Shopid { get; set; }

        /// <summary>
        /// 商品起始的修改时间格式如(2013-10-22 00:00：00)
        /// </summary>
        public string StartModified { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.waimai.itemlist.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_id", this.CategoryId);
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("fields", this.Fields);
            parameters.Add("keyword", this.Keyword);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("sales_status", this.SalesStatus);
            parameters.Add("shopid", this.Shopid);
            parameters.Add("start_modified", this.StartModified);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateMaxValue("page_no", this.PageNo, 500);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 500);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateRequired("sales_status", this.SalesStatus);
            RequestValidator.ValidateMaxValue("sales_status", this.SalesStatus, 2);
            RequestValidator.ValidateMinValue("sales_status", this.SalesStatus, 0);
            RequestValidator.ValidateRequired("shopid", this.Shopid);
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
