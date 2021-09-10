using System;

namespace week0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type a number and press 'Enter'!");
            var year = 0; 
            try {
                year = Convert.ToInt32(Console.ReadLine());
            } catch (Exception e) {
                Console.WriteLine("Not a valid year, sorry! Please try again!", e);
            }
            
            if(year != 0) {
                if(year >= 1582) {
                    bool statement = IsLeapYear(year);

                    if(statement) { 
                        Console.WriteLine("Yay!");
                    }
                    else { 
                        Console.WriteLine("Nay!");
                    }
                }
                else {                 
                    Console.WriteLine("Not a valid year, it is to low! Please try again!");
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
                else return false;
            }
            else return false;
        }
    }
}
