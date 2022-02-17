using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = new string[3] { "sara", "zohreh", "kiana" };
            string name = nameArray[1];
            Console.WriteLine("\nThe length of the name is : ");
            foreach (char x in name)
            {

                Console.Write("_ ");
            }

            int nameLength = name.Length;
            int amountOfTimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

            while (amountOfTimesWrong != 10 && currentLettersRight != nameLength)
            {


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
                    currentLettersRight = printname(currentLettersGuessed, name);
                    Console.Write("\r\n");

                }
                // if user was wrong
                else
                {
                    amountOfTimesWrong += 1;
                    currentLettersGuessed.Add(letterGuessed);

                    currentLettersRight = printname(currentLettersGuessed, name);
                    Console.Write("\r\n");

                }

            }
            Console.WriteLine("\r\nGame over!");


        }




        private static int printname(List<char> guessLetter, String secretword)
        {
            int counter = 0;
            int rightLetter = 0;
            foreach (char letter in secretword)
            {
                if (guessLetter.Contains(letter))
                {
                    Console.Write("\r\n");
                    Console.WriteLine(letter + "");
                    rightLetter += 1;
                }
                else
                {
                    Console.WriteLine(" ");

                }
                counter += 1;

            }
            return rightLetter;
        }

    }
}
