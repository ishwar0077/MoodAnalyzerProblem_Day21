namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Refactor Analyse UC1
            MoodAnalyser mood = new MoodAnalyser("I am in Sad Mood");
            string str = mood.Analyser();
            Console.WriteLine(str);
        }
    }
}