using System;

namespace DLLInjection.InjectionStrategies;

internal interface IInjectionStrategy
{
	IntPtr Inject(IntPtr processHandle, string dllPath);
}
