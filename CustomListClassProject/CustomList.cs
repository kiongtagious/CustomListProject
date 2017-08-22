using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    //Count Property
    public class CustomList<T>
    {
        public static void Count()
        {
            List<string> NFLTeams = new List<string>();
            NFLTeams.Add("Packers");
            NFLTeams.Add("Bears");
            NFLTeams.Add("Vikings");

            Console.WriteLine("{0} NFLTeams:", NFLTeams.Count);
           

        }
        //Add Method
        public static double AddMethod(double firstNumber, double secondNumber)
        {
            double a = firstNumber = 5;
            double b = secondNumber = 5;
            return a + b;
        }
        //Remove Method
        public void RemoveAllWords()
        {
            string[] wordsList = "I like to code!".Split(' ');
            string removeAll = "null";
            string result = removeAll;

            foreach (string word in removeAll.Split(' '))
            {
                if (wordsList.Contains(word.ToUpper()))
                {
                    int start = result.IndexOf(word);
                    result = result.Remove(start, word.Length);
                }
            }
            
        }
        //ToString Method
        public static void InsertLetterAtIndex()
        {
            string words = "NFL  LB";
            string modified = words.Insert(4, "M");
            Console.WriteLine("The new string is '{0}'", modified);

        }
        //Iterration Method
        public static void IterrateEvenZeroToTwelve()
        {
            List<int> numbers = new List<int>() { 0, 2, 4, 6, 8, 10, 12 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);

            }
        }
        //Zip Method
        public static void ZipWords()
        {
            string[] firstWords = { "Coding", "is" };
            string[] secondWords = { "very", "fun!" };

            var allWords = firstWords.Zip(secondWords, (first, second) => first + " " + second);

            foreach (var word in allWords)
                Console.WriteLine(word);
        }
        //Overload + Method
        public static CustomList<T> operator +(CustomList<T> stringlist, CustomList<T> intlist)
        {
            CustomList<T> result = stringlist + intlist;

            return new CustomList<T>();
                
        }
        //Overload - Method
        public static CustomList<T> operator -(CustomList<T> stringlist, CustomList<T> intlist)
        {
            CustomList<T> result = stringlist - intlist;

            return new CustomList<T>();

        }



    }
    }


