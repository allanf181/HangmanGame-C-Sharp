/*
 * author: creativecub
 * translator: armelin1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HangmanGame";
            bool a = true;
            Console.WriteLine("Bem-vindo ao Hangman(Forca)!");
            string[] listwords = new string[10];
            listwords[0] = "ovelha";
            listwords[1] = "cabra";
            listwords[2] = "computador";
            listwords[3] = "america";
            listwords[4] = "melancia";
            listwords[5] = "sorvete";
            listwords[6] = "jasmim";
            listwords[7] = "abacaxi";
            listwords[8] = "laranja";
            listwords[9] = "manga";
            Random randGen = new Random();
            var idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Por favor, insira seu palpite: ");

            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';

            while (a)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
                if (new string(guess) == mysteryWord)
                    a = false;
            }
            Console.WriteLine("Você acertou a palavra :)");
            Console.Read();
        }
    }
}
