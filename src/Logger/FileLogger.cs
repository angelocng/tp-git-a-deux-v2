using src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavGe.Logger
{
    public class FileLogger : AbstractLogger
    {
        private const string PATH = "log.txt";
        public FileLogger(AbstractLogger _nextLogger) : base(_nextLogger)
        {
        }

        public override void LogMessage(string _message)
        {
            Write(_message);
            NextLogger.LogMessage(_message);
        }

        protected override void Write(string _message)
        {
            FileStream fs = File.OpenWrite(PATH);
            byte[] infos = UTF8Encoding.UTF8.GetBytes(_message + "\n");
            fs.Write(infos, 0, infos.Length);
        }
    }
}
