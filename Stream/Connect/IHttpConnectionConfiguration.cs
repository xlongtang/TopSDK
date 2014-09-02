using System.Collections.Generic;

/**
 * 建立http connection需要的一些配置
 **/
namespace Top.Api.Stream.Connect
{
    public interface IHttpConnectionConfiguration
    {
        string GetConnectUrl();
        /**
         * 连接超时时间
         */
        int GetHttpConnectionTimeout();
        /**
         * http读取数据超时时间
         */
        int GetHttpReadTimeout();
        /**
         * 连接重试次数
         */
        int GetHttpConnectRetryCount();
        /**
         * 重试间隔的时间
         */
        int GetHttpConnectRetryInterval();
        /**
         * 返回服务端在升级的时候的休眠时间
         */
        int GetSleepTimeOfServerInUpgrade();
        /**
         * 对于一个连接重连间隔的时间
         */
        int GetHttpReconnectInterval();

        IDictionary<string, string> GetRequestHeader();
    }
}
