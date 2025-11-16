
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        
        //null check
        if (String.IsNullOrEmpty(s))
            return 0;

        //Determine sentences
        string[] sentences = s.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        int maxWordsCount = 0;

        foreach (string sentence in sentences)
        {
            Console.WriteLine(sentence);
            
            int countWords = 0;

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (string word in words)
            {
                if(HasLetter(word))
                    countWords++;
            }

            if (countWords > maxWordsCount)
            {
                maxWordsCount = countWords;
            }
        }

        return maxWordsCount;
    }

    private static bool HasLetter(string word)
    {
        //check if it' a word
        foreach (char letter in word)
        {
            if (char.IsLetter(letter))
            {
                return true;
            }
        }

        return false;
    }
}
