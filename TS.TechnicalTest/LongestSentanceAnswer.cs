
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        
        //null check
        if (String.IsNullOrEmpty(s))
            return 0;

        //Determine sentences
        string[] sentences = s.Split(new char[] { '.', '?', '!' });

        int maxWordsCount = 0;

        foreach (string sentence in sentences)
        {
            Console.WriteLine(sentence);
            
            int countWords = 0;

            string[] words = sentence.Split(new char[] { ' ' });
            foreach (string word in words) 
                countWords++;

            if (countWords > maxWordsCount)
            {
                maxWordsCount = countWords;
            }
        }

        return maxWordsCount;
    }
}
