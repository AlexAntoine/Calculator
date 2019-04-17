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

        public string multiply(double a, double b)
        {
            return Convert.ToString(a * b);
        }

        public string divide(double a, double b)
        {
            return Convert.ToString(a / b);
        }

        public string intergerDivision(double a, double b)
        {
            return Convert.ToString(a / (int)b);
        }

        public string percent(double a, double b)
        {
            return Convert.ToString(a / 100);
        }

        
    }
}
