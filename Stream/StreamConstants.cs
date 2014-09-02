using System;

namespace Top.Api.Stream
{
    public class StreamConstants
    {
        public const string ERR_MSG_HEADER = "errmsg";
        public const string PARAM_APPKEY = "app_key";
        public const string PARAM_USERID = "user";
        public const string PARAM_CONNECT_ID = "id";
        public const string PARAM_TIMESTAMP = "timestamp";
        public const string PARAM_SIGN = "sign";

        //code
        public const string CONNECT_SUCCESS = "200";//连接成功的code
        public const string HEAT_BEAT = "201";//心跳
        public const string NEW_MESSAGE = "202";//消息
        public const string DISCARD_MESSAGE = "203";//当客户端断开连接后，服务端会记录下来丢弃消息的开始时间
        public const string CONNECT_REACH_MAX_TIME = "101";//连接到达最大时间，服务端主动断开
        public const string SERVER_DEPLOY = "102";//服务端在发布
        public const string SERVER_REHASH = "103";//服务端负载不均衡了，断开所有的客户端重连
        public const string CLIENT_KICKOFF = "104";//对于重复的连接，服务端用新的连接替换掉旧的连接
        public const string SERVER_KICKOFF = "105";//由于消息量太大，而isv接收的速度太慢，服务端断开isv的连接

        public const string RECONNECT = "500";//客户端主动重连,或者出现了异常需要重连
        public const string CLIENT_FIRST_CONNECT = "501";//客户端第一次发起连接
    }
}