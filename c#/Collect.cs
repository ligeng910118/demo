interface IPair<T>
{
	T First {get;set;}
	T Second {get;set;}
}

public struct Pair<T> : IPair<T>
{
	private T _First;
	public T First
	{
		get
		{
			return _First;
		}
		set
		{
			_First = value;
		}
	}

	private T _Second;
	public T Second
	{
		get
		{
			return _Second;
		}
		set
		{
			_Second = value;
		}
	}
}