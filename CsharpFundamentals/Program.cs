using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>{1, 2};
            var smallests = GetSmallest(numbers, 3);
            
            foreach(var number in smallests)
                Console.WriteLine(number);
        }
        
        public static List<int> GetSmallest(List<int> list, int count)
        {
            var buffer = new List<int>(list)
            var smallest = new List<int>();
            
            while(smallest.Count< count)
            {
                var min = GetSmallest(buffer);
                smallest.Add(min);
                buffer.Remove(min);
            }
            return smallest;
        }
        
        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest 
            var min = list[0];
            
            for(var i = 1; i < list.Count; i++)
            {
               if(list[i] > min)
                   min = list[i]; 
            }
            return min;
        
        
    }
}
