using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>{};
            //var smallests = GetSmallest(numbers, 3);
            //var smallests = GetSmallest(number, -1);
             var smallests = GetSmallest(null, 1);
            
            foreach(var number in smallests)
                Console.WriteLine(number);
        }
        
        public static List<int> GetSmallest(List<int> list, int count)
        {
           // if(count > list.Count)
           //     throw new ArgumentOutOfRangeException("count", "Count cannot be greater han the number of elements in the list.");
            
            // if(list.Count == 0)
            if(list == null)
                throw new ArgumentOutOfRangeException("list");
                
            if(count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list.");
            
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
