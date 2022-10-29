namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ability to Analyse Happy or Sat UC1
            MoodAnalyser mood = new MoodAnalyser();
            string str = mood.Analyser("I am in Sad Mood");
            Console.WriteLine(str);
        }
    }
}