using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (input == string.Empty)
            {
                return 0;
            }

            if (input.Contains(","))
            {
                string[] array = new string[2];
                array = input.Split(',');
                int first = int.Parse(array[0]);
                int second = int.Parse(array[1]);
                int sum = first + second;
                return sum;
            }
            return int.Parse(input);
        }
    }
}
