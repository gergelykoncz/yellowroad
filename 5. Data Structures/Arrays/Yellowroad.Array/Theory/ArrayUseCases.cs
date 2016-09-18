namespace Yellowroad.Array.Theory
{
    public class ArrayUseCases
    {
        public int CalculateSum()
        {
            int firstScore = 1;
            int secondScore = 2;
            int thirdScore = 3;
            int fourthScore = 4;
            int fifthScore = 5;
            int sixthScore = 6;

            return firstScore + secondScore + thirdScore + fourthScore + fifthScore + sixthScore;
        }

        public int CalculateArraySum()
        {
            int[] scores = { 1, 2, 3, 4, 5, 6 };
            int result = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                result += scores[i];
            }

            return result;
        }
    }
}