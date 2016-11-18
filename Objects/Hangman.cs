using System.Collections.Generic;

namespace Hangman.Objects
{
  public class Game
  {
    private string _guessedLetter;
    private string _word; //this holds the hangman word
    private List<string> _guessedLetters = new List<string>{}; //a list to hold guessed letters

    public Game(string word) //passes word from form into _word variable
    {
      _word = word;
    }

    public string GetWord()//gets the variable _word and returns it as public
    {
      return _word;
    }

    public int GetWordLength()//gets the length of the variable
    {
      return _word.Length;
    }

    public void SetGuessedLetters(string newLetter)
    {
      _guessedLetters.Add(newLetter);
    }
  }
}
