using System;


// Singleton 3

public sealed class ThreadSafeSingletonWithDoubleCheckLock
{
	private static ThreadSafeSingletonWithDoubleCheckLock _threadSafeSingletonWithDoubleCheckLock;
	private static object _lock = new object();

    private ThreadSafeSingletonWithDoubleCheckLock()
	{
	}

	public static ThreadSafeSingletonWithDoubleCheckLock Instance
	{
		get
		{
			if(_threadSafeSingletonWithDoubleCheckLock == null)
			{
				lock (_lock)
				{
                    if (_threadSafeSingletonWithDoubleCheckLock == null)
					{
						_threadSafeSingletonWithDoubleCheckLock = new ThreadSafeSingletonWithDoubleCheckLock();
                    }

                }
			}

			return _threadSafeSingletonWithDoubleCheckLock;
		}
	}
}
