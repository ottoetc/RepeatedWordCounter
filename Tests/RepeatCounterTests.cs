using Xunit;

namespace CountRepeatWords
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_Test_1_Word()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(1, testRepeatCounter.CountRepeats("lorem", "lorem"));
    }
    [Fact]
    public void CountRepeats_Test_Against_Multiple_Words()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(1, testRepeatCounter.CountRepeats("lorem ipsum", "lorem"));
    }
  }

}
