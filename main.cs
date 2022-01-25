using System;

class Program {
  public static void Main (string[] args) {
    //Pick the word to guess
    string computerWord = "HELLO";
    int Guesses = 5;
    bool WonGame = false;
    //Read in the user's word
    do{
    Console.WriteLine("Guess the word");
    string UserhasGuess = Console.ReadLine();
    Guesses--;
    if (Guesses == 0){
      Console.WriteLine("Out of Guesses You have Lost");
    }
    //Go through each letter
      //if letter is in word?
      if (UserhasGuess == computerWord){
        //if letter is in right place?
        Console.WriteLine("You have won");
        WonGame = true;
      }
      if (WonGame == true){
      System.Environment.Exit(0); 
    }
          //print "G"
        //else
          //print "Y"
      //else 
        //print"B"
    }while (Guesses>0);
  }
}