using BE.Helpers;
using System;
using System.Reflection;

namespace BE.Exceptions
{
    public class ExceptionEx : ApplicationException
    {
        // members
        public string OsVersion { get; set; }
        public DateTime DateTime { get; set; }
        public string UserName { get; set; }
        public string MachineName { get; set; }
        public string AppDomainName { get; set; }

        public MethodBase Method { get; set; }
        public string Namespace { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }

        public new object Data { get; set; }

        public string Text { get; set; }

        // class
        public ExceptionEx(Exception ex, MethodBase method, object data, string text, params object[] args) : base(args == null || args.Length == 0 ? text : String.Format(text, args), ex)
        {
            OsVersion = DeviceHelper.OsVersion;
            DateTime = DateTime.Now;
            UserName = DeviceHelper.UserName;
            MachineName = DeviceHelper.MachineName;
            // AppDomainName = AppHelper.AppName;

            Method = method;
            Namespace = method?.DeclaringType?.Namespace;
            ClassName = method?.DeclaringType?.Name;
            MethodName = method?.Name;

            Data = data;

            Text = args == null || args.Length == 0 ? text : String.Format(text, args);

            // LogHelper.LogError(this, method);
        }
    }
}