using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.products.get
    /// </summary>
    public class FenxiaoProductsGetRequest : ITopRequest<FenxiaoProductsGetResponse>
    {
        /// <summary>
        /// 结束修改时间
        /// </summary>
        public Nullable<DateTime> EndModified { get; set; }

        /// <summary>
        /// 指定查询额外的信息，可选值：skus（sku数据）、images（多图），多个可选值用逗号分割。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 查询产品列表时，查询入参“是否需要授权”  yes:需要授权   no:不需要授权
        /// </summary>
        public string IsAuthz { get; set; }

        /// <summary>
        /// 可根据导入的商品ID列表查询，优先级次于产品ID、sku_numbers，高于其他分页查询条件。最大限制20，用逗号分割，例如：“1001,1002,1003,1004,1005”
        /// </summary>
        public string ItemIds { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 页码（大于0的整数，默认1）
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页记录数（默认20，最大50）
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 产品ID列表（最大限制30），用逗号分割，例如：“1001,1002,1003,1004,1005”
        /// </summary>
        public string Pids { get; set; }

        /// <summary>
        /// 产品线ID
        /// </summary>
        public Nullable<long> ProductcatId { get; set; }

        /// <summary>
        /// sku商家编码
        /// </summary>
        public string SkuNumber { get; set; }

        /// <summary>
        /// 开始修改时间
        /// </summary>
        public Nullable<DateTime> StartModified { get; set; }

        /// <summary>
        /// 产品状态，可选值：up（上架）、down（下架），不传默认查询所有
        /// </summary>
        public string Status { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.products.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("fields", this.Fields);
            parameters.Add("is_authz", this.IsAuthz);
            parameters.Add("item_ids", this.ItemIds);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("pids", this.Pids);
            parameters.Add("productcat_id", this.ProductcatId);
            parameters.Add("sku_number", this.SkuNumber);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("status", this.Status);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("item_ids", this.ItemIds, 20);
            RequestValidator.ValidateMaxListSize("pids", this.Pids, 30);
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
