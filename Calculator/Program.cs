using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Maths
    {
        public int Addition(int a, int b)
        {
            return(a+b);
        }
        public int Substarction(int a, int b)
        {
            return (a - b);
        }
        public int Multiplication(int a, int b)
        {
            return (a * b);

        }
        public int Division(int a, int b)
        {
            return (a / b);
        }

        public void display(int result)
        {
            Console.WriteLine("Answer is : {0}", result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Maths m_Maths = new Maths();
            int result = m_Maths.Addition(10, 20);
            m_Maths.display(result);

            Console.ReadLine();
        }
    }
}
