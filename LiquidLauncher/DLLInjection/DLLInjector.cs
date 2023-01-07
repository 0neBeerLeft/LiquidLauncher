using System;
using System.IO;
using DLLInjection.InjectionStrategies;

namespace DLLInjection;

public class DLLInjector
{
	private IInjectionStrategy _injectionStrategy;

	public DLLInjector(InjectionMethod injectionMethod)
	{
		_injectionStrategy = InjectionStrategyFactory.Create(injectionMethod);
	}

	public void Inject(int pid, string pathToDll, InjectionOptions injectionOptions = null)
	{
		if (pid <= 0)
		{
			throw new ArgumentException("Invalid process pid: " + pid, "pid");
		}
		if (string.IsNullOrWhiteSpace(pathToDll) || !File.Exists(pathToDll))
		{
			throw new ArgumentException("Cannot access DLL: \"" + pathToDll + "\"");
		}
		injectionOptions = injectionOptions ?? InjectionOptions.Defaults;
		IntPtr intPtr = WinAPI.OpenProcess(WinAPI.ProcessAccessFlags.CreateThread | WinAPI.ProcessAccessFlags.VirtualMemoryOperation | WinAPI.ProcessAccessFlags.VirtualMemoryRead | WinAPI.ProcessAccessFlags.VirtualMemoryWrite | WinAPI.ProcessAccessFlags.QueryInformation, bInheritHandle: false, pid);
		Utils.CheckForFailure(intPtr == IntPtr.Zero, "Cannot open process with PID: {0}", pid);
		IntPtr hHandle = _injectionStrategy.Inject(intPtr, pathToDll);
		if (injectionOptions.WaitForThreadExit)
		{
			WinAPI.WaitForSingleObject(hHandle, uint.MaxValue);
		}
		WinAPI.CloseHandle(intPtr);
	}
}
