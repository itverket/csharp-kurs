using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKurs
{
    public class Task2
    {
        /*
        Given a e.g. {"Keep", "It", "Stupid", "Simple"} as input, 
        should return a new list with the following {"K", "I", "S", "S"}
        */
        public List<string> FirstCharacterOfEachString(IEnumerable<string> listOfStrings)
        {
            return listOfStrings.Select(x => x.Substring(0, 1)).ToList();
        }

    }
}
