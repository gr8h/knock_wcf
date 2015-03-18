using System;

namespace knockknock.Domain
{
    public static class ReverseWord
    {
        //Reverse words using Array.Reverse 
        public static string ReverseWordsInString(string s)
        {
            try
            {
                char[] array = s.ToCharArray();
                Array.Reverse(array);
                return new String(array);
            }
            catch
            {
                throw new ArgumentException("Error while reversing.");

            }
        }

        //Reverse words using for loop and swap operations
        public static string ReverseWordsInString2(string s)
        {
            char[] chars = s.ToCharArray();
            int j = s.Length - 1;

            for (int i = 0; i < s.Length / 2; i++)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;

                j--;
            }

            return new string(chars);
        }
    }
}