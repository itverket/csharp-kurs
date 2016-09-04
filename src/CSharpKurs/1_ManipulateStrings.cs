using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpKurs
{
     /* 
        We will start with some simple tasks that show different ways to work with strings in C#
     */
    public class ManipulateStrings
    {
        /* 
            In C# the '+' operator can be used to concat two strings. Make the following method return the string "Hello World".
        */
        public string PlusOperatorConcatStrings()
        {
            return "";
        }

        /* 
            We can use the built-in string.Format method to format strings with variables. Use the string.Format("abc {0} def {1}, variable, variable) syntax to return the string "Hello to you too World"
        */
        public string StringFormat()
        {
            return "";
        }

        /* 
            C# version 6 added a new way to format strings called string interpolation. This uses the $ operator before '"' and allows you to use variables (and method calls) inside curly brackets in the string.
            Try to return the same string as the previous task using string interpolation.
        */
        public string StringInterpolation()
        {
            return "";
        }

        /* 
            The string type also has a built in method to check for null or empty strings. Make the method CheckForNullOrEmpty return "Empty string" if the string "input" is null or empty, and "Hello World" in any other case.
        */
        public string CheckForNullOrEmpty(string input)
        {
            return "";
        }
    }
}
