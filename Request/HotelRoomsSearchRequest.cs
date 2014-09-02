using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.rooms.search
    /// </summary>
    public class HotelRoomsSearchRequest : ITopRequest<HotelRoomsSearchResponse>
    {
        /// <summary>
        /// 酒店房间商品gid列表，多个gid用英文逗号隔开，一次不超过20个。gids，item_ids , hids，rids四项必须传一项，同时传递的情况下，作为查询条件的优先级由高到低依次为gids，item_ids , hids，rids。
        /// </summary>
        public string Gids { get; set; }

        /// <summary>
        /// 酒店hid列表，多个hid用英文逗号隔开，一次不超过5个。gids，item_ids , hids，rids四项必须传一项，同时传递的情况下，作为查询条件的优先级由高到低依次为gids，item_ids , hids，rids。
        /// </summary>
        public string Hids { get; set; }

        /// <summary>
        /// 酒店房间商品item_id列表，多个item_id用英文逗号隔开，一次不超过20个。gids，item_ids , hids，rids四项必须传一项，同时传递的情况下，作为查询条件的优先级由高到低依次为gids，item_ids , hids，rids。当item_ids参数值为-1，gids项不传值时，会返回卖家所有商品列表
        /// </summary>
        public string ItemIds { get; set; }

        /// <summary>
        /// 是否需要返回该商品的酒店信息。可选值：true，false。
        /// </summary>
        public Nullable<bool> NeedHotel { get; set; }

        /// <summary>
        /// 是否需要返回该商品的宝贝描述。可选值：true，false。
        /// </summary>
        public Nullable<bool> NeedRoomDesc { get; set; }

        /// <summary>
        /// 是否需要返回该商品的房态列表。可选值：true，false。
        /// </summary>
        public Nullable<bool> NeedRoomQuotas { get; set; }

        /// <summary>
        /// 是否需要返回该商品的房型信息。可选值：true，false。
        /// </summary>
        public Nullable<bool> NeedRoomType { get; set; }

        /// <summary>
        /// 分页页码。取值范围，大于零的整数，默认值1，即返回第一页的数据。页面大小为20
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 房型rid列表，多个rid用英文逗号隔开，一次不超过20个。gids，item_ids , hids，rids四项必须传一项，同时传递的情况下，作为查询条件的优先级由高到低依次为gids，item_ids , hids，rids。
        /// </summary>
        public string Rids { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.rooms.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("gids", this.Gids);
            parameters.Add("hids", this.Hids);
            parameters.Add("item_ids", this.ItemIds);
            parameters.Add("need_hotel", this.NeedHotel);
            parameters.Add("need_room_desc", this.NeedRoomDesc);
            parameters.Add("need_room_quotas", this.NeedRoomQuotas);
            parameters.Add("need_room_type", this.NeedRoomType);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("rids", this.Rids);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
