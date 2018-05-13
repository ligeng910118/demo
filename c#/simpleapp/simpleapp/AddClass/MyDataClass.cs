using System;
namespace simpleapp.AddClass
{
    public class MyDataClass
    {
        private double D1;
        private double D2;
        private double D3;

        public MyDataClass(double d1,double d2,double d3)
        {
            D1 = d1;
            D2 = d2;
            D3 = d3;
        }

        public double Sum()
        {
            return D1 + D2 + D3;
        }
    }
}
