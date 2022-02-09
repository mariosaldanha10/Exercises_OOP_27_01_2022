using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_OOP_27_01_2022.Exercises
{
    public class Question03
    {
        //constructor
        public Question03()
        {

        }
    
    public void timeANDminutes()
        {
            Console.WriteLine("Enter the total amount of time in minutes");
            int totalTimeMinutes = int.Parse(Console.ReadLine());

            var resultNum = TimeSpan.FromHours(totalTimeMinutes);

            Console.WriteLine($"The amount in hours: {resultNum.TotalHours}h.");
            Console.WriteLine($"The amount in minutes: {resultNum.TotalMinutes}m.");
        }
    }






}
