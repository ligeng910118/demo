using System;
namespace simpleapp.AddClass
{
    public class EmployeeClass
    {
        private string empName;
        private int empID;
        private float currPay;
        public EmployeeClass()
        {
        }

        public EmployeeClass(string name,int id,float pay)
        {
            empID = id;
            empName = name;
            currPay = pay;
        }


        public string Name
        {
            get { return empName; }
            set{
                if (value.Length > 15)
                    Console.WriteLine("error,name must be less than 15");
                else
                    empName = value;
            }
        }

        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("name:{0}",empName);
            Console.WriteLine("id:{0}",empID);
            Console.WriteLine("currPay:{0}",currPay);
        }
    }
}
