using System;

public sealed class ThreadSafeSingletonWithEagerLoading
{
	private static ThreadSafeSingletonWithEagerLoading _instance = new ThreadSafeSingletonWithEagerLoading();

    private ThreadSafeSingletonWithEagerLoading()
	{
	}

	public static ThreadSafeSingletonWithEagerLoading Instance
	{
		get
		{
			return _instance;
		}
	}
}
