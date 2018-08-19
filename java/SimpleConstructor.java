class Rock{
	Rock(int i)
	{
		System.out.print("rock " + i + " ");
	}
}

public class SimpleConstructor{
	public static void main(String[] args)
	{
		for(int i = 0; i < 8 ; i++)
			new Rock(i);
	}
}