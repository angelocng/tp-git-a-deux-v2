using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src;

namespace DavGe.Logger
{
    public class ConsoleLogger : AbstractLogger
    {
        public override void LogMessage(string message)
        {
            this.Write(message);
        }
        protected override void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
