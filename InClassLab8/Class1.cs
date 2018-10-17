using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab8
{
    public class classInfo
    {
        public static void SudentClassInfo(string ClassStudents)
        {
            int studentInfo = int.Parse(ClassStudents) - 1;
            string[,] classInfo = new string[19, 3] //Classinfo for all the students infomation
            {
                {"Andrea","Detroit","Food" },
                {"Anthony","Detroit, MI","Pizza"},
                {"Brian","Detroit, MI", "Pizza"},
                {"Camille", "Detroit, MI", "Pizza"},
                {"Clayton", "Detroit, MI", "Pizza"},
                {"Damacious", "Detroit, MI", "Chicken Alfredo"},
                {"Daniel", "Oak Park, MI", "Spaghetti"},
                {"David", "Detroit, MI", "Pizza"},
                {"Evan", "Detroit, MI", "Pizza"},
                {"Heather", "Detroit, MI", "Pizza"},
                {"Jacky","Detroit, MI","Sushi"},
                {"Jonathan", "Brighton, MI", "Korean"},
                {"Katie", "WoodHaven, MI", "Lasagna "},
                {"Luke", "Detroit, MI", "Pizza"},
                {"Maurico", "Detroit, MI ", "Pizza"},
                {"Rudy", "Detroit, MI", "Pizza"},
                {"SeanO", "Clarkston, MI", "Pasta Salad"},
                {"Steve", "Perrysburg, OH", "Pizza"},
                {"Ty", "Birch Run, MI"," "},
            };

            Console.WriteLine(classInfo[studentInfo, 0]); //This information was left since it was easier also forgot ot switch over.

            Console.WriteLine("Would you like to know their Hometown or their Favorite Food?");
            for (int a = 0; a == 0;)
            {
                string factChoice = Console.ReadLine().ToLower(); //factchoice for outputing the facts
                if (factChoice == "hometown")
                {
                    Console.WriteLine(classInfo[studentInfo, 1]);
                    break;
                }
                else if (factChoice == "favorite food")
                {
                    Console.WriteLine(classInfo[studentInfo, 2]);
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose between 'Hometown' and 'Favorite Food'");
                }
            }
        }
    }
}
