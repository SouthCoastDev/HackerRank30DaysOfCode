using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        var words = new List<string>();
           
        while (n > 0)
        {
            words.Add(Console.ReadLine());
            n--;
        }
        
        foreach(var word in words)
        {

            var evenLetters = new List<char>();
            var oddLetters = new List<char>();
            
            var index = 0;
            
            foreach(var letter in word)
            {
                if(index % 2 == 0)
                {
                    evenLetters.Add(letter);
                    //Console.WriteLine($"{index}, is even, letter is: {letter}");
                } else
                {
                    oddLetters.Add(letter);
                    //Console.WriteLine($"{index}, is odd, letter is: {letter}");
                }
                      
                index++;
            }
            
            var outPut1 = string.Concat(evenLetters);
            var outPut2 = string.Concat(oddLetters);
            
            Console.WriteLine(outPut1 + " " + outPut2  );
                   
        }
    }
}
