using System;

namespace CountRepeatWords
{
  public class RepeatCounter
  {
    public int CountRepeats(string inputSentence, string inputWord)
    {
      int wordCount = 0;
      string lowerWord = inputWord.ToLower();
      string lowerSentence = inputSentence.ToLower();
      string[] sentenceArray = lowerSentence.Split(' ');
      foreach (string word in sentenceArray)
      {
        if (word == lowerWord)
        {
          wordCount += 1;
        }

      }
      return wordCount;


    }
  }
}
