class Banana
{
	void peel(int i)
	{
		System.out.println(i);
	}
}

public  class BananaPeel
{
	public static void main(String[] args)
	{
		Banana a = new Banana();
		Banana b = new Banana();

		a.peel(1);
		b.peel(20);
	}
}