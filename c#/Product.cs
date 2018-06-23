using System.Collections.Generic;
public class Product
{
	// string name;
	// public string Name
	// { 
	// 	get 
	// 	{
	// 	  return name; 
	// 	  private set { name = value; }
	// 	} 
	// }

	// decimal price;
	// public decimal Price
	// {
	// 	get
	// 	{
	// 		return price;
	// 		private set { name = value; }
	// 	}
	// }

	public string Name { get; private set;}
	public decimal Price { get; private set;}

	public Product(string name,decimal price)
	{
		Name = name;
		Price = price;
	}

	Product() { }

	public static List<Product> GetSampleProducts()
	{
		//ArrayList list = new ArrayList();
		// List<Product> list = new List<Product>();
		// list.Add(new Product("west side story",9.9m));
		// list.Add(new Product("assassins",17.2m));
		// list.Add(new Product("frogs",13.22m));

		return new List<Product>
		{
			new Product { Name="west side story",Price=9.9m },
			new Product { Name="assassins",Price=17.2m },
			new Product { Name="frogs",Price=13.22m }
		};
	}

	public override string ToString()
	{
		return string.Format("{0} : {1}",Name,Price);
	}

	static void Main()
	{
		foreach(Product v in GetSampleProducts())
		{
			System.Console.WriteLine(v.ToString());
		}
 	}
}