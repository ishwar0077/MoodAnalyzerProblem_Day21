using MoodAnalyzerProblem;

namespace MoodAnalyserTestCase
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void GivenIAmInSadMood_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.Analyser();
            Assert.AreEqual(actual, "SAD");
        }

        [TestMethod]
        public void GivenIAmInHappyMood_ShouldReturnHappy()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.Analyser();
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}