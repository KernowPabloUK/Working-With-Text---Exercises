using System;
using System.Collections.Generic;
using System.Text;

namespace Working_With_Text___Exercises
{
    internal class Program
    {

        // Note: For all these exercises, ignore input validation unless otherwise specified.Assume the user provides input in the format that the program expects.

        #region Instructions

        // 1- Write a program and ask the user to enter a few numbers separated by a hyphen.
        // Work out if the numbers are consecutive.
        // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive";
        // otherwise, display "Not Consecutive".

        // 2- Write a program and ask the user to enter a few numbers separated by a hyphen.
        // If the user simply presses Enter, without supplying an input, exit immediately;
        // otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.

        // 3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00).
        // A valid time should be between 00:00 and 23:59.
        // If the time is valid, display "Ok"; otherwise, display "Invalid Time".
        // If the user doesn't provide any values, consider it as invalid time.

        // 4- Write a program and ask the user to enter a few words separated by a space.
        // Use the words to create a variable name with PascalCase.
        // For example, if the user types: "number of students", display "NumberOfStudents".
        // Make sure that the program is not dependent on the input.
        // So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

        // 5- Write a program and ask the user to enter an English word.
        // Count the number of vowels (a, e, o, u, i) in the word.
        // So, if the user enters "inadequate", the program should display 6 on the console.

        #endregion

        static void Main(string[] args)
        {
            #region Exercise 1

            Console.WriteLine("Please enter a series of numbers seperated by a hyphen");
            string userEntryEX1 = Console.ReadLine();
            string[] userEntryArrayEX1 = userEntryEX1.Split('-');
            List<int> intListEX1 = new List<int>();

            foreach (string itemEX1 in userEntryArrayEX1)
            {
                int convertedNumberEX1 = Convert.ToInt32(itemEX1);
                intListEX1.Add(convertedNumberEX1);
            }
            intListEX1.Sort();
            bool consecutiveSeries = true;
            for (int numberEX1 = 1; numberEX1 < intListEX1.Count; numberEX1++)
            {
                if (intListEX1[numberEX1]  != intListEX1[numberEX1 - 1] + 1)
                {
                    consecutiveSeries = false;
                    break;
                }
            }
            if (consecutiveSeries == true)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
            Console.WriteLine(String.Empty);

            #endregion

            #region Exercise 2

            Console.WriteLine("Please enter a series of numbers seperated by a hyphen (can include duplicates)");
            string userEntryEX2 = Console.ReadLine();
            List<int> duplicatesList = new List<int>();
            if (!string.IsNullOrWhiteSpace(userEntryEX2))
            {
                string[] stringArrayEX2 = userEntryEX2.Split('-');
                List<int> intListEX2 = new List<int>();

                foreach (string itemEX2 in stringArrayEX2)
                {
                    int convertedNumberEX2 = Convert.ToInt32(itemEX2);
                    intListEX2.Add(convertedNumberEX2);
                }
                foreach (int itemEX2 in intListEX2)
                {
                    if (intListEX2.IndexOf(itemEX2) != intListEX2.LastIndexOf(itemEX2))
                    {
                        if (!duplicatesList.Contains(itemEX2))
                        {
                            duplicatesList.Add(itemEX2);
                        }
                    }
                }
                if (duplicatesList.Count < 1)
                {
                    Console.WriteLine("No duplicates");
                }
                else
                {
                    Console.WriteLine("The duplicate items are: ");
                    foreach (int itemEX2 in duplicatesList)
                    {
                        Console.Write($"{itemEX2} ");
                    }
                    Console.WriteLine(string.Empty);
                }
            }
            Console.WriteLine(String.Empty);


            #endregion

            #region Exercise 3

            Console.WriteLine("Please enter a time value in the 24-Hour time format");
            string userEntryEX3 = Console.ReadLine();
            string blankString = string.Empty;
            DateTime minimumTime = DateTime.MinValue;
            DateTime maximumTime = DateTime.MaxValue;
            if (userEntryEX3 == blankString)
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                DateTime dateTime = Convert.ToDateTime(userEntryEX3);
                if (dateTime >= minimumTime || dateTime <= maximumTime)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }
            Console.WriteLine(String.Empty);


            #endregion

            #region Exercise 4

            Console.WriteLine("Please enter a few words seperated by a space");
            string userEntryEX4 = Console.ReadLine();
            string toLowerUserEntryEX4 = userEntryEX4.ToLower();
            string[] stringArrayEX4 = toLowerUserEntryEX4.Split(' ');
            foreach (string wordEX4 in stringArrayEX4)
            {
                Console.Write($"{char.ToUpper(wordEX4[0]) + wordEX4.Substring(1)}");
            }
            Console.WriteLine(String.Empty);
            Console.WriteLine(String.Empty);


            #endregion

            #region Exercise 5

            Console.WriteLine("Please enter any word from the English language...");
            char vowelA = 'A';
            char vowelE = 'E';
            char vowelI = 'I';
            char vowelO = 'O';
            char vowelU = 'U';
            int resultEX5 = 0;
            string userEntryEX5 = Console.ReadLine();
            string capitaliseUserEntryEX5 = userEntryEX5.ToUpper();
            char[] charArrayEX5 = capitaliseUserEntryEX5.ToCharArray();
            foreach (char character in charArrayEX5)
            {
                if (character == vowelA || character == vowelE || character == vowelI || character == vowelO || character == vowelU)
                {
                    resultEX5 += 1;
                }
            }
            Console.WriteLine($"The number of vowels in your word are: {resultEX5}");


            #endregion
        }
    }
}
