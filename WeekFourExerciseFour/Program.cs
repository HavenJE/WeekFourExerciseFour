

// Exercise 4
// The Nimble Fingers Typing School assigns grades based on words typed per minute, as shown in the following table.
// Write a program named TypingGrades that allows a user to enter a student’s number of words typed. The output is the letter grade.


// My solution did not work! 

//class TypingGrades
//{
//    static void Main()
//    {
//        int[] wordsTyped = { 0, 16, 31, 51, 76 };
//        char[] grades = { 'F', 'D', 'C', 'B', 'A' };

//        int userTypedWords, i;

//        Console.WriteLine("Enter how many words have you typed below: ");
//        userTypedWords = Convert.ToInt32(Console.ReadLine());

//        for (i = 0; i < grades.Length + 1; i++)
//        {
//            if (userTypedWords <= grades[i])
//            {
//                Console.WriteLine("For {0} words, the grade achieved is: ({1}).", userTypedWords, grades[i]);
//            }
//        }
//    }
//}


// OLA solution 
class TypingGrades
{
    static void Main()
    {
        int[] wordsTyped = { 0, 16, 31, 51, 76 };
        char[] grades = { 'F', 'D', 'C', 'B', 'A' };

        int userTypedWords, i;

        Console.WriteLine("Enter how many words have you typed below: ");
        userTypedWords = Convert.ToInt32(Console.ReadLine());

        for (i = wordsTyped.Length - 1; i >= 0; i--)
        {
            if (userTypedWords >= wordsTyped[i])
            {
                Console.WriteLine("For {0} typed words, grade {1} is achieved.", userTypedWords, grades[i]);
                i = 0;
            }
        }
    }
}

// The loop starts at the last index of the wordLimits array (wordLimits.Length - 1).
// It continues as long as x is greater than or equal to 0 (i >= 0) 
// In each iteration, it checks if the input speed is greater than or equal to the value at wordLimits[x]. ==> if (userTypedWords >= wordsTyped[i])
// If it is, the program outputs the corresponding grade based on grades[x] and terminates the loop by setting x = 0.