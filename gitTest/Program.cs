using System;

namespace gitTest {
    class Program {
        static void Main(string[] args) {
            int number = 1;
            string day = "";

            while (number > 0 && number < 8) {
                Console.Write("Write a number from 1 to 7: ");
                number = int.Parse(Console.ReadLine());

                switch (number) {
                    case 1:
                        day = "Sanday";
                        break;
                    case 2:
                        day = "Mondey";
                        break;
                    case 3:
                        day = "Tuesday";
                        break;
                    case 4:
                        day = "Wednesday";
                        break;
                    case 5:
                        day = "Thursday";
                        break;
                    case 6:
                        day = "Friday";
                        break;
                    case 7:
                        day = "Saturday";
                        break;
                    default:
                        day = "Invalid value";
                        break;
                }
                if (number > 1 && number < 7) {
                    Console.WriteLine("Day: " + day + " - Weekday");
                } else if (number == 1 || number == 7){
                    Console.WriteLine("Day: " + day + " - Weekend");
                }
                else {
                    Console.WriteLine(day);
                }
            }
        }
    }
}
