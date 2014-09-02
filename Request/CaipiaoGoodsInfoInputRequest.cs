using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.caipiao.goods.info.input
    /// </summary>
    public class CaipiaoGoodsInfoInputRequest : ITopRequest<CaipiaoGoodsInfoInputResponse>
    {
        /// <summary>
        /// 活动结束时间，格式需严格遵守yyyy-MM-dd HH:mm:ss，不可为空
        /// </summary>
        public string ActEndDate { get; set; }

        /// <summary>
        /// 活动开始时间，格式需严格遵守yyyy-MM-dd HH:mm:ss，不可为空
        /// </summary>
        public string ActStartDate { get; set; }

        /// <summary>
        /// 店铺相关商品参加的送彩票活动描述
        /// </summary>
        public string GoodsDesc { get; set; }

        /// <summary>
        /// 商品在淘宝的唯一id，不可为空
        /// </summary>
        public Nullable<long> GoodsId { get; set; }

        /// <summary>
        /// 商品主图地址
        /// </summary>
        public string GoodsImage { get; set; }

        /// <summary>
        /// 商品价格,保留两位小数，不可为空
        /// </summary>
        public string GoodsPrice { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string GoodsTitle { get; set; }

        /// <summary>
        /// 商品类目编号，不可为空
        /// </summary>
        public Nullable<long> GoodsType { get; set; }

        /// <summary>
        /// 彩种id,不可为空
        /// </summary>
        public Nullable<long> LotteryTypeId { get; set; }

        /// <summary>
        /// 赠送类型：0-满就送；1-好评送；2-分享送；3-游戏送；4-收藏送，不可为空
        /// </summary>
        public Nullable<long> PresentType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.caipiao.goods.info.input";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("act_end_date", this.ActEndDate);
            parameters.Add("act_start_date", this.ActStartDate);
            parameters.Add("goods_desc", this.GoodsDesc);
            parameters.Add("goods_id", this.GoodsId);
            parameters.Add("goods_image", this.GoodsImage);
            parameters.Add("goods_price", this.GoodsPrice);
            parameters.Add("goods_title", this.GoodsTitle);
            parameters.Add("goods_type", this.GoodsType);
            parameters.Add("lottery_type_id", this.LotteryTypeId);
            parameters.Add("present_type", this.PresentType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("act_end_date", this.ActEndDate);
            RequestValidator.ValidateRequired("act_start_date", this.ActStartDate);
            RequestValidator.ValidateRequired("goods_id", this.GoodsId);
            RequestValidator.ValidateRequired("goods_price", this.GoodsPrice);
            RequestValidator.ValidateRequired("goods_type", this.GoodsType);
            RequestValidator.ValidateRequired("lottery_type_id", this.LotteryTypeId);
            RequestValidator.ValidateRequired("present_type", this.PresentType);
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
