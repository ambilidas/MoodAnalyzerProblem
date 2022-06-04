using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    internal class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            Null_Message,Empty_Message
        }
        //creating variable Type of ExceptionType
        private readonly ExceptionType type;

        public MoodAnalyserCustomException(ExceptionType Type,string message) : base(message)
        {
            this.type= Type;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.Message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Empty_Message, "Mood should not be empty");
                }
                if (this.Message.Contains("Sad"))
                {
                    return "SAD";

                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Null_Message, "Mood should not be Null");
            }
        }
    }
}
