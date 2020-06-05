using System;
using System.Collections.Generic;

namespace DetectText
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = EnterText();
            string namesSearch = EnterSearchQuery();

            Result(namesList, namesSearch);

            Console.ReadLine();
        }
        public static List<string> EnterText()
        {
            List<string> temporaryList = new List<string>();
            string userInput;
            bool run = true;
            while (run)
            {
                Console.Write("Input name: ");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "x".ToLower())
                {
                    run = false;
                    continue;
                }
                temporaryList.Add(userInput.ToLower());
            }
            return temporaryList;
        }
        public static string EnterSearchQuery()
        {
            Console.Write("Enter name to search for: ");
            return Console.ReadLine();
        }
        public static void Result(List<string> list, string searchString)
        {
            int counter = 0;
            foreach (var li in list)
            {
                if (li.ToLower() == searchString.ToLower())
                {
                    counter++;
                }
            }
            Console.WriteLine($"The search query matched the initial inputs {counter} times.");
        }
    }
}