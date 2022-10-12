using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonOops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Line comparison using oops concept");



           // LengthOfLine lengthOfLine = new LengthOfLine();
            //lengthOfLine.Length();
           // LengthComparison lengthComparison = new LengthComparison();
            //lengthComparison.Length();

            CompareLine compareLine = new CompareLine();
            compareLine.Length();

        }
    }
}
