using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic m_Maths = new Logic();
            int result = m_Maths.Addition(10, 20);
            m_Maths.display(result);

            Console.ReadLine();
        }
    }
}
