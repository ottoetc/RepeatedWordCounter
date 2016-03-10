using Xunit;

namespace CountRepeatWords
{
  public class RepeatCounterTest
  {
    [Fact]
    public void Test_ForNoPartials()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal("The phrase: cat cathedral contains the word cat 1 time!", testRepeatCounter.CountRepeats("cat cathedral", "cat"));
    }
    [Fact]
    public void CountRepeats_Test_1_Word()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal("The phrase: lorem contains the word lorem 1 time!", testRepeatCounter.CountRepeats("lorem", "lorem"));
    }
    [Fact]
    public void CountRepeats_Test_Against_Multiple_Words()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal("The phrase: lorem ipsum contains the word lorem 1 time!", testRepeatCounter.CountRepeats("lorem ipsum", "lorem"));
    }
    [Fact]
    public void CountRepeats_CountsAWordMultipleTimes()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal("The phrase: coffee coffee contains the word coffee 2 times!", testRepeatCounter.CountRepeats("coffee coffee", "coffee"));
    }
    [Fact]
    public void CountRepeats_Test_CountMultiple()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal("The phrase: one fish, two fish, red fish, blue fish contains the word fish 4 times!", testRepeatCounter.CountRepeats("one fish, two fish, red fish, blue fish", "fish"));
    }
    [Fact]
    public void CountRepeats_Test_CountsCapitals()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal("The phrase: lorem contains the word LOREM 1 time!", testRepeatCounter.CountRepeats("lorem", "LOREM"));
    }
  }

}
