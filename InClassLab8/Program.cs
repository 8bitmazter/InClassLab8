using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab8
{
    class Info
    {
        static void Main(string[] args)
        {
            for (int i = 0; i == 0;)
            {
                Console.WriteLine("Please choose a student ID by slecting the numbers 1-19");

                string ClassStudents = Console.ReadLine(); //using string to obtain user's information

                try
                {
                    classInfo.SudentClassInfo(ClassStudents);
                }
                catch (IndexOutOfRangeException) //catch outside of the numbers
                {
                    Console.WriteLine("Please choose a number between 1 - 19");
                }
                catch (FormatException) //used for if user tries to user characters instead of numbers
                {
                    Console.WriteLine("Please user proper format. Please select a number between 1 - 19");
                }
                Console.WriteLine("Would you like to get information on another student? Please choose y/n");
                string cont = Console.ReadLine().ToLower();
                for (int c = 0; c == 0;)
                {
                    if (cont == "n")
                    {
                        Console.WriteLine("Good bye");
                        i++;
                        c++;
                    }
                    else if (cont == "y")
                    {
                        c++;
                    }
                    else if (cont != "n" || cont != "y")
                    {
                        Console.WriteLine("Please choose y/n");
                        cont = Console.ReadLine().ToLower();
                    }
                }
            }
        }

    }
}

