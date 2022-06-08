using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Mood Analyzer Problem");
            //UC 1
            Console.WriteLine(MoodAnalyser1.analyseMood("I am in Sad mood"));
            //Refractor the code
            MoodAnalyser moodanalyserobj = new MoodAnalyser("I am in Sad mood");
            Console.WriteLine(moodanalyserobj.AnalyseMood());
            MoodAnalyser moodanalyserobj2 = new MoodAnalyser("I am in Happy mood");
            Console.WriteLine(moodanalyserobj2.AnalyseMood());
            MoodAnalyser moodanalyserobj3 = new MoodAnalyser("null mood");
            Console.WriteLine(moodanalyserobj3.AnalyseMood());
           // MoodAnalyserCustomException obj11 = new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Empty_Message, "");
           // Console.WriteLine(obj11.AnalyseMood());
            MoodAnalyserCustomException obj12 = new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Null_Message, "Null");
            Console.WriteLine(obj12.AnalyseMood());
            Console.WriteLine(MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyser1", "MoodAnalyser1"));
            
            Console.ReadKey();
        }
    }
}
