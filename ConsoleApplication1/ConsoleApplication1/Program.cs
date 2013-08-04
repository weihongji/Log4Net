using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ConsoleApplication1
{
	class Program
	{
		private static readonly ILog log = LogManager.GetLogger(typeof(Program));

		static void Main(string[] args) {
			log.Fatal("Fatal");
			log.Error("Error");
			log.Warn("Warn");
			log.Info("Info");
			log.Debug("Debug");

			Console.WriteLine("Press any key to exit ...");
			Console.ReadKey();
		}
	}
}
