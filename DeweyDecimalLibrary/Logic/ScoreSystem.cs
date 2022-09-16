namespace DeweyDecimalLibrary.Logic
{
    public static class ScoreSystem
    {
        public static int CalculateScore(int timeLeft)
        {
            // initialise properties
            int timeCompleted = 30 - timeLeft, score = 0;

            // logic structure of points system
            if (timeCompleted < 9)
            {
                score = 10;
            }
            else if (timeCompleted >= 10 || timeCompleted <= 15)
            {
                score = 8;
            }
            else if (timeCompleted >= 16 || timeCompleted <= 21)
            {
                score = 6;
            }
            else if (timeCompleted >= 22 || timeCompleted <= 25)
            {
                score = 3;
            }
            else if (timeCompleted > 26)
            {
                score = 1;
            }

            return score;
        }
    }
}
