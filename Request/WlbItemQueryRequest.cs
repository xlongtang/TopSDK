using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.item.query
    /// </summary>
    public class WlbItemQueryRequest : ITopRequest<WlbItemQueryResponse>
    {
        /// <summary>
        /// 是否是最小库存单元，只有最小库存单元的商品才可以有库存,值只能给"true","false"来表示;  若值不在范围内，则按true处理
        /// </summary>
        public string IsSku { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// ITEM类型(只允许输入以下英文或空)  NORMAL  0:普通商品;   COMBINE  1:是否是组合商品   DISTRIBUTION  2:是否是分销商品(货主是别人)  若值不在范围内，则按NORMAL处理
        /// </summary>
        public string ItemType { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 分页记录个数，如果用户输入的记录数大于50，则一页显示50条记录
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 父ID,只有is_sku=1时才能有父ID，商品也可以没有付商品
        /// </summary>
        public Nullable<long> ParentId { get; set; }

        /// <summary>
        /// 只能输入以下值或空：  ITEM_STATUS_VALID -- 1 表示 有效；  ITEM_STATUS_LOCK  -- 2 表示锁住。  若值不在范围内，按ITEM_STATUS_VALID处理
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 商品前台销售名字
        /// </summary>
        public string Title { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.item.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_sku", this.IsSku);
            parameters.Add("item_code", this.ItemCode);
            parameters.Add("item_type", this.ItemType);
            parameters.Add("name", this.Name);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("parent_id", this.ParentId);
            parameters.Add("status", this.Status);
            parameters.Add("title", this.Title);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("item_code", this.ItemCode, 64);
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 50);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateMaxLength("title", this.Title, 255);
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
