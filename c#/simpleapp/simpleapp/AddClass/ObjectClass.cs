using System;
namespace simpleapp.AddClass
{
    class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string fName,string lName,int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

		public override string ToString()
		{
            string myState;
            myState = string.Format("[First Name:{0},Last Name:{1},Age:{2}]",FirstName,LastName,Age);
            return myState;
		}

        public static void StaticMembersOfObject()
        {
            Person p3 = new Person("sally","jones",4);
            Person p4 = new Person("sally","jones",4);
            Console.WriteLine("p3 and p4 have same state:{0}",object.Equals(p3,p4));
            Console.WriteLine("p3 and p4 are pointing to same object:{0}",object.ReferenceEquals(p3,p4));
        }
	}
    public class ObjectClass
    {
        public static void ObjectClassMain()
        {
            Person p1 = new Person("li","geng",28);
            Console.WriteLine("ToString : {0}",p1.ToString());
            Console.WriteLine("Hash code : {0}", p1.GetHashCode());
            Console.WriteLine("Type : {0}", p1.GetType());

            Person p2 = p1;
            object o = p2;

            if(o.Equals(p1)&&p2.Equals(o))
            {
                Console.WriteLine("same instance!");
            }
        }
    }
}
