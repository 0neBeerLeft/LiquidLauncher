using System;
using System.Text;

namespace DLLInjection.InjectionStrategies;

internal abstract class LoadLibraryInjectionStrategyBase : IInjectionStrategy
{
	public IntPtr Inject(IntPtr processHandle, string dllPath)
	{
		if (processHandle == IntPtr.Zero)
		{
			throw new ArgumentException("Invalid process handle", "processHandle");
		}
		if (string.IsNullOrWhiteSpace(dllPath))
		{
			throw new ArgumentException("Invalid dll path", "pathToDll");
		}
		byte[] bytes = Encoding.ASCII.GetBytes(dllPath + "\0");
		IntPtr intPtr = WinAPI.VirtualAllocEx(processHandle, IntPtr.Zero, (uint)bytes.Length, WinAPI.AllocationType.Commit | WinAPI.AllocationType.Reserve, WinAPI.MemoryProtection.ExecuteReadWrite);
		Utils.CheckForFailure(intPtr == IntPtr.Zero, "Cannot allocate memory in process");
		Utils.CheckForFailure(!WinAPI.WriteProcessMemory(processHandle, intPtr, bytes, bytes.Length, out var _), "Cannot write to process memory");
		IntPtr moduleHandle = WinAPI.GetModuleHandle("kernel32.dll");
		Utils.CheckForFailure(moduleHandle == IntPtr.Zero, "Cannot get handle to kernel32 module");
		IntPtr procAddress = WinAPI.GetProcAddress(moduleHandle, "LoadLibraryA");
		Utils.CheckForFailure(procAddress == IntPtr.Zero, "Cannot get address of LoadLibrary function");
		IntPtr intPtr2 = Inject(processHandle, procAddress, intPtr);
		Utils.CheckForFailure(intPtr2 == IntPtr.Zero, "Cannot create remote thread using {0} method.", GetType().Name);
		return intPtr2;
	}

	protected abstract IntPtr Inject(IntPtr processHandle, IntPtr loadLibraryAddress, IntPtr addressOfDllPath);
}
