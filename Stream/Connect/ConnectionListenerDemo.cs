using System;

namespace Top.Api.Stream.Connect
{
    public class ConnectionListenerDemo : IConnectionLifeCycleListener
    {
        public void OnBeforeConnect()
        {
        }

        public void OnConnect()
        {
            Console.WriteLine("Connected...");
        }

        public void OnException(Exception throwable)
        {

        }

        public void OnConnectError(Exception e)
        {

        }

        public void OnReadTimeout()
        {

        }

        public void OnMaxReadTimeoutException()
        {

        }

        public void OnSysErrorException(Exception e)
        {

        }
    }
}
