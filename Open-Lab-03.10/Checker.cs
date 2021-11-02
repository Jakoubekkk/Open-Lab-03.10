using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (ch.Equals(letter))
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}
