using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class calculator
    {
        static void main(string[] args)
        {
        public double w,z;
        

        public double addition(double w, double z)
        {
            return (w + z);
        }

        public double sub(double w, double z)
        {
            return (w - z);
        }
        public double multiplication(double w, double z)
        {
            return (w * z);
        }
        public double devision(double w, double z)
        {
            if (z == 0)
                Console.WriteLine("invalid operation");

            return (w / z);

        }

    }  
            
    
}
