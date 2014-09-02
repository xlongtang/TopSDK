using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hotel.room.quotas.query.feedback
    /// </summary>
    public class HotelRoomQuotasQueryFeedbackRequest : ITopRequest<HotelRoomQuotasQueryFeedbackResponse>
    {
        /// <summary>
        /// 选中日期范围内的最大可用房量
        /// </summary>
        public Nullable<long> AvaliableRoomCount { get; set; }

        /// <summary>
        /// 入住酒店的日期
        /// </summary>
        public Nullable<DateTime> CheckinDate { get; set; }

        /// <summary>
        /// 离开酒店的日期
        /// </summary>
        public Nullable<DateTime> CheckoutDate { get; set; }

        /// <summary>
        /// 失败原因,当result为F时,此项为必填,最长200个字符
        /// </summary>
        public string FailedReason { get; set; }

        /// <summary>
        /// 指令消息中的messageid,最长128字符
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// 预订结果   S:成功  F:失败
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 从入住时期到离店日期的每日一间房价与预定房量,JSON格式传递。 date：代表房态日期，格式为YYYY-MM-DD， price：代表当天房价，0～99999900，存储的单位是分，货币单位为人民币，num：代表当天剩余房量，0～999，所有日期的预订间数应该一致。 如： [{"date":2011-01-28,"price":10000, "num":10},{"date":2011-01-29,"price":12000,"num":10}],最长1500个字符
        /// </summary>
        public string RoomQuotas { get; set; }

        /// <summary>
        /// 订单总价。0～99999999的正整数。货币单位为人民币。
        /// </summary>
        public Nullable<long> TotalRoomPrice { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hotel.room.quotas.query.feedback";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("avaliable_room_count", this.AvaliableRoomCount);
            parameters.Add("checkin_date", this.CheckinDate);
            parameters.Add("checkout_date", this.CheckoutDate);
            parameters.Add("failed_reason", this.FailedReason);
            parameters.Add("message_id", this.MessageId);
            parameters.Add("result", this.Result);
            parameters.Add("room_quotas", this.RoomQuotas);
            parameters.Add("total_room_price", this.TotalRoomPrice);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("avaliable_room_count", this.AvaliableRoomCount);
            RequestValidator.ValidateMinValue("avaliable_room_count", this.AvaliableRoomCount, 0);
            RequestValidator.ValidateRequired("checkin_date", this.CheckinDate);
            RequestValidator.ValidateRequired("checkout_date", this.CheckoutDate);
            RequestValidator.ValidateRequired("message_id", this.MessageId);
            RequestValidator.ValidateRequired("result", this.Result);
            RequestValidator.ValidateRequired("total_room_price", this.TotalRoomPrice);
            RequestValidator.ValidateMaxValue("total_room_price", this.TotalRoomPrice, 99999999);
            RequestValidator.ValidateMinValue("total_room_price", this.TotalRoomPrice, 0);
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
