﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpKurs
{
    public static class ExtensionMethods
    {
        /*
        Implement an extension method on string WordCount which
        returns the number of words in the string separated by  white space.
        E.g. if we have:
            var str = "Hello World", then 
            str.WordCount() should return 2
         */
        public static int WordCount(this string str)
        {
            return str.Split(' ').Length;
        }



        /*
        Make and extension to list of ints (i.e. List<int>) called AddToAllIntInList, 
        which takes inn another int. The second int should be added to all the ints in the list.
        E.g. we have a list of ints listOfInts containing {1,2,3}, calling 
        listOfInts.AddToAllIntInList(1) should return a new list containing {2,3,4}
         */
        public static List<int> AddToAllIntInList(this List<int> listOfInts, int additionValue)
        {
            return listOfInts.Select(i => i + additionValue).ToList();
        } 


    }

}