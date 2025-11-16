
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
            int countWords = 0;

            // remove spaces
            string trimmedSentence = sentence.Trim();

            //Get Words from sentence
            string[] words = trimmedSentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (string word in words)
            {
                if(HasLetter(word))
                    countWords++;
            }

            //Ensure you have the largest count in every iteration
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
