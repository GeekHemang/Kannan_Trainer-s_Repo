using System;

namespace ConsolePassingParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            CaseStudy1();//Passing an integer to anotehr function

           //CaseStudy2();
        }

        static void CaseStudy2()
        {
            int[] manyScores = { 100, 200, 300, 400 };
            Console.WriteLine(manyScores.GetHashCode());
            UpdateManyScoresToZero(manyScores);
            foreach (int score in manyScores)
            {
                Console.WriteLine(score);
            }
        }

        static void UpdateManyScoresToZero(int[] inputScores)
        {
            Console.WriteLine(inputScores.GetHashCode());
            for (int index = 0; index < inputScores.Length;
                index++)
            {
                inputScores[index] = 0;
            }

        }
        static void CaseStudy1()
        {

            int score = 100;
            UpDateScoreToZero(score);
           // UpDateScoreToZero(ref score);
            Console.WriteLine(score);

        }

        static void UpDateScoreToZero(int inputScore)
        // static void UpDateScoreToZero(ref int inputScore)
        {
            inputScore = 0;
        }
    }
}
