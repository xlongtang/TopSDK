using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.items.inventory.get
    /// </summary>
    public class ItemsInventoryGetRequest : ITopRequest<ItemsInventoryGetResponse>
    {
        /// <summary>
        /// 分类字段。可选值:  regular_shelved(定时上架)<br> never_on_shelf(从未上架)<br> off_shelf(我下架的)<br> for_shelved(等待所有上架)<br>  sold_out(全部卖完)<br> violation_off_shelf(违规下架的)<br> 默认查询的是for_shelved(等待所有上架)这个状态的商品<br> <font color='red'>注：for_shelved(等待所有上架)=regular_shelved(定时上架)+never_on_shelf(从未上架)+off_shelf(我下架的)</font>
        /// </summary>
        public string Banner { get; set; }

        /// <summary>
        /// 商品类目ID。ItemCat中的cid字段。可以通过taobao.itemcats.get取到
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 商品结束修改时间
        /// </summary>
        public Nullable<DateTime> EndModified { get; set; }

        /// <summary>
        /// 需返回的字段列表。可选值：Item商品结构体中的以下字段：  approve_status,num_iid,title,nick,type,cid,pic_url,num,props,valid_thru,   list_time,price,has_discount,has_invoice,has_warranty,has_showcase,   modified,delist_time,postage_id,seller_cids,outer_id；字段之间用“,”分隔。   不支持其他字段，如果需要获取其他字段数据，调用taobao.item.get。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 是否参与会员折扣。可选值：true，false。默认不过滤该条件
        /// </summary>
        public Nullable<bool> HasDiscount { get; set; }

        /// <summary>
        /// 商品是否在外部网店显示
        /// </summary>
        public Nullable<bool> IsEx { get; set; }

        /// <summary>
        /// 商品是否在淘宝显示
        /// </summary>
        public Nullable<bool> IsTaobao { get; set; }

        /// <summary>
        /// 排序方式。格式为column:asc/desc ，column可选值:list_time(上架时间),delist_time(下架时间),num(商品数量)，modified(最近修改时间);默认上架时间降序(即最新上架排在前面)。如按照上架时间降序排序方式为list_time:desc
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 页码。取值范围:大于零小于等于101的整数;默认值为1，即返回第一页数据。当页码超过101页时系统就会报错，故请大家在用此接口获取数据时尽可能的细化自己的搜索条件，例如根据修改时间分段获取商品。
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数。取值范围:大于零的整数;最大值：200；默认值：40。
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 搜索字段。搜索商品的title。
        /// </summary>
        public string Q { get; set; }

        /// <summary>
        /// 卖家店铺内自定义类目ID。多个之间用“,”分隔。可以根据taobao.sellercats.list.get获得.(<font color="red">注：目前最多支持32个ID号传入</font>)
        /// </summary>
        public string SellerCids { get; set; }

        /// <summary>
        /// 商品起始修改时间
        /// </summary>
        public Nullable<DateTime> StartModified { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.items.inventory.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("banner", this.Banner);
            parameters.Add("cid", this.Cid);
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("fields", this.Fields);
            parameters.Add("has_discount", this.HasDiscount);
            parameters.Add("is_ex", this.IsEx);
            parameters.Add("is_taobao", this.IsTaobao);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("q", this.Q);
            parameters.Add("seller_cids", this.SellerCids);
            parameters.Add("start_modified", this.StartModified);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("cid", this.Cid, 0);
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateMaxValue("page_no", this.PageNo, 101);
            RequestValidator.ValidateMaxListSize("seller_cids", this.SellerCids, 32);
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
