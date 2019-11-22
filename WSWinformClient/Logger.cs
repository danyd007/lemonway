using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSWinformClient
{
    public class Logger
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Initialize()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void Log(string msg, LogType type)
        {
            switch (type)
            {
                case LogType.Info:
                    log.Info(msg);
                    break;
                case LogType.Error:
                    log.Error(msg);
                    break;
                case LogType.Warn:
                    log.Warn(msg);
                    break;
                case LogType.Fatal:
                    log.Fatal(msg);
                    break;
            }
        }

        public static void Log(string msg, Exception e, LogType type)
        {
            switch (type)
            {
                case LogType.Debug:
                    log.Debug(msg, e);
                    break;
                case LogType.Info:
                    log.Info(msg, e);
                    break;
                case LogType.Error:
                    log.Error(msg, e);
                    break;
                case LogType.Warn:
                    log.Warn(msg, e);
                    break;
                case LogType.Fatal:
                    log.Fatal(msg, e);
                    break;
            }
        }
    }

    public enum LogType
    {
        Debug = 0,
        Info = 1,
        Error = 2,
        Warn = 3,
        Fatal = 4,
    }
}

