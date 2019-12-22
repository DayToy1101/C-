using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace 试验4__2
{
    public class Frult
    {
        public virtual string Name
        {
            get { return ("Frult"); }
        }
    }
    public class Apple : Frult
    {
        public override string Name
        {
            get
            {
                return ("Apple");
            }
        }
    }
    public class Banana : Frult
    {
        public override string Name
        {
            get
            {
                return ("Banana");
            }
        }
    }
    public class FrultBasket : IEnumerable
    {
        static int Max = 10;
        Frult[] basket = new Frult[Max];
        int count = 0;
        internal Frult this[int index]
        {
            get { return (basket[index]); }
            set { basket[index] = value; }
        }
        internal int Count
        {
            get { return (count); }
        }
        public void Add(Frult frult)
        {
            if (count > Max)
            {
                Console.WriteLine("超出水果筐容量！");
            }
            basket[count++] = frult;
        }
        public IEnumerator GetEnumerator()
        {
            return (new FrultBasketEnumerator(this));
        }
    }
    public class FrultBasketEnumerator : IEnumerator
    {
        FrultBasket frultBasket;
        int index;
        public void Reset()
        {
            index = -1;
        }
        public object Current
        {
            get { return (frultBasket[index]); }
        }
        public bool MoveNext()
        {
            if (++index >= frultBasket.Count)
                return false;
            else
                return true;
        }
        internal FrultBasketEnumerator(FrultBasket frultBasket)
        {
            this.frultBasket = frultBasket;
            Reset();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FrultBasket frultBasket = new FrultBasket();
            Console.WriteLine("Adding a Banana");
            frultBasket.Add(new Banana());
            Console.WriteLine("Adding a Apple");
            frultBasket.Add(new Apple());
            Console.WriteLine("");
            Console.WriteLine("The basket is holding!");
            foreach (Frult frult in frultBasket)
            {
                Console.WriteLine("a(n)" + frult.Name);
            }
            Console.Read();
        }
    }
}
