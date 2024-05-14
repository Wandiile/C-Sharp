using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
   internal class Program
    {
        //Global Variables
        static string name, surname, studentNumber;
        static double mark1, mark2, mark3, courseMark;
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            //LocalVariable
            int MenuOption;
            Console.WriteLine("****************************************************");
            Console.WriteLine("Welcome to the calculator app");
            Console.WriteLine("Menu Option 1: Collect data");
            Console.WriteLine("Menu Option 2: Caluclate the marks");
            Console.WriteLine("Menu option 3: Print all the details");
            Console.WriteLine("Menu Option 4: Exit the program");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Please enter a menu option between 1-4");
            MenuOption = Convert.ToInt16(Console.ReadLine());

            //Switch statement

            switch(MenuOption)
            {
                case 1:
                    CaptureUserData();
                    break;
                case 2:
                    CalculateTheMarks();
                    break;
                case 3:
                    PrintDetails();
                    break;
                case 4:
                    ExitProgram();
                    break;
                default:
                    Console.WriteLine("The menu option you have picked is invalid! Try again");
                    Console.ReadKey();
                    Menu();
                    break;
            }


        }
        static void CaptureUserData()
        {
            //Capturing the data

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Please enetr your surname");
            surname = Console.ReadLine();

            Console.WriteLine("Please enetr your student number");
            studentNumber = Console.ReadLine();

            Console.WriteLine("Please enter your marks for test1");
            mark1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter your marks for test2");
            mark2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter your marks for test3");
            mark3 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Menu();


            CalculateTheMarks();

        }
        static void CalculateTheMarks()
        {
            //Calculations
            courseMark = (mark1 * 0.25) + (mark2 * 0.35) + (mark3 * 0.40);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Menu();

            PrintDetails();
        }
        static void PrintDetails()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("Here are all your details");
            Console.WriteLine("Your name: {0}", name);
            Console.WriteLine("Your surname: {0}", surname);
            Console.WriteLine("Your student number: {0}", studentNumber);
            Console.WriteLine("Mark for Test1: {0}", mark1);
            Console.WriteLine("Mark for Test2: {0}", mark2);
            Console.WriteLine("Mark for Test3: {0}", mark3);
            Console.WriteLine("Your final mark: {0}", courseMark);

            //if statements
            if(courseMark >= 75)
            {
                Console.WriteLine("Passed with distinction!");

            }
            else if(courseMark >= 50 && courseMark < 75)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("You failed.");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        static void ExitProgram()
        {
            Console.WriteLine("Thank you for using my program see you soon");
            Console.WriteLine("Press any key to exit ");
            Console.ReadKey();
        }
    }
}
