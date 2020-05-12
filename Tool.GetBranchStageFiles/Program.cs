using System;
using System.IO;

namespace GetBranchStageFiles
{
	internal static class Program
	{
		static void Main(string[] args)
		{
			var pathTxt = args[0];
			var pathOutput = Path.GetDirectoryName(args[0]);
			var line = "";
			var counter = 0;

			var file = new StreamReader(pathTxt);
			Directory.CreateDirectory(Path.GetDirectoryName(pathOutput) ?? throw new Exception("Directory output not set"));

			while ((line = file.ReadLine()) != null)
			{
				Console.WriteLine(line);
				counter++;
				line = line.Replace('/', '\\');

				var from = AppDomain.CurrentDomain.BaseDirectory + line.Replace('/', '\\');
				var to = pathOutput + "\\" + line;
				Console.WriteLine("From: " + from);
				Console.WriteLine("To: " + to);
				Console.WriteLine("");
				Directory.CreateDirectory(Path.GetDirectoryName(to) ?? throw new Exception("Directory output not set"));
				File.Copy(from, to, true);
			}

			file.Close();
			Console.WriteLine("There were {0} lines.", counter);
			// Suspend the screen.  
			Console.ReadLine();
		}
	}
}
