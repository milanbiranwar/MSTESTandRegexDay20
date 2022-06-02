using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTESTandRegexDay20
{


    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {
        }
        public string analyseMood()
        {
            //"null"==""
            //string s = null;

            //string abc = "";
            try
            {   //"null"==""
                if (this.message.Equals(string.Empty))  // ""=="null"
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException obj)
            {
                //throw new Exception(obj.Message);

                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Console.WriteLine("this is our custom exception");
            }
            finally
            {
                Console.WriteLine("This code will always execute irrespective of exception came or not!!!!");
            }
            return null;


        }

        public string analyseMood1()
        {
            //"null"==""
            //string s = null;

            //string abc = "";
            try
            {   //"null"==""
                if (this.message.Equals(string.Empty))  // ""=="null"
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("happy"))
                    return "Happy";
                else
                    return "SAD";
            }
            catch (NullReferenceException obj)
            {
                //throw new Exception(obj.Message);

                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Console.WriteLine("this is our custom exception");
            }
            finally
            {
                Console.WriteLine("This code will always execute irrespective of exception came or not!!!!");
            }
            return null;
        }
    }
}
