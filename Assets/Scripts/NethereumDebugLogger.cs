﻿//using System;
//using Common.Logging;

//namespace Galleass3D
//{
//    public class NethereumDebugLogger : ILog
//    {
//        public NethereumDebugLogger()
//        {

//        }

//        public bool IsTraceEnabled { get; set; }

//        public bool IsDebugEnabled { get; set; }

//        public bool IsErrorEnabled { get; set; }

//        public bool IsFatalEnabled { get; set; }

//        public bool IsInfoEnabled { get; set; }

//        public bool IsWarnEnabled { get; set; }

//        public IVariablesContext GlobalVariablesContext { get; set; }

//        public IVariablesContext ThreadVariablesContext { get; set; }

//        public INestedVariablesContext NestedThreadVariablesContext => throw new NotImplementedException();

//        public void Debug(object message)
//        {
//            throw new NotImplementedException();
//        }

//        public void Debug(object message, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Debug(Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Debug(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void DebugFormat(string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void DebugFormat(string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void Error(object message)
//        {
//            throw new NotImplementedException();
//        }

//        public void Error(object message, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Error(Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Error(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void ErrorFormat(string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void ErrorFormat(string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void Fatal(object message)
//        {
//            throw new NotImplementedException();
//        }

//        public void Fatal(object message, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Fatal(Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Fatal(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void FatalFormat(string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void FatalFormat(string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void Info(object message)
//        {
//            throw new NotImplementedException();
//        }

//        public void Info(object message, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Info(Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Info(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void InfoFormat(string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void InfoFormat(string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void Trace(object message)
//        {
//            throw new NotImplementedException();
//        }

//        public void Trace(object message, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Trace(Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Trace(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void TraceFormat(string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void TraceFormat(string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void Warn(object message)
//        {
//            throw new NotImplementedException();
//        }

//        public void Warn(object message, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Warn(Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Warn(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
//        {
//            throw new NotImplementedException();
//        }

//        public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
//        {
//            throw new NotImplementedException();
//        }

//        public void WarnFormat(string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void WarnFormat(string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
//        {
//            throw new NotImplementedException();
//        }

//        public void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
