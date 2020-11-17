using System;
using System.Text;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Generate")
                {
                    Console.WriteLine($"Your activation key is: {text}");
                    break;
                }
                var token = input.Split(">>>");

                if (token[0] == "Contains")
                {
                    if (text.Contains(token[1]))
                    {
                        Console.WriteLine($"{text} contains {token[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (token[0] == "Flip")
                {
                    if (token[1] == "Upper")
                    {
                        int startIndex = int.Parse(token[2]);
                        int indexLenght = int.Parse(token[3]) - (int.Parse(token[2]));
                        string textToUpper = text.Substring(startIndex, indexLenght)
                            .ToUpper();
                        text = text.Replace(text.Substring(startIndex, indexLenght), textToUpper);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        int startIndex = int.Parse(token[2]);
                        int indexLenght = int.Parse(token[3]) - (startIndex);
                        string textToLower = text.Substring(startIndex, indexLenght)
                            .ToLower();
                        text = text.Replace(text.Substring(startIndex, indexLenght), textToLower);
                        Console.WriteLine(text);
                    }
                }
                else if (token[0] == "Slice")
                {
                    int startIndex = int.Parse(token[1]);
                    int count = int.Parse(token[2]) - startIndex;
                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }

            }
        }
    }
}
