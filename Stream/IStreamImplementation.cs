using System;

namespace Top.Api.Stream
{
    public interface IStreamImplementation
    {
        bool IsAlive();
        void NextMsg();
        string ParseLine(string msg);
        void OnException(Exception ex);
        void Close();
    }
}
