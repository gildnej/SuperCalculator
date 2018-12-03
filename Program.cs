using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculator
{//***********************************************
 // Jacob Gildner
 // CIT 110
 // CapStoneProject
 // John Veils
 // 12/02/2018
//************************************************
    class Program
    {

        static void Main(string[] args)
        {
            

            DisplayHeader("the Calculator");
            DisplayWelcomeScreen();
            DisplayMainMenu();
            DisplayContinuePrompt();
        }

        static void DisplayMainMenu()
        {
            bool applicationLoopRunning = true;
            
            while (applicationLoopRunning)
            
            { 

                byte sel;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine();

                Console.WriteLine("*******************************");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit Calculator");
                Console.WriteLine("*******************************");
                Console.Write("Selection:");
                sel = Convert.ToByte(Console.ReadLine());
                DisplayContinuePrompt();

                switch (sel)
                {  
                    case 1:
                        // Clear the console
                        Console.Clear();
                        // Execute Addition()
                        Addition();
                        break;

                    case 2:
                        // Clear the console
                        Console.Clear();
                        // Execute Substraction()
                        Substraction();
                        break;

                    case 3:
                        // Clear the console
                        Console.Clear();
                        // Execute Multiplication()
                        Multiplication();
                        break;

                    case 4:
                        // Clear the console
                        Console.Clear();
                        // Execute Division()
                        Division();
                        break;

                    case 5:
                        // Clear Console
                        Console.Clear();
                        ExitCalculator();
                        applicationLoopRunning = false;
                        break;

                    default: 
                        break;
                }
                  
            }
        }

        static void ExitCalculator()
        {
            Console.Clear();
            Console.WriteLine("\t\tThank You For using My Calculator");
            
        }

        static void Division()
        {
            //Declare Variables
            double num1, num2, res;
            //Basic UI
            Console.WriteLine("///////////Division///////////");
            Console.Write("Number 1: ");
            // Users input and converting it
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            // Users input and converting it
            num2 = Convert.ToDouble(Console.ReadLine());
            // numbers into one variable
            res = num1 / num2;
            // the results
            Console.WriteLine(num1 + "/" + num2 + "=" + res);
            Console.ReadKey(true);
            DisplayContinuePrompt();
        }

        static void Multiplication()
        {
            //Declare Variables
            double num1, num2, res;
            //Basic UI
            Console.WriteLine("***********Multiplication************");
            Console.Write("Number 1: ");
            // Users input and converting it
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            // Users input and converting it
            num2 = Convert.ToDouble(Console.ReadLine());
            // numbers into one variable
            res = num1 * num2;
            // the results
            Console.WriteLine(num1 + "*" + num2 + "=" + res);
            Console.ReadKey(true);
            DisplayContinuePrompt();
        }

        static void Substraction()
        {
            //Declare Variables
            double num1, num2, res;
            //Basic UI
            Console.WriteLine("---------SubsTraction---------");
            Console.Write("Number 1: ");
            // Users input and converting it
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            // Users input and converting it
            num2 = Convert.ToDouble(Console.ReadLine());
            // numbers into one variable
            res = num1 - num2;
            // the results
            Console.WriteLine(num1 + "-" + num2 + "=" + res);
            Console.ReadKey(true);
            DisplayContinuePrompt();
        }

        static void Addition()
        {
            //Declare Variables
            double num1, num2, res;
            //Basic UI
            Console.WriteLine("+++++++++Addition++++++");
            Console.Write("Number 1: ");
            // Users input and converting it
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            // Users input and converting it
            num2 = Convert.ToDouble(Console.ReadLine());
            // numbers into one variable
            res = num1 + num2;
            // the results
            Console.WriteLine(num1 + "+" + num2 + "=" +res);
            Console.ReadKey(true);
            DisplayContinuePrompt();
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tWelcome to the Calculator");
            DisplayContinuePrompt();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tThank You For using My App");
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void DisplayHeader(string headText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(headText);
            Console.WriteLine();
        }
    }
}
