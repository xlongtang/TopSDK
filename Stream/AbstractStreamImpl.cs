using System;
using Top.Api.Stream.Connect;
using Top.Api.Stream.Message;

namespace Top.Api.Stream
{
    public abstract class AbstractStreamImpl : IStreamImplementation
    {
        private ITopLogger log = new DefaultTopLogger();
        protected HttpResponse response;
        private StreamMsgConsumeFactory msgConsumeFactory;
        protected bool streamAlive = true;

        public AbstractStreamImpl(StreamMsgConsumeFactory msgConsumeFactory, HttpResponse response)
        {
            this.msgConsumeFactory = msgConsumeFactory;
            this.response = response;
        }

        public void NextMsg()
        {
            if (!streamAlive)
            {
                throw new Exception("Stream closed");
            }
            try
            {
                string line = response.GetMsg();

                if (string.IsNullOrEmpty(line))
                {//正常读到流的末尾了。
                    streamAlive = false;
                    response.Close();
                    return;
                }
                if (!string.IsNullOrEmpty(line))
                {
                    msgConsumeFactory.Consume(delegate(object obj)
                        {
                            string parseString = ParseLine(line);
                            if (!string.IsNullOrEmpty(parseString))
                            {
                                GetMessageListener().OnReceiveMsg(parseString);
                            }
                        });
                }

                //Thread msgParseThread = new Thread(delegate()
                //    {
                //        if (!string.IsNullOrEmpty(line))
                //        {
                //            string parseString = parseLine(line);
                //            if (!string.IsNullOrEmpty(parseString))
                //            {
                //                getMessageListener().onReceiveMsg(parseString);
                //            }
                //        }
                //    });
                //msgParseThread.Start();

            }
            catch (Exception e)
            {//这个时候抛出：SocketTimeoutException
                response.Close();
                streamAlive = false;
                throw e;
            }
        }

        public bool IsAlive()
        {
            return streamAlive;
        }

        public abstract ITopCometMessageListener GetMessageListener();
        public abstract string ParseLine(string msg);
        public abstract void OnException(Exception ex);
        public abstract void Close();

    }
}
