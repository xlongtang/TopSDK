using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.waimai.shop.update
    /// </summary>
    public class WaimaiShopUpdateRequest : ITopRequest<WaimaiShopUpdateResponse>
    {
        /// <summary>
        /// 店铺地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 外卖店名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 店铺电话号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 店铺标志    注意：这里传递的图片url是通过taobao.waimai.item.pic.upload接口上传获得的
        /// </summary>
        public string PicUrl { get; set; }

        /// <summary>
        /// 店铺坐标x  注意：这里是大坐标，即是乘以100000后的值
        /// </summary>
        public Nullable<long> Posx { get; set; }

        /// <summary>
        /// 店铺坐标y  注意：这里是大坐标，即是乘以100000后的值
        /// </summary>
        public Nullable<long> Posy { get; set; }

        /// <summary>
        /// 外卖店铺id
        /// </summary>
        public Nullable<long> Shopid { get; set; }

        /// <summary>
        /// 店铺与ISV的关联关系
        /// </summary>
        public string Shopoutid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.waimai.shop.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("address", this.Address);
            parameters.Add("name", this.Name);
            parameters.Add("phone", this.Phone);
            parameters.Add("pic_url", this.PicUrl);
            parameters.Add("posx", this.Posx);
            parameters.Add("posy", this.Posy);
            parameters.Add("shopid", this.Shopid);
            parameters.Add("shopoutid", this.Shopoutid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("address", this.Address);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("phone", this.Phone);
            RequestValidator.ValidateRequired("posx", this.Posx);
            RequestValidator.ValidateRequired("posy", this.Posy);
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
