using System;

namespace DLLInjection.InjectionStrategies;

internal class CreateRemoteThreadInjectionStrategy : LoadLibraryInjectionStrategyBase
{
	protected override IntPtr Inject(IntPtr processHandle, IntPtr loadLibraryAddress, IntPtr addressOfDllPath)
	{
		IntPtr intPtr = WinAPI.CreateRemoteThread(processHandle, IntPtr.Zero, 0u, loadLibraryAddress, addressOfDllPath, 0u, IntPtr.Zero);
		Utils.CheckForFailure(intPtr == IntPtr.Zero, "Cannot create remote thread using CreateRemoteThread method");
		return intPtr;
	}
}
