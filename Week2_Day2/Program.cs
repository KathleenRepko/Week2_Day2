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
            //foreach (string band in bands)
            //{
            //    Console.WriteLine(band);
            //}

            //Write a program that takes your favorite foods and prints them out one at a time. (Use a foreach loop.)

            //string[] favFoods = { "ribs", "pierogi", "steak", "mussels", "crabcakes" };
            //foreach (string food in favFoods)
            //{
            //    Console.WriteLine(food);
            //}

            //Create an array of lucky numbers(just any numbers you like). Using a foreach loop, print the following:
            //If the array holds the numbers 3, 5, 7, 11, 15, then the printed result should say
            //Your Lucky Number is: 3
            //Your Lucky Number is: 5
            //Your Lucky Number is: 7
            //Your Lucky Number is: 11
            //Your Lucky Number is: 15

            //int[] luckyNumbers = { 42, 33, 7, 17, 6, 21 };
            ////Array.Sort(luckyNumbers);
            //foreach (int number in luckyNumbers)
            //{
            //    Console.WriteLine("Your Lucky Number is: " + number);
            //}


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


            //for(int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("Do you want to play the game? (YES/NO)");
            //string playAgain = Console.ReadLine();
            //while(playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again (YES/NO)");
            //    playAgain = Console.ReadLine();
            //}


            //Ask the user if he / she / they would like to check the patient in for his / her / their appointment
            //Using a While Loop, run the following sequence only if the user's answer is not YES
            //Print "PATIENT CHECK IN SYSTEM"
            //Ask the user for the client's full name
            //Ask the user for the client's 6-digit patient ID
            //Ask the user for the client's appointment time (i.e. 2:00 PM)
            //Ask the user if he / she / they would like to check the patient in for his / her / their appointment

            //Console.WriteLine("Would you like to check the patient in for the patient's appointment? (YES/NO)");
            //string checkIn = Console.ReadLine().ToUpper();
            //while (checkIn == "YES" )
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    Console.WriteLine("Please enter patient's full name.");
            //    string patientName = Console.ReadLine();
            //    Console.WriteLine("Please enter patient's six-digit ID number.");  //How to limit int to 6 digits? GetIntegerDigitCount
            //    int patientID = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please enter patient's appointment time (e.g., 2:00 PM)");
            //    string apptTime = Console.ReadLine();
            //    Console.WriteLine("Would you like to complete the check-in process for this patient? (YES/NO)");
            //    string checkInComplete = Console.ReadLine();
            //    Console.WriteLine("Would you like to check in another patient? (YES/NO)");
            //    checkIn = Console.ReadLine().ToUpper();
            //}


            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");

            //Console.WriteLine("Thanks for playing the game.");


            //Ask the user for the class they would like to add to their GPA calculation
            //Ask the user for the letter grade for the class (no + or - grades)
            //Ask the user if they have another class they would like to add to their GPA calculation
            //Using a Do While Loop, repeat the code if the user says "YES"

            //string className;
            //char classGrade;
            //string anotherClass;
            //do
            //{
            //    Console.WriteLine("Please enter the name of the class you would like to add to your GPA calculation.");
            //    className = (Console.ReadLine());
            //    Console.WriteLine("Please enter the letter grade for that class. (no +/-)");
            //    classGrade = char.Parse(Console.ReadLine());
            //    Console.WriteLine("Would you like to add another class to your GPA calculation? (YES/NO)");
            //    anotherClass = (Console.ReadLine().ToUpper());
            //}
            //while (anotherClass == "YES");


            //for(int i= 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            for (int i = 1; i <= 20; i++)
            {
                if (i % 13 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("The loop has finished.");




        }

    }

}
