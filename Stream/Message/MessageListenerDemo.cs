using System;

namespace Top.Api.Stream.Message
{
    public class MessageListenerDemo : ITopCometMessageListener
    {
        /**
        * 服务端：当客户端的连接被接收后，服务端返回连接成功的消息<br/>
        * 客户端：客户端不需要对此消息做任何处理
        * @param message
        */
        public void OnConnectMsg(string message)
        {
            Console.WriteLine(DateTime.Now.ToString() + ":Connected..." + message);
        }

        /**
        * 服务端：服务端会在每隔一段时间发送一个心跳包（如果一直有业务消息，则不会发送此心跳包）<br/>
        * 客户端：不需要做任何处理，需要注意如果在一段时间内没有心跳包收到的话说明底层链路有问题了。
        */
        public void OnHeartBeat()
        {
            Console.WriteLine(DateTime.Now.ToString() + ":HeartBeat...");
        }

        /**
        * 服务端：发送业务消息<br/>
        * 客户端：接收到业务消息。<br/>
        * 建议：建议客户端收到消息后，把消息放到一个消息池里面，异步处理消息，以免影响正常的消息接收
        * @param message
        */
        public void OnReceiveMsg(string message)
        {
            Console.WriteLine(DateTime.Now.ToString() + ":ReceiveMsg:" + message);
        }

        /**
        * 服务端：连接到达最大时间后，把客户端连接断开<br/>
        * 客户端：连接断开，sdk会在这种情况下会重新连接，不需要对这个方法做任何处理。
        */
        public void OnConnectReachMaxTime()
        {
        }

        /**
        * 服务端：服务端告知客户端丢弃消息的时间段。<br/>
        * 客户端：当收到这个消息后，异步调用taobao.comet.discardinfo.get api查询哪些用户的消息丢弃了。
        *         接下来通过增量api补完整这些丢弃的消息。
        * @param message
        */
        public void OnDiscardMsg(string message)
        {
        }

        /**
        * 服务端：服务端在升级<br/>
        * 客户端：sdk会在发布期间休眠一段时间，自动重连。<br/>
        * 建议：由于服务端在发布的时候消息会丢弃，所以客户端在收到这个消息后，在连接正常之前
        *       异步调用taobao.comet.discardinfo.get api查询哪些用户的消息丢弃了。
        *       接下来通过增量api补完整这些丢弃的消息。
        * @param message 包括了服务端升级需要的时间
        */
        public void OnServerUpgrade(string message)
        {
        }

        /**
        * 服务端：服务端负责不均衡，断开所有客户端连接<br/>
        * 客户端：sdk会马上重连<br/>
        * 建议：由于服务端在这个时候可能有消息会丢弃，所以客户端在收到这个消息后，
        *       异步调用taobao.comet.discardinfo.get api查询哪些用户的消息丢弃了。
        *       接下来通过增量api补完整这些丢弃的消息。
        */
        public void OnServerRehash()
        {
        }

        /**
        * 服务端：消息量太大，isv接收太慢，服务端主动断开客户端<br/>
        * 客户端：sdk不会重连，会停掉系统。<br/>
        * 建议：1，首先把处理消息做成异步，让接收消息线程马上返回。<br/>
        *       2，可以考虑使用多连接。
        */
        public void OnServerKickOff()
        {
        }

        /**
        * 服务端：由于客户端使用相同的参数发起了另外一个请求，服务端把前一个连接断开<br/>
        * 客户端：1，可能是sdk自动发起重连，打印一条信息。这种情况不需要做任何处理。<br/>
        *         2，可能是相同的appkey在其他地方发起了连接请求，需要检查一下相同的appkey是否有在其他地方被使用。
        */
        public void OnClientKickOff()
        {
        }

        /**
        * sdk的错误或者服务端增加了消息类型，但是sdk没有来得及升级。
        * 建议升级一下sdk
        * @param message
        */
        public void OnOtherMsg(string message)
        {
        }

        /**
        * 其他异常信息
        */
        public void OnException(Exception ex)
        {
        }
    }
}
