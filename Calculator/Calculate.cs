using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        public Calculate()
        {

        }

        public string add(double a, double b)
        {
            return Convert.ToString(a + b);
        }

        public string subtract(double a, double b)
        {
            return Convert.ToString(a - b);
        }

        public string multiply(int a, int b)
        {
            return Convert.ToString(a * b);
        }

        public string divide(int a, int b)
        {
            return Convert.ToString(a / b);
        }

        public string intergerDivision(float a, float b)
        {
            return Convert.ToString(a / (int)b);
        }

        
    }
}
