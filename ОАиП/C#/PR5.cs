using System;
using System.Collections.Generic;
using System.Linq;


namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<char> stack = new Stack<char>();
            string cash = Console.ReadLine() ?? "";
        string reversed = "";
        for (int i = cash.Length - 1; i >= 0; i--)
        {
            reversed += cash[i];
        }

            foreach(char s in reversed) {
                stack.Push(s);
            }
            int last = 0;
            int exit = 0;
            for(; stack.Count != 0; stack.Pop()) {
                switch(stack.Peek()) {
                    case '+':
                        exit += last;
                        last = 0;
                        break;
                    case '-':
                        exit -= last;
                        last = 0;
                        break;
                    case >= '0' and <= '9':
                    if(last != 0) {
                        exit += last;
                    }
                        last = int.Parse(stack.Peek().ToString());
                        break;
                }
            } 

            Console.WriteLine(exit); 
        }
    }
}