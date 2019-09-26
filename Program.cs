using _8040_Assinment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_First
{
    public class Program
    {
        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit \n");

                Console.WriteLine("Please select an option by entering a number:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("This is not a valid option please try again");
                }
                else
                {
                    validMenuSelect = true;
                }
            }

            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateUserInput(String rectSide)
        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {rectSide} of your rectangle: ");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine(" That is not a valid input. please try again.\n");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number cannot be less than 0.\n ");
                }
                
                else
                {
                    isValid = true;

                }

            }

            Console.WriteLine();
            return number;
        }




        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            bool validRectangleSelect = false;
            string rectangleSelection;
            int selection;

            while (validRectangleSelect == false)
            {

                
                Console.WriteLine(" To Start Press 2 ");
                rectangleSelection = Console.ReadLine();
                Console.WriteLine();

                if (/*rectangleSelection != "1" &&*/ rectangleSelection != "2")
                {
                    Console.WriteLine("That's not a valid selection, please try again.\n");
                }
                /* else if (int.Parse(rectangleSelection) == 1)
                 {
                     validRectangleSelect = true;
                     Random random = new Random();
                     int length;
                     int Width;

                     length = Math.(random.Next() * 500), +2);
                     Width = Math.((random.Next() * 500), 2);

                     Console.WriteLine($"Your given length is  {length} and width is {Width}.\n");
                     Rectangle customRectangle = new Rectangle(length, Width);
                     r = customRectangle;

                 } */
                else if (int.Parse(rectangleSelection) == 2)
                {
                    validRectangleSelect = true;

                    int length;
                    int Width;

                    length = ValidateUserInput("length");
                    Width = ValidateUserInput("Width");

                    Console.WriteLine($"Your given length is {length} and width is {Width}.\n");
                    Rectangle customRectangle = new Rectangle(length, Width);
                    r = customRectangle;
                }
            }


            selection = ValidateMenuSelection();

            while (selection != 7)
            {
                int result;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($" length is: {r.Getlength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("length");
                        r.Setlength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width is: {r.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("Width");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The Perimeter of a rectangle is: {r.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The Area of a rectangle is: {r.GetArea()}\n");
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                selection = ValidateMenuSelection();

            }

        }
    }
}