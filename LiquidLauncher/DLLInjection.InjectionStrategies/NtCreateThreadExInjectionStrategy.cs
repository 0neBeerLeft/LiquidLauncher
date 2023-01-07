using System;
using System.Runtime.InteropServices;

namespace DLLInjection.InjectionStrategies;

internal class NtCreateThreadExInjectionStrategy : LoadLibraryInjectionStrategyBase
{
	protected unsafe override IntPtr Inject(IntPtr processHandle, IntPtr loadLibraryAddress, IntPtr addressOfDllPath)
	{
		IntPtr moduleHandle = WinAPI.GetModuleHandle("ntdll.dll");
		Utils.CheckForFailure(moduleHandle == IntPtr.Zero, "Cannot load NTDLL module");
		IntPtr procAddress = WinAPI.GetProcAddress(moduleHandle, "NtCreateThreadEx");
		Utils.CheckForFailure(procAddress == IntPtr.Zero, "Cannot find NtCreateThreadEx address in NTDLL module");
		WinAPI.NtCreateThreadEx obj = (WinAPI.NtCreateThreadEx)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(WinAPI.NtCreateThreadEx));
		Utils.CheckForFailure(obj == null, "Cannot create delegate from pointer to NtCreateThreadEx");
		int num = 0;
		int num2 = 0;
		WinAPI.NtCreateThreadExBuffer ntCreateThreadExBuffer = new WinAPI.NtCreateThreadExBuffer
		{
			Size = sizeof(WinAPI.NtCreateThreadExBuffer),
			Unknown1 = 65539u,
			Unknown2 = 8u,
			Unknown3 = new IntPtr(&num2),
			Unknown4 = 0u,
			Unknown5 = 65540u,
			Unknown6 = 4u,
			Unknown7 = new IntPtr(&num),
			Unknown8 = 0u
		};
		bool is64BitProcess = Environment.Is64BitProcess;
		IntPtr threadHandle = IntPtr.Zero;
		obj(out threadHandle, 2097151u, IntPtr.Zero, processHandle, loadLibraryAddress, addressOfDllPath, 0, 0u, is64BitProcess ? 65535u : 0u, is64BitProcess ? 65535u : 0u, is64BitProcess ? IntPtr.Zero : new IntPtr(&ntCreateThreadExBuffer));
		Utils.CheckForFailure(threadHandle == IntPtr.Zero, "NtCreateThreadEx failed");
		return threadHandle;
	}
}
