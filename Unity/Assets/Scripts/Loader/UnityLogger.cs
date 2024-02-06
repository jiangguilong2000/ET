using System;
using System.Threading;

namespace ET
{
    public class UnityLogger: ILog
    {
        public void Trace(string msg)
        {
            int id=	Thread.CurrentThread.ManagedThreadId;
            string message = $"[{id}] {msg}";
            UnityEngine.Debug.Log(message);
        }

        public void Debug(string msg)
        {
            int id=	Thread.CurrentThread.ManagedThreadId;
            string message = $"[{id}] {msg}";
            UnityEngine.Debug.Log(message);
        }

        public void Info(string msg)
        {  int id=	Thread.CurrentThread.ManagedThreadId;
            string message = $"[{id}] {msg}";
            UnityEngine.Debug.Log(message);
        }

        public void Warning(string msg)
        { int id=	Thread.CurrentThread.ManagedThreadId;
            string message = $"[{id}] {msg}";
            UnityEngine.Debug.LogWarning(message);
        }

        public void Error(string msg)
        {int id=	Thread.CurrentThread.ManagedThreadId;
            string message = $"[{id}] {msg}";
            UnityEngine.Debug.LogError(message);
        }

        public void Error(Exception e)
        {
            UnityEngine.Debug.LogException(e);
        }

        public void Trace(string message, params object[] args)
        {
            int id=	Thread.CurrentThread.ManagedThreadId;
            message = $"[{id}] {message}";
            UnityEngine.Debug.LogFormat(message, args);
        }

        public void Warning(string message, params object[] args)
        {
            int id=	Thread.CurrentThread.ManagedThreadId;
            message = $"[{id}] {message}";
            UnityEngine.Debug.LogWarningFormat(message, args);
        }

        public void Info(string message, params object[] args)
        {
            int id=	Thread.CurrentThread.ManagedThreadId;
            message = $"[{id}] {message}";
            UnityEngine.Debug.LogFormat(message, args);
        }

        public void Debug(string message, params object[] args)
        {
            int id=	Thread.CurrentThread.ManagedThreadId;
             message = $"[{id}] {message}";
            UnityEngine.Debug.LogFormat(message, args);
        }

        public void Error(string message, params object[] args)
        {
            int id=	Thread.CurrentThread.ManagedThreadId;
            message = $"[{id}] {message}";
            UnityEngine.Debug.LogErrorFormat(message, args);
        }
    }
}