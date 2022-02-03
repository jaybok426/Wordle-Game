using System;

class Program {
  public static void Main (string[] args) {
    //Pick the word to guess
    char FirstLetter = 'H';
    char SecondLetter = 'E';
    char ThirdLetter = 'L';
    char ForthLetter = 'L';
    char FifthLetter = 'O';
    string computerWord = ""+FirstLetter+SecondLetter+ThirdLetter+ForthLetter+FifthLetter;
    int Guesses = 5;
    bool WonGame = false;
    int NumberOfRightLetters = 0;
    //Read in the user's word
    Console.WriteLine("G for the right letter, Y for right letter but in a wrong spot, B for the wrong letter. Guess the 5 letter word! CAPITAL LETTERS ONLY!");
    do{
      NumberOfRightLetters = 0;
    Console.WriteLine("Guess the word");
    string UserhasGuess = Console.ReadLine();
    Guesses--;
    if (Guesses == 0){
      Console.WriteLine("Out of Guesses You have Lost");
    }
    //Go through each letter
      //if letter is in word?
      if (UserhasGuess[0] == FirstLetter){
        //if letter is in right place?
        Console.WriteLine("G");
        NumberOfRightLetters += 1;
       }else if (computerWord.IndexOf(UserhasGuess[0])>-1){
	        Console.WriteLine("Y");
      }else{
          Console.WriteLine("B");
        }
        if (UserhasGuess[1] == SecondLetter){
        //if letter is in right place?
        Console.WriteLine("G");
        NumberOfRightLetters += 1;
        }else if (computerWord.IndexOf(UserhasGuess[1])>-1){
	        Console.WriteLine("Y");
      }else{
          Console.WriteLine("B");
        }
        if (UserhasGuess[2] == ThirdLetter){
        //if letter is in right place?
        Console.WriteLine("G");
        NumberOfRightLetters += 1;
        }else if (computerWord.IndexOf(UserhasGuess[2])>-1){
	        Console.WriteLine("Y");
      }else{
          Console.WriteLine("B");
        }
        if (UserhasGuess[3] == ForthLetter){
        //if letter is in right place?
        Console.WriteLine("G");
        NumberOfRightLetters += 1;
        }else if (computerWord.IndexOf(UserhasGuess[3])>-1){
	        Console.WriteLine("Y");
      }else{
          Console.WriteLine("B");
        }
        if (UserhasGuess[4] == FifthLetter){
        //if letter is in right place?
        Console.WriteLine("G");
        NumberOfRightLetters += 1;
        }else if (computerWord.IndexOf(UserhasGuess[4])>-1){
	        Console.WriteLine("Y");
      }else{
          Console.WriteLine("B");
        }
        //WonGame = true;
      
       if (NumberOfRightLetters == 5){
      WonGame = true; 
    }
      if (WonGame == true){
       Console.WriteLine("You have won");
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