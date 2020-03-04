using System;

namespace Words_In_A_Sentance
{
    class WordsInASentance
    {
        /* This program is intended to take any sentance and output how many words are in that sentance. A real world example might be a
         * college course telling you to submit a 500 word essay. Something similar to this may be used for the count.*/
        static void Main()
        {
            WordCount("Hello World!"); // This represents the input of the sentance; this could also be done asking the user and having it retun the count.
            WordCount("My wife is the greatest of all!"); // Additionals test values.
            WordCount("Today I went to the park and there was no body there."); // Additional test values.
            WordCount(""); //Test Value without any words. 
        }

        public static void WordCount(string input)
        {
            int count = 0; //This will be used to count how many words are in the sentance. Currently initiated to zero.

            var str = input.Split(" "); // .Split will break apart a string at an indicated value... here we are using each space.
            if (string.IsNullOrEmpty(input)) // Test Value is suppose to catch that there is no words in the sentance but not currently working??
            {
                Console.WriteLine("There are no words in your sentance."); //If it picks up there are no words, it should tell the user rather than throwing an exception.
            }
               
            foreach(string word in str) // For each word in the string...
            {
                count++; // it will add to the count.
            }
            Console.WriteLine("There are "+ count + " words in the sentance."); // Then it returns the count to the user.
        }
    }
}
