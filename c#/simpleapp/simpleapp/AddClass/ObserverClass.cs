using System;
namespace simpleapp.AddClass
{
    public delegate void Handler();
    public class Incrementer
    {
        public event Handler CountedADozen;

        public void DoCount()
        {
            for (int i = 1; i < 100; i++)
                if (i % 12 == 0 && CountedADozen != null)
                    CountedADozen();
        }
    }

    public class Dozens
    {
        public int DozensCount { get; private set; }

        public Dozens(Incrementer incrementer)
        {
            DozensCount = 0;
            incrementer.CountedADozen += IncrementDozensCount;
        }

        public void IncrementDozensCount()
        {
            DozensCount++;
        }
    }

    public class ObserverClass
    {
        public void ObserverClassMain()
        {
            Incrementer incrementer = new Incrementer();
            Dozens dozensCounter = new Dozens(incrementer);
            incrementer.DoCount();
            Console.WriteLine("number of dozens = {0}",dozensCounter.DozensCount);
        }
    }
}
