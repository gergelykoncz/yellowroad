namespace Theory
{
    public class Elements
    {
        int[] days = { 1, 2, 3, 4, 5, 6, 7 };

        public int Indexing()
        {
            //Indexing is done by the [] operator
            return days[1]; //Returns 2, since arrays are indexed from 0
        }

        public int Length()
        {
            //Arrays have the Length property which returns how many elements are inside the array.
            return days.Length; //returns 7
        }

        public void Bounds()
        {
            int[] days = { 1, 2, 3, 4, 5, 6, 7 };
            //C# will throw an exception when you try to access an index which is not in the array.
            //To prevent this, use the pattern below.
            for (int i = 0; i < days.Length; i++)
            {
                //You can also modify the values using the indexer
                days[i] += 1;
            }
        }

        public void Foreach()
        {
            //You can save a headache by using the foreach operator, then the runtime will check the bounds for you.
            foreach (int day in days)
            {

            }
        }
    }
}