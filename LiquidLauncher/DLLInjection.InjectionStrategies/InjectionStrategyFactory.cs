using System;

namespace DLLInjection.InjectionStrategies;

internal static class InjectionStrategyFactory
{
	public static IInjectionStrategy Create(InjectionMethod injectionMethod)
	{
		return injectionMethod switch
		{
			InjectionMethod.CREATE_REMOTE_THREAD => new CreateRemoteThreadInjectionStrategy(), 
			InjectionMethod.NT_CREATE_THREAD_EX => new NtCreateThreadExInjectionStrategy(), 
			_ => throw new NotSupportedException($"Injection strategy: {injectionMethod} is not supported"), 
		};
	}
}
