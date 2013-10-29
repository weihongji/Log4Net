using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleApplication1
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static int counter = 0;
        private static Timer timer;

        static void Main(string[] args) {
            //timer = new Timer(1000 * 60);
            //timer.Enabled = true;
            //timer.Elapsed += timer_Elapsed;

            log.Fatal("Fatal");
            log.Error("Error");
            log.Warn("Warn");
            log.Info("Info");
            log.Debug("Debug");

            //System.Threading.Thread.Sleep(1000 * 60 * 3);

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }

        static void timer_Elapsed(object sender, ElapsedEventArgs e) {
            counter++;
            log.Info(counter.ToString());
        }
    }
}
