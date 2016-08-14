using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Log4Net
    {
        public static void Log(string inputType, Exception ex)
        {
            SetUp.Setup();
            
            log4net.ILog log = log4net.LogManager.GetLogger(inputType);
            log.Info("Testing message.");
            log.Error("InnerException: " +ex.InnerException);
            log.Error("Source: "+ex.Source);
            log.Error("StackTrace: " + ex.StackTrace);
        }
    }
}
