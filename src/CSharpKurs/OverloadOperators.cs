namespace CSharpKurs
{

    /*
    Implement an addition operator +, which adds to planks. Two planks are
    added by returning a new plank with Length equal to the sum of the two previouse.
     */
    public class Plank
    {
        public int Length { get; set; }

        public Plank(int length)
        {
            Length = length;
        }

        //public static Plank operator +(Plank plank1, Plank plank2)
        //{
        //    return new Plank(plank1.Length + plank2.Length);
        //}
    }

}