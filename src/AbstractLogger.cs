using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public abstract class AbstractLogger
    {
        private AbstractLogger nextLogger;

        protected AbstractLogger NextLogger 
        {
            get {return nextLogger;}
            set {SetNextLogger(value);}
        }

        public const int INFO=1;
        public const int DEBUG=2;
        public const int ERROR=3;

        public AbstractLogger(AbstractLogger _nextLogger)
        {
            nextLogger = _nextLogger;
        }

        public void SetNextLogger(AbstractLogger _logger)
        {
            nextLogger=_logger;
        }
        
        public abstract void LogMessage(string _message);
        protected abstract void Write(string _message);        
    }
}