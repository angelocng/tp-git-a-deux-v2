using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavGe.Logger
{
    public class ConsoleLogger : AbstractLogger
    {
        public override void LogMessage(string message)
        {
            this.Write(message);
        }
        internal override void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
