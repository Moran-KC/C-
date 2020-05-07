using System;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Lesson5Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie chocolate = new Cookie();
            Cookie chocchips = new Cookie();
            Cookie nugat = new Cookie();

            nugat.Eggs = 2;
            nugat.Flour = 500;
            nugat.Gluten = true;
            nugat.Sugar = 200;

            chocolate.Eggs = 3;
            chocolate.Flour = 400;
            chocolate.Gluten = false;
            chocolate.Sugar = 150;

            Console.WriteLine("the first cookie recepie:");
            printInfo(chocolate);
            Console.WriteLine("the second cookie recepie:");
            printInfo(nugat);

            nugat.Sugar = 250;
            Console.WriteLine("the first cookie recepie:");
            printInfo(chocolate);
            Console.WriteLine("the second cookie recepie:");
            printInfo(nugat);

            chocolate = nugat;

            nugat.Eggs = 6;
            Console.WriteLine("the first cookie recepie:");
            printInfo(chocolate);
            Console.WriteLine("the second cookie recepie:");
            printInfo(nugat);

            Car c1 = new Car(120);
            Console.WriteLine(c1.Getdetails());
            int num;
            Console.WriteLine("Enter In How much to accelerate the car speed?");
            num = Convert.ToInt32(Console.ReadLine());
            c1.SetspeedAccelerate(num);
            Console.WriteLine(c1.Getdetails());
            c1.Setspeedslowdown(2);
            Console.WriteLine(c1.Getdetails());
            c1.stop();
            Console.WriteLine(c1.Getdetails());


        }

        public static void printInfo(Cookie c1)
        {
            Console.WriteLine( $"Amount of eggs: {c1.Eggs} .\nAmount of flour:{c1.Flour} .\nAmount of sugar: {c1.Sugar} .\nContains Gluten? {c1.Gluten}.");
        }

    }
}


