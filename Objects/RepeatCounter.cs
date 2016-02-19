using System;
using System.Text.RegularExpressions;

namespace CountRepeatWords
{
  public class RepeatCounter
  {
    public int CountRepeats(string inputSentence, string inputWord)
    {
      int wordCount = 0;
      string lowerWord = inputWord.ToLower();
      string lowerSentence = inputSentence.ToLower();
      lowerSentence = Regex.Replace(lowerSentence, @"[^a-z]", @" ");
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
