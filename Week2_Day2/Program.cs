using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day2
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int counter= 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //string greeting = "My name is Little Bill";
            //string[] words = greeting.Split();
            ////is the same as typing:
            ////string[] words = {"My", "name", "is", "Little", "Bill"}
            //for(int i = 0; i < words.Length; i++ )
            //{
            //    Console.WriteLine(words[i]);
            //}

            //Create an array called days with the elements Monday, Tuesday, and Wednesday. 
            //Using a For Loop, print the elements of the days array.

            //string[] days = { "Monday", "Tuesday", "Wednesday" };

            //for (int i = 0; i <= 2; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            ////Start with the string "Once upon a time" and create an array called storyWords 
            ////using the Split method.Reverse the order of the elements in the array and using a For Loop, print each word.

            //string wholePhrase = "Once upon a time";
            //string[] storyWords = wholePhrase.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            //}


            //string[] bands = { "The Trews", "Sam Roberts Band", "Tragically Hip", "The Sheepdogs", "Arkells" };
            //foreach(string band in bands)
            //{
            //    Console.WriteLine(band);
            //}

            //Write a program that takes your favorite foods and prints them out one at a time. (Use a foreach loop.)

            string[] favFoods = { "ribs", "pierogi", "steak", "mussels", "crabcakes" };
            foreach (string food in favFoods)
            {
                Console.WriteLine(food);
            }

            //Create an array of lucky numbers(just any numbers you like). Using a foreach loop, print the following:
            //If the array holds the numbers 3, 5, 7, 11, 15, then the printed result should say
            //Your Lucky Number is: 3
            //Your Lucky Number is: 5
            //Your Lucky Number is: 7
            //Your Lucky Number is: 11
            //Your Lucky Number is: 15

            int[] luckyNumbers = { 42, 33, 7, 17, 6, 21 };
            //Array.Sort(luckyNumbers);
            foreach (int number in luckyNumbers)
            {
                Console.WriteLine("Your Lucky Number is: " + number);
            }












            //for(int i = 0; i <= 10; i++)
            //{
            //    //Console.WriteLine(i);

            //}

            //for(int counter = 50; counter <= 100; counter++)
            //{
            //    //Console.WriteLine(counter);
            //}
            //string greetings = "My name is Kathleen";
            //string[] words = greetings.Split();

            //for (int i = 0; i < words.Length; i++);
            //{
            //    Console.WriteLine(words[i]);
            //}

        }
    }
}
