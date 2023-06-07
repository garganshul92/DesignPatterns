using System;

// Singleton 1
public sealed class NoThreadSafeSingleton
{
	private static NoThreadSafeSingleton instance;

    private NoThreadSafeSingleton()
	{

	}

	public static NoThreadSafeSingleton Instance
	{
		get
		{
			if(instance == null)
			{
				instance = new NoThreadSafeSingleton();
			}

			return instance;

		}
	}
}
