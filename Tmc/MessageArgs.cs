using System;

namespace Top.Tmc
{
    public class MessageArgs : EventArgs
    {
        protected internal bool _isFail;
        protected internal string _reason;

        /// <summary>获取消息
        /// </summary>
        public Message Message { get; private set; }

        public MessageArgs(Message message)
        {
            this.Message = message;
        }
        /// <summary>将当前消息处理设置为失败，若该消息启用了重试，失败的消息将会再指定时间内重新发送
        /// </summary>
        public void Fail()
        {
            this.Fail(string.Empty);
        }
        /// <summary>将当前消息处理设置为失败，若该消息启用了重试，失败的消息将会再指定时间内重新发送
        /// <param name="reason">指定失败原因</param>
        /// </summary>
        public void Fail(string reason)
        {
            this._reason = reason;
            this._isFail = true;
        }
    }
}