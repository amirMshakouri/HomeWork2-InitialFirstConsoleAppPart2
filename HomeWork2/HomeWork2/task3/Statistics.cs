using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace HomeWork2.task3
{
    public class Statistics
    {
        public void AnalyzeNumbers (int num1 , ref int num2 , out int num3)
        {
            num3 = num1 + num2;
            num2 = num2 * num2 ;

            Console.WriteLine($"first number is : {num1} ");
        }
    }
}
