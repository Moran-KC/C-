using System;

namespace Matala1
{
    class Program
    {
        static void Main(string[] args)
        {
            //הגדרת משתנים
            int num;
            int mul;
            //קליטת גודל מערך
            Console.WriteLine("Enter num of elements");
            num=Convert.ToInt32(Console.ReadLine());
            //הגדרת המערך לאחר הקליטה של הגודל-בכדי שתעבוד ההרצה
            int []arr = new int[num];
            //קליטת מס למכפלה 
            Console.WriteLine("enter num of mul");
            mul = Convert.ToInt32(Console.ReadLine());
            //מילוי המערך לפי דרישה
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * mul;
                Console.Write(arr[i] + ", ");

            }
            //הדפסת מס התאים , מס המכפלה , וכל תאי המערך
            Console.WriteLine($"Num of elements: {num}, num to mul:{mul}");
        }
    }
}
