﻿using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Mood Analyzer Problem");
            //MoodAnalyser moodAnalyserobj=new MoodAnalyser();
            //Console.WriteLine(moodAnalyserobj.AnalyseMood("I am in Sad mood"));
            //Console.WriteLine(moodAnalyserobj.AnalyseMood("I am in any mood"));
            //Refractor the code
            MoodAnalyser moodanalyserobj = new MoodAnalyser("I am in Sad mood");
            Console.WriteLine(moodanalyserobj.AnalyseMood());
            MoodAnalyser moodanalyserobj2 = new MoodAnalyser("I am in Happy mood");
            Console.WriteLine(moodanalyserobj2.AnalyseMood());
            MoodAnalyser moodanalyserobj3 = new MoodAnalyser("null mood");
            Console.WriteLine(moodanalyserobj3.AnalyseMood());
            Console.ReadKey();
        }
    }
}
