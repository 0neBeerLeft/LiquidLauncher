using System.Diagnostics;

namespace Bunifu.Framework.Lib;

[DebuggerStepThrough]
internal static class cmd
{
	private static Process process_0;

	internal static void EXECUTECMD(string CMD)
	{
		process_0 = new Process();
		process_0.StartInfo.FileName = "CMD.exe";
		process_0.StartInfo.Arguments = "/C " + CMD;
		process_0.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process_0.Start();
		process_0.WaitForExit();
	}
}
