using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpKurs
{
    /*
    By altering _only_ Line and Circle, make the SumOfSizes return 12.
    !Tip: Add methods
    */

    public class OverloadShapes
    {
        public List<Shape> Shapes = new List<Shape> {new Shape(), new Circle(), new Line()};

        public int SumOfSize()
        {
            return Shapes.Sum(s => s.Size);
        }

    }
    public class Shape
    {
        public virtual int Size => 0;
    }

    public class Line : Shape
    {
        int length = 2;

        public override int Size => length;
    }

    public class Circle : Shape
    {
        int radius = 5;
        public override int Size => radius*2;
    }



}
