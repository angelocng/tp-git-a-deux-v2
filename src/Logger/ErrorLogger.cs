using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DavGe
{
    public class ErrorLogger : AbstractLogger
    {
        public override void LogMessage(string message)
        {
            Write(message);
            NextLogger.LogMessage(message);
        }

        protected override void Write(string message)
        {
            EventLog log = new EventLog();
            log.Source = "ErrorLogger";
            log.WriteEntry(message);
        }
    }
}
