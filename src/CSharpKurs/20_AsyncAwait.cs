using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace CSharpKurs
{
    public class AsyncAwait
    {
        private readonly John John = new John();
        private readonly Clair Clair = new Clair();

        public int TotalStarsOnRefridgitrator => John.StarsOnRefridgirator + Clair.StarsOnRefridgirator;


        /*
        The following method tells Clair and John to go do their duties.
        When they are done they receive a star on the refridgirator.
        As the method is implemented now, it will take over 10 seconds total 
        for both to complete their tasks, because Clair waits for John to finish
        before starting her task.

        Change the method, and make it complete in 5 seconds!
        */

        public async Task TellTheKidsToDoTheirDuties()
        {
            await John.CleanRoom();
            await Clair.TakeOutGarbage();
        }
    }


    public class John
    {
        public int StarsOnRefridgirator { get; set; } = 0;

        public async Task CleanRoom()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            StarsOnRefridgirator++;

        }
    }
    public class Clair
    {
        public int StarsOnRefridgirator { get; set; } = 0;
        public async Task TakeOutGarbage()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            StarsOnRefridgirator++;
        }
    }
}
