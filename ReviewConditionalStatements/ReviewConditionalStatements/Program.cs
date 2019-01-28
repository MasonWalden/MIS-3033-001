//Mason Walden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewConditionalStatements
{
    class Program
    {
        //static double sum = 0; Class Level variable
        static void Main(string[] args)
        {
            /*int age = 0;
            string MessageForUser = "Please enter your age";
            Console.WriteLine(MessageForUser);
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 21)
            {
                Console.WriteLine("You are old enough to drive, vote and buy alcohol.");
            }
            else if (age >= 18 && age < 21)
            {
                Console.WriteLine("You are old enough to drive and vote, but not buy alcohol.");
            }
            else if (age >= 16 && age < 18)
            {
                Console.WriteLine("You are old enough to drive but you can not vote or buy akcohol.");
            }
            else
            {
                Console.WriteLine("You are too young to drive, vote or buy alcohol.");
            }

            string[] firstNames = new string[3];
            string[] lastNames = new string[3];
            firstNames[0] = "Mason";
            lastNames[0] = "Walden";
            firstNames[1] = "Steve";
            lastNames[1] = "Jobs";
            firstNames[2] = "Bill";
            lastNames[2] = "Gates";

            for (int i = 0; i < firstNames.Length; i++)
            {
                if (lastNames[i] == null && firstNames[i] == null)
                {

                }
                else
                {
                    Console.WriteLine($"{lastNames[i]}, {firstNames[i]}");
                }
            }*/

            /*List<double> examScores = new List<double>();
            examScores.Add(75.5);
            examScores.Add(50);
            examScores.Add(25.5);
            examScores.Add(7);
            examScores.Add(100);
            double average = 0;
            foreach (var item in examScores)
            {
                average += item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Your average exam score is {(average/ examScores.Count).ToString("N2")}");
            Console.ReadLine();*/

            /*Dictionary<int, double> studentGrades = new Dictionary<int, double>();
            studentGrades.Add(1, 0.97);
            studentGrades.Add(2, 0.47);

            Console.WriteLine(studentGrades[1].ToString("P2"));
            if (studentGrades.ContainsKey(0) == true)
            {
                Console.WriteLine(studentGrades[0]);
            }
            else
            {
                studentGrades.Add(0, 1.0);
            }
            Console.WriteLine(studentGrades[0]);
            Console.ReadKey();*/
            
            double result = Addition(5.5, 2);
            Console.WriteLine(result);
            Console.ReadKey();

            double val1 = 10.5;
            double val2 = 1.5;

            Subtraction(val1, val2);



        }

        private static void Subtraction(double val1, double val2)
        {
            Console.WriteLine($"{val1 - val2}");
        }

        static double Addition(double value1, double value2)
            {
                double sum = value1 + value2;
                return sum;
            }

        

    }
}
