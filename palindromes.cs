using System;

// With Reverse Method
// class Program
//     {
//         static void Main()
//         {
//             Console.WriteLine("Welcome to the Palindrome Tracker");
//             Console.WriteLine("Enter a word:");
//             string userInput = Console.ReadLine().ToLower();
//             char[] userArray = userInput.ToCharArray();
//             char[] reverseArray = (char[]) userArray.Clone();
//             Array.Reverse(reverseArray);

//             string reverseString = String.Join("", reverseArray);

//             if (userInput == reverseString)
//             {
//                 Console.WriteLine("This is a palindrome!");
//             }
//             else
//             {
//                 Console.WriteLine("This is NOT a palindrome!");
//             }

//         }
//     }

// Without Reverse Method
class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Palindrome Tracker");
            Console.WriteLine("Enter a word:");
            string userInput = Console.ReadLine().ToLower();
            int j = userInput.Length - 1; //The letter 'j' is the pointer of the last letter. The letter 'i' is the pointer of the first letter.
            bool flag = true;
                for (int i = 0; i < userInput.Length / 2; i++)
                {
                    if (userInput[i] != userInput[j])
                    {
                        flag = false;
                        break;
                    }
                    j--;
                }
            if (flag == true)
            {
                Console.WriteLine("This is a palindrome!");
            }
            else
            {
                Console.WriteLine("This is NOT a palindrome!");
            }
        }
    }

   
   