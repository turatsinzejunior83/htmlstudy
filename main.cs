using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 217063527
{
    class program
    {
        static void Main(string[] args)
        {
            double t;
            double q;
            string k;
            Console.WriteLine("ENTER NUMBER A");
              w = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("ENTER number B ");
              Z = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("PLEASE SELECT OP");
              K = Console.ReadLine();
              var calculator = new calculator();
              calculator.w = t;
              calculator.z = q;


            switch(op)
            {
                case "+":

                    Console.WriteLine("output= {0}", calculator.addition(w, z));

                    break;
                case "-":

                    Console.WriteLine("output= {0}", calculator.sub(w, z));

                    break;
                case "*":

                    Console.WriteLine("output= {0}", calculator.multiplication(w, z));

                    break;

                case "/":

                    Console.WriteLine("output= {0}", calculator.devision(w, z));

                    break;
                default:
                    Console.WriteLine("invalid op");
                    break;
            }

              Console.ReadLine();
        }
    }
}
