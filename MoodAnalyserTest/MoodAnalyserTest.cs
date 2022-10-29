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
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.Analyser(message);
            Assert.AreEqual(actual, "SAD");
        }

        [TestMethod]
        public void GivenIAmInHappyMood_ShouldReturnSad()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.Analyser(message);
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}