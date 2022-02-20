using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = new string[3] { "sara", "zohreh", "kiana" };
            int nameArrayLength = nameArray.Length;
            Random random = new Random();
            int index = random.Next(nameArrayLength);
            string name = nameArray[index];

            Console.Write("\r\n");
            Console.WriteLine("                                                  Welcome to Hangman!");
            Console.Write("\r\n");
            Console.WriteLine("\nThe length of the name is : ");

            foreach (char x in name)
            {

                Console.Write("_ ");
            }
            Console.Write("\r\n");

            int nameLength = name.Length;
            int wrongNumber = 0;
            List<char> currentLettersGuessed = new List<char>();
            int rightNumber = 0;

            while (wrongNumber != 10 && rightNumber != nameLength)
            {

                Console.Write("\r\n");

                Console.Write("\n input your guessed letter: ");
                char letterGuessed = Console.ReadLine()[0];


                //  chek if guessed letter is right
                bool right = false;
                for (int i = 0; i < name.Length; i++)

                {
                    if (letterGuessed == name[i])
                    {
                        right = true;
                    }
                }

                // if User was right
                if (right)
                {
                    currentLettersGuessed.Add(letterGuessed);
                    printname(currentLettersGuessed, name);

                    Console.Write("\r\n");
                    foreach (char c in name )
                    {
                       
                        Console.Write("_ ");
                    }

                    rightNumber++;

                }

                // if user was wrong
                else
                {
                    wrongNumber++;
                    currentLettersGuessed.Add(letterGuessed);
                    Console.Write("\r\n");
                    Console.WriteLine($" You have guessed {wrongNumber } letters incorrectly.");
                    

                    printname(currentLettersGuessed, name);

                    

                }

            }
            Console.WriteLine("\r\nGame over!");


        }




         static void  printname(List<char> guessLetter, String secretword)
        {
            int counter = 0;
            Console.Write("\r\n");
            foreach (char letter in secretword)
            {
                if (guessLetter.Contains(letter))
                {

                    Console.Write(letter + " ");
                }
                else
                {
                    Console.Write(" ");

                }
                counter += 1;

            }
            
        }

    }
}
