using System;

namespace CountRepeatWords
{
  public class RepeatCounter
  {
    public int CountRepeats(string inputSentence, string countWord)
    {
      int wordCount = 0;
      string[] sentenceArray = inputSentence.Split(' ');
      foreach (string word in sentenceArray)
      {
        if (word == countWord)
        {
          wordCount += 1;
        }

      }
      return wordCount;


    }
  }
}
