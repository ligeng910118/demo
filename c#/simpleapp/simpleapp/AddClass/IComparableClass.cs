using System;
namespace simpleapp.AddClass
{
    public class IComparableClass
    {
        public static void IComparableClassMain()
        {
            Cars[] myCars = new Cars[5];
            for (int i = 0; i < 5; i++)
                myCars[i] = new Cars(i);
            foreach (Cars c in myCars)
                Console.WriteLine("{0}", c.carID);

            Array.Sort(myCars);
            foreach (Cars c in myCars)
                Console.WriteLine("{0}", c.carID);
        }
    }

    public interface IComparable
    {
        int CompareTo(Cars o);
    }

    public class Cars : IComparable
    {
        public int carID { get; set; }
        public Cars(int id)
        {
            carID = id;  
        }

        public int CompareTo(Cars o)
        {
            Cars temp = o as Cars;
            if (temp!= null)
            {
                if (this.carID > temp.carID)
                    return 1;
                if (this.carID < temp.carID)
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("error!");
        }
    }
}
