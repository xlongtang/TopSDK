using System;

/*
 * 连接的生命周期的监听器
 */
namespace Top.Api.Stream.Connect
{
    public interface IConnectionLifeCycleListener
    {
        /// <summary>
        /// 在每次发起连接请求之前，允许应用程序做一些事情
        /// </summary>
        void OnBeforeConnect();

        /// <summary>
        /// 连接成功后调用此方法
        /// </summary>
        void OnConnect();

        /// <summary>
        /// 出现异常时调用此方法
        /// </summary>
        void OnException(Exception throwable);

        /// <summary>
        /// 连接出现错误，需要检查一下原因
        /// </summary>
        void OnConnectError(Exception e);

        /// <summary>
        /// 读取超时，这个时候可能网络有问题了，需要检查一下原因
        /// </summary>
        void OnReadTimeout();

        /// <summary>
        /// 当系统在30分钟内超过10次timeout了,则调用这个方法,退出，可能网络有问题了，需要检查一下原因
        /// </summary>
        void OnMaxReadTimeoutException();

        /// <summary>
        /// 当出现系统级别，比如签名错误，丢失参数等异常时,检查HTTP的响应头ErrMsg查看具体错误原因
        /// </summary>
        void OnSysErrorException(Exception e);
    }
}
