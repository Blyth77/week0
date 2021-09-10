using System;

namespace week0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type a number and press 'Enter'!");
            var year = Convert.ToInt32(Console.ReadLine());
            
            if(year != 0) {
                bool statement = IsLeapYear(year);

                if(statement) { 
                    Console.WriteLine("Yay!");
                }
                else { 
                    Console.WriteLine("Nay!");
                }
            }
        }

        public static bool IsLeapYear(int year) 
        {            
            if (year % 4 == 0) {
                if (year % 100 != 0){
                   return true;
                }
                else if (year % 400 == 0) {
                    return true;
                } 
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }
    }
}
