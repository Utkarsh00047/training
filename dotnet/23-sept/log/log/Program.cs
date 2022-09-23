using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log
{
    class Program
    {
        internal static void Testing()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            try
            {
                string str = String.Empty;
                string subStr = str.Substring(0, 4); 
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }
        static void Main(string[] args)
        {
            Testing();
            Console.ReadLine();
        }
    }
}
