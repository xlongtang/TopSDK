using System;
using System.Threading;

namespace Top.Api.Stream.Message
{
    public class StreamMsgConsumeFactory
    {
        private int minThreads;
        private int maxThreads;
        private int queueSize;

        public StreamMsgConsumeFactory(int minThreads, int maxThreads, int queueSize)
        {
            if (minThreads <= 0 || maxThreads <= 0 || queueSize <= 0)
            {
                throw new Exception("minThread,maxThread and queueSize must large than 0");
            }
            this.minThreads = minThreads;
            this.maxThreads = maxThreads;
            this.queueSize = queueSize;

            ThreadPool.SetMinThreads(this.minThreads, this.minThreads);
            ThreadPool.SetMaxThreads(this.maxThreads, this.maxThreads);
        }

        public void Consume(WaitCallback callback)
        {
            ThreadPool.QueueUserWorkItem(callback);
        }

        public void Shutdown()
        {
        }
    }
}
