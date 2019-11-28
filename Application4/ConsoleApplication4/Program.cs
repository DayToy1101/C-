using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    interface IEnglishDimensions
    {
        float Length();
        float Width();
    }
    interface IMetricDimensions
    {
        float Length();
        float Width();
    }
    class Program : IEnglishDimensions, IMetricDimensions
    {
        float lengthInches;
        float widthInches;
        public Program(float length, float width)
        {
            lengthInches = length;
            widthInches = width;

        }
        float IEnglishDimensions.Length()
        {
            return lengthInches;
        }
        float IEnglishDimensions.Width()
        {
            return widthInches;
        }
        float IMetricDimensions.Length()
        {
            return lengthInches * 2.54f;
        }
        float IMetricDimensions.Width()
        {
            return widthInches * 2.54f;
        }



        static void Main(string[] args)
        {
            Program myBox = new Program(30.0f, 20.0f);
            IEnglishDimensions eDimensions = (IEnglishDimensions)myBox;
            IMetricDimensions mDimensions = (IMetricDimensions)myBox;
            Console.WriteLine("length(in):{0}", eDimensions.Length());
            Console.WriteLine("Width(in):{0}", eDimensions.Width());
            Console.WriteLine("length(cm):{0}", mDimensions.Length());
            Console.WriteLine("Width(cm):{0}", mDimensions.Width());
            Console.Read();
        }
    }
}

