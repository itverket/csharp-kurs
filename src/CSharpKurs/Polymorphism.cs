using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpKurs
{
    /*
    Alter the Line and Circle classes so that it returns:  "Line,Circle"
    */
    public class DrawingObject
    {
        public virtual string Draw()
        {
            return "Empty";
        }
    }

    public class Line : DrawingObject
    {
        public override string Draw()
        {
            return "Line";
        }
    }

    public class Circle : DrawingObject
    {
        public override string Draw()
        {
            return "Circle";
        }

    }



}
