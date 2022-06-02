using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTESTandRegexDay20;

namespace MSTestDay20
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            MoodAnalyser obj = new MoodAnalyser("HAPPY");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);


        }


        public void GivenMoodSAD_ShouldReturnSAD()
        {
            MoodAnalyser mood = new MoodAnalyser("SAD");
            string result = mood.analyseMood1();
            Assert.AreEqual("SAD", result);


        }


        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodNull_ShouldThrowException()
        {
            MoodAnalyser obj = new MoodAnalyser(null);
            string result = obj.analyseMood();
            //Assert.AreEqual("123", result);

        }


        [TestMethod]
        public void GivenMoodHappy_ShouldReturnNull()
        {
            MoodAnalyser obj = new MoodAnalyser("null");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }
    }
}