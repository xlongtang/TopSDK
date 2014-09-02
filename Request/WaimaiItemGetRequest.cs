using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.waimai.item.get
    /// </summary>
    public class WaimaiItemGetRequest : ITopRequest<WaimaiItemGetResponse>
    {
        /// <summary>
        /// 只返回对应的字段信息，可输入(itemid,title,price,oriprice,goods_no,auction_status,quantity,auction_desc,pic_url,category_id,limit_buy,viceImage,sku,recommend,create_time,modify_time)，多个以英文逗号分隔
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 外卖宝贝数字id
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.waimai.item.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("item_id", this.ItemId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
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
