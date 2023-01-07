using System.Runtime.InteropServices;

namespace DLLInjection;

internal static class Utils
{
	public static void CheckForFailure(bool failureIndicator, string message, params object[] args)
	{
		if (!failureIndicator)
		{
			return;
		}
		string text = string.Format(message, args);
		string text2 = $"LastWinError: {Marshal.GetLastWin32Error()}";
		throw new DLLInjectionFailedException(text + " (" + text2 + ")");
	}
}
