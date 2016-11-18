using Nancy;
using Hangman.Objects;
using System.Collections.Generic;

namespace Hangman
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/hangman/new_word"] = _ => {
        Game newGame = new Game(Request.Form["new-word"]);
        return View["start_game.cshtml", newGame];
      };

      Post["/hangman/guess_letter"] = _ => {
        newLetter = Request.Form["new-letter"];
        Game.SetGuessedLetters(newLetter);
      };
    }
  }
}
