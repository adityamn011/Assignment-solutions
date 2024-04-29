using System;

    internal class HardQ7
    {
        static void Main()
        {
            string input = "bananas";
            string longestPalindrome = LongestPalindrome(input);
            Console.WriteLine("Longest palindromic substring of \"" + input + "\" is: " + longestPalindrome);
        }
        static string LongestPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            int start = 0;
            int maxLength = 1;
            for (int i = 0; i < input.Length; i++)
            {
                // Check for odd length palindromes
                int left = i;
                int right = i;
                while (left >= 0 && right < input.Length && input[left] == input[right])
                {
                    int length = right - left + 1;
                    if (length > maxLength)
                    {
                        start = left;
                        maxLength = length;
                    }
                    left--;
                    right++;
                }
                // Check for even length palindromes
                left = i;
                right = i + 1;
                while (left >= 0 && right < input.Length && input[left] == input[right])
                {
                    int length = right - left + 1;
                    if (length > maxLength)
                    {
                        start = left;
                        maxLength = length;
                    }
                    left--;
                    right++;
                }
            }
            return input.Substring(start, maxLength);
        }

    }

