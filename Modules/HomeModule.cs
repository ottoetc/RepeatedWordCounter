using Nancy;
using System;
using CountRepeatWords;

namespace CountRepeatWordsModule
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/inputform"] = _ =>
      {
        RepeatCounter newRepeatCounter = new RepeatCounter();
        int score = newRepeatCounter.CountRepeats(Request.Form["input-sentence"], Request.Form["input-word"]);
        return View["results.cshtml"];
      };
    }
  }
}
