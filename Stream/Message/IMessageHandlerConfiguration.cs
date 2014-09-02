using System;

/**
 * 处理message的工厂类的配置信息
 **/
namespace Top.Api.Stream.Message
{
    public interface IMessageHandlerConfiguration
    {
        int GetMinThreads();
        int GetMaxThreads();
        int GetQueueSize();
    }
}
