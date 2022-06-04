using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Mood Analyzer Problem");
            MoodAnalyser moodAnalyserobj=new MoodAnalyser();
            Console.WriteLine(moodAnalyserobj.AnalyseMood("I am in Sad mood"));
            Console.WriteLine(moodAnalyserobj.AnalyseMood("I am in any mood"));
            Console.ReadKey();
        }
    }
}
