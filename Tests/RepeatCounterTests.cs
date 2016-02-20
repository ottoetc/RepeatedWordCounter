using Xunit;

namespace CountRepeatWords
{
  public class RepeatCounterTest
  {
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
