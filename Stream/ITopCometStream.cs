using Top.Api.Stream.Connect;
using Top.Api.Stream.Message;

namespace Top.Api.Stream
{
    public interface ITopCometStream
    {
        void SetConnectionListener(IConnectionLifeCycleListener connectionLifeCycleListener);
        void SetMessageListener(ITopCometMessageListener cometMessageListener);
        void Start();
        void Stop();
    }
}
