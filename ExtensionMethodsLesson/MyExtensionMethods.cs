using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsLesson
{
    static class MyExtensionMethods
    {


        public static string ToUpperCase(this string s)
        {
            return s.ToUpperCase();
        }

        public static void ToConsole(this string str)
        {
            Console.WriteLine($"The string is {str}");
        }
        
   



    }
}
