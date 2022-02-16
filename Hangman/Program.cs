using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = new string[2] { "sara", "Zohreh" };
            string name1 = nameArray[0];
            
            char[] letterArray = new char[name1.Length];
            
           List<char> guess = new List< char>();

            for (int i = 0; i < name1.Length; i++)
            {
                letterArray[i] = name1[i];

            }
            for (int i = 0; i < 10; i++)
            {
                guess[i] = char.Parse (Console.ReadLine());


                foreach (char letter in letterArray)
                {
                    if (guess[i]== letter )

                    {
                        Console.WriteLine(" good");

                    }
    ;
                }
            }
           
                   
        
        }
       

    }
}
