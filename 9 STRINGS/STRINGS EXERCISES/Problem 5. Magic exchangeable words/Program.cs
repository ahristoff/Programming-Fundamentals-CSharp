using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var word1 = input[0];
            var word2 = input[1];

            bool exchange = false;
            bool wordLenght = false;

            EqualWordlenght(word1, word2, exchange, wordLenght);
            Word1GreaterWord2(word1, word2, exchange, wordLenght);
            Word2GreaterWord1(word1, word2, exchange, wordLenght);
        }

        private static void Word2GreaterWord1(string word1, string word2, bool exchange, bool wordLenght)
        {
            var count = 0;

            if (word1.Length < word2.Length)
            {
                var diff1 = 0;
                var diff2 = 0;

                for (int i = 0; i < word1.Length; i++)
                {
                    diff1 = (int)word1[i] - (int)word2[i];

                    for (int j = 0; j < word1.Length; j++)
                    {
                        diff2 = (int)word1[j] - (int)word2[j];

                        if (word1[i] == word1[j])
                        {
                            if (diff1 == diff2)
                            {
                                exchange = true;
                            }

                            else
                            {
                                exchange = false;
                                break;
                            }
                        }
                    }
                }

                for (int i = word1.Length - 1; i < word2.Length; i++)
                {

                    for (int j = 0; j < word1.Length - 1; j++)
                    {

                        if ((int)word2[i] == (int)word2[j])
                        {
                            count++;
                        }
                    }
                }

                if (count == word2.Length - word1.Length)
                {
                    wordLenght = true;
                }

                else
                {
                    wordLenght = false;
                }

                if (exchange == true && wordLenght == true)
                {
                    Console.WriteLine("true");
                }

                if ((exchange == false && wordLenght == false) || (exchange == true && wordLenght == false) || (exchange == false && wordLenght == true))
                {
                    Console.WriteLine("false");
                }
            }
        }

        private static void Word1GreaterWord2(string word1, string word2, bool exchange, bool wordLenght)
        {
            var count = 0;

            if (word1.Length > word2.Length)
            {
                var diff1 = 0;
                var diff2 = 0;

                for (int i = 0; i < word2.Length; i++)
                {
                    diff1 = (int)word1[i] - (int)word2[i];

                    for (int j = 0; j < word2.Length; j++)
                    {
                        diff2 = (int)word1[j] - (int)word2[j];

                        if (word1[i] == word1[j])
                        {

                            if (diff1 == diff2)
                            {
                                exchange = true;
                            }

                            else
                            {
                                exchange = false;
                                break;
                            }
                        }
                    }
                }

                for (int i = word2.Length - 1; i < word1.Length; i++)
                {

                    for (int j = 0; j < word2.Length - 1; j++)
                    {

                        if ((int)word1[i] == (int)word1[j])
                        {
                            count++;
                        }
                    }
                }

                if (count == word1.Length - word2.Length)
                {
                    wordLenght = true;
                }

                else
                {
                    wordLenght = false;
                }

                if (exchange == true && wordLenght == true)
                {
                    Console.WriteLine("true");
                }

                else if ((exchange == false && wordLenght == false) || (exchange == true && wordLenght == false) || (exchange == false && wordLenght == true))
                {
                    Console.WriteLine("false");
                }
            }
        }

        private static void EqualWordlenght(string word1, string word2, bool exchange, bool wordLenght)
        {

            if (word1.Length == word2.Length)
            {
                var diff1 = 0;
                var diff2 = 0;

                for (int i = 0; i < word1.Length; i++)
                {

                    diff1 = (int)word1[i] - (int)word2[i];

                    for (int j = 0; j < word1.Length; j++)
                    {
                        diff2 = (int)word1[j] - (int)word2[j];

                        if (word1[i] == word1[j])
                        {

                            if (diff1 == diff2)
                            {
                                exchange = true;

                            }

                            else
                            {
                                exchange = false;
                                break;
                            }
                        }
                    }
                }

                if (exchange == true)
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
