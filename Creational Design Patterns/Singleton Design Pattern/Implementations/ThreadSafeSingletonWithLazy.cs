using System;

public sealed class ThreadSafeSingletonWithLazy
{
	private static Lazy<ThreadSafeSingletonWithLazy> _instance = new Lazy<ThreadSafeSingletonWithLazy>(() => new ThreadSafeSingletonWithLazy());

	private ThreadSafeSingletonWithLazy()
	{
	}

	public static ThreadSafeSingletonWithLazy Instance
	{
		get
		{
			return _instance.Value;
		}
	}
}
