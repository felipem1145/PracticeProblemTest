using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPracticetest
{
    class Program
    {
        static void Main(string[] args)
        {

            //EXERCISE 1
            /*
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = Convert.ToInt32(Console.ReadLine());
            int valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor2 > valor1)
            {
                if(valor2 > valor3)
                {
                    Console.WriteLine(valor2);
                }
                else
                {
                    Console.WriteLine(valor3);
                }
            }
            else
            {
                if (valor1 > valor3)
                {
                    Console.WriteLine(valor1);
                }
                else
                {
                    Console.WriteLine(valor3);
                }
            }
            Console.ReadLine()
            */

            //EXERCISE 2
            /*
          

            double quizScore = Convert.ToDouble(Console.ReadLine());
            double midScore = Convert.ToDouble(Console.ReadLine());
            double finalScore = Convert.ToDouble(Console.ReadLine());

            double avg = (quizScore + midScore + finalScore) / 3;

            if(avg >= (5 * 0.9))
            {
                Console.WriteLine("Your grade is A");
            }else if( avg >= (5*0.7) ){
                Console.WriteLine("Your grade is B");
            }else if(avg >= (5 * 0.5))
            {
                Console.WriteLine("Your grade is C");
            }
            else
            {
                Console.WriteLine("Your grade is F");
            }
            Console.ReadLine()
            */

            //EXERCISE 3 

            /*

            string number = Console.ReadLine();
            int i = 0;
            foreach (char num in number)
            {
                i++;
            }
            Console.WriteLine(i);
            Console.ReadLine()

            */

            //EXERCISE 4

            /*
            int i;
            int j = 0;
            for (i = 33; i <= 175; i++) {
                Console.Write((char)i);
                j++;
                if (j == 9)
                {
                    Console.WriteLine();
                    j = 0;
                }
            }

            Console.ReadLine();
            */

            //EXERCISE 5

            string input = Console.ReadLine();
            int i = 0;
            int j;
            for (j = 0; j < input.Length; j++)
            {
                char caracter = input[j];
                if (caracter == ' ')
                {
                    i++;
                }
            }
            Console.WriteLine(i);

            Console.ReadLine();


        }
    }
}
