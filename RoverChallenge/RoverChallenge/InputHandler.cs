using System;
using System.Collections.Generic;

namespace RoverChallenge
{
    public static class InputHandler
    {
        public static List<int> GetGridValues(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            var intList = new List<int>();

            try
            {
                string[] str = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                intList.Add(int.Parse(str[0]));
                intList.Add(int.Parse(str[1]));
            }
            catch (Exception)
            {
                return null;
            }

            return intList;
        }
    }
}