using System;

//Singleton 2

// Limitation: Lock is quite expensive. Putting lock everytime is costly.

public sealed class ThreadSafeSingleton
{
	private static ThreadSafeSingleton _threadSafeSingleton;
	private static object _lock = new object();

	private ThreadSafeSingleton()
	{
	}

	public static ThreadSafeSingleton Instance
	{
		get
		{
			lock (_lock)
			{
				if (_threadSafeSingleton == null)
				{
					_threadSafeSingleton = new ThreadSafeSingleton();
				}

				return _threadSafeSingleton;
			}
		}

	}
}
