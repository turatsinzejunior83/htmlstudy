using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_junior
{
    class junior work
    {
        static void Main(string[] args)
        {

            Emp empyee = new Emp("", 1, 6, 7);

            Console.WriteLine("inter your name");
            empyee.name = Console.ReadLine();
            Console.WriteLine("inter you id");
            empyee.id = Convert.ToInt32(Console.ReadLine());

            if ((empyee.name != null) && (empyee.id != null))
            {

                Console.WriteLine("please select type of employment");
                Console.WriteLine("_________________________________");


                Console.WriteLine("1.Montnly employee");
                Console.WriteLine("2.Temorary employee");
                Console.WriteLine("3.Evenning employee");

                empyee.type = Convert.ToInt32(Console.ReadLine());

                if (empyee.type == 1)
                {

                    empyee.salary(empyee.gross);









                }

                else if (empyee.type == 2)
                {

                    empyee.salary(empyee.hours, empyee.hour_salary);






                }


                else if (empyee.type == 3)
                {


                    empyee.salary(empyee.hours, empyee.hour_salary, empyee.bonus, empyee.net_before_bonus);









                }

                else Console.WriteLine(" invalid type of employment");




                Console.ReadLine();
            }

            else Console.WriteLine(" ivalid ID or name");




        }





    }
}


class Emp
{
    public string name;
    public int id;
    public int type;
    public int gross;
    public int net;
    public int hours;
    public int hour_salary;


    public int gross1;
    public int bonus;
    public int net_before_bonus;




    public Emp(string aName, int aId, int atype, int aGross)

    {
        name = aName;
        id = aId;
        type = atype;
        gross = aGross;


    }


    public void salary(int gross)
    {






        Console.WriteLine("please inter montly salary");

        gross = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("employee name : " + name);
        Console.WriteLine("employee ID : " + id);
        Console.WriteLine("type of  employement : Montly employement");
        Console.WriteLine("gross salary: " + gross);
        Console.WriteLine("net salary " + (gross - (gross * 0.21)));








    }


    public void salary(int hours, int hour_salary)
    {

        Console.WriteLine("Please inter your total  number of days you work");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please inter your daily salary");

        hour_salary = Convert.ToInt32(Console.ReadLine());


        gross = (hours * hour_salary);
        net = (gross - (gross * 18) / 100);

        Console.WriteLine("employee name : " + name);
        Console.WriteLine("employee ID : " + id);
        Console.WriteLine("type of  employement : Temporay employement");
        Console.WriteLine("total number of hours: " + hours);
        Console.WriteLine("hour salary: " + hour_salary);
        Console.WriteLine("Gross salary: " + gross);
        Console.WriteLine("net salary" + net);

    }

    public void salary(int nights, int hour_salary, double bonus, int net_before_bonus)
    {
        Console.WriteLine("please inter  your total number of hours ");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please inter  your one  hour salry ");

        hour_salary = Convert.ToInt32(Console.ReadLine());
        gross = (hours * hour_salary);
        bonus = ((gross * 0.15) / 100);


        net_before_bonus = (gross - ((gross * 18) / 100));
        net = Convert.ToInt32(net_before_bonus + bonus);


        Console.WriteLine("employee name : " + name);
        Console.WriteLine("employee ID : " + id);
        Console.WriteLine("type of  employement : evening employment");
        Console.WriteLine("total number of hours: " + hours);
        Console.WriteLine("hour salary: " + hour_salary);
        Console.WriteLine("Gross salary: " + gross);
        Console.WriteLine("net salary: " + net);




    }

}

