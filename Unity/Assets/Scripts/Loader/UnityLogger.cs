using System;
using System.Threading;

namespace ET
{
    public class UnityLogger: ILog
    {
        public void Trace(string msg)
        {
            string name = Thread.CurrentThread.Name;
            string message = $"TRACE [{name}] - {msg}";
            UnityEngine.Debug.Log(message);
        }

        public void Debug(string msg)
        {
            // int id=	Thread.CurrentThread.ManagedThreadId;
            string name = Thread.CurrentThread.Name;
            string message = $"DEBUG [{name}] - {msg}";
            UnityEngine.Debug.Log(message);
        }

        public void Info(string msg)
        {
            string name = Thread.CurrentThread.Name;
            string message = $"INFO [{name}] - {msg}";
            UnityEngine.Debug.Log(message);
        }

        public void Warning(string msg)
        {
            string name = Thread.CurrentThread.Name;
            string message = $"WARNING [{name}] - {msg}";
            UnityEngine.Debug.LogWarning(message);
        }

        public void Error(string msg)
        {
            string name = Thread.CurrentThread.Name;
            string message = $"ERROR [{name}] - {msg}";
            UnityEngine.Debug.LogError(message);
        }

        public void Error(Exception e)
        {
            UnityEngine.Debug.LogException(e);
        }

        public void Trace(string message, params object[] args)
        {
            string name = Thread.CurrentThread.Name;
            message = $"TRACE [{name}] - {message}";
            UnityEngine.Debug.LogFormat(message, args);
        }

        public void Warning(string message, params object[] args)
        {
            string name = Thread.CurrentThread.Name;
            message = $"WARNING [{name}] - {message}";
            UnityEngine.Debug.LogWarningFormat(message, args);
        }

        public void Info(string message, params object[] args)
        {
            string name = Thread.CurrentThread.Name;
            message = $"INFO [{name}] - {message}";
            UnityEngine.Debug.LogFormat(message, args);
        }

        public void Debug(string message, params object[] args)
        {
            string name = Thread.CurrentThread.Name;
            message = $"DEBUG [{name}] - {message}";
            UnityEngine.Debug.LogFormat(message, args);
        }

        public void Error(string message, params object[] args)
        {
            string name = Thread.CurrentThread.Name;
            message = $"ERROR [{name}] - {message}";
            UnityEngine.Debug.LogErrorFormat(message, args);
        }
    }
}